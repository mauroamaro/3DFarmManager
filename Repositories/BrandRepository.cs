using _3DFarmManager.Framework.Data;
using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DFarmManager.Repositories
{
    public class BrandRepository :
        DapperRepositoryBase,
        ICrudRepository<BrandModel>,
        ICrudGridRepository<BrandGridModel>
    {

        public BrandRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<BrandModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            b.id,
                            b.name,
                            b.url AS Url,
                            b.logcruddate AS LogCrudDate,
                            b.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_brand b
                        LEFT JOIN tb_useraccount u
                            ON b.logcruduserid = u.id
                        WHERE b.id = @id
                        AND b.logcrudtype <> '3'";

            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<BrandModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<BrandGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            b.id,
                            b.name,
                            b.url AS Url
                        FROM tb_brand b
                        WHERE b.logcrudtype <> '3'
                        ORDER BY b.id";

            using (var con = CreateConnection())
            {
                var result = 
                    await con.QueryAsync<BrandGridModel>(sql);

                return result.ToList();
            }
        }
        public async Task<BrandModel> InsertAsync(BrandModel model)
        {
            string sql = @"
                        INSERT INTO tb_brand
                        (
                            name,
                            url,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @Url,
                            @LogCrudDate,
                            @LogCrudUserId,
                            '1'
                        )
                        RETURNING id;";

            using (var con = CreateConnection())
            {
                long id =
                    await con.ExecuteScalarAsync<long>(sql, model);

                return await GetByIdAsync(id);
            }
        }
        public async Task<IList<BrandModel>> GetAllAsync()
        {
            string sql = @"
        SELECT *
        FROM tb_brand
        WHERE logcrudtype <> '3'
        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<BrandModel>(sql);
                return result.ToList();
            }
        }
        public async Task<BrandModel> UpdateAsync(BrandModel model)
        {
            string sql = @"
                        UPDATE tb_brand
                        SET
                            name = @Name,
                            url = @Url,
                            logcruddate = @LogCrudDate,
                            logcruduserid = @LogCrudUserId,
                            logcrudtype = '2'
                        WHERE id = @Id";

            using (var con = CreateConnection())
            {
                await con.ExecuteAsync(sql, model);
            }
            
            return await GetByIdAsync(model.Id);
        }

        public async Task DeleteAsync(long id, long userId)
        {
            string sql = @"
                        UPDATE tb_brand
                        SET
                            logcrudtype = '3',
                            logcruddate = NOW(),
                            logcruduserid = @userId
                        WHERE id = @id";

            using (var con = CreateConnection())
            {
                await con.ExecuteAsync(sql, new
                {
                    id,
                    userId
                });
            }
        }
        
        public async Task<List<BrandModel>> GetBrandsAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            url
                        FROM tb_brand
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<BrandModel> brands;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<BrandModel>(sql);
                brands = result.ToList();
            }

            return brands;
        }
    }
}
