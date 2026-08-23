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
    public class FilamentTypeRepository : 
            DapperRepositoryBase, 
            ICrudRepository<FilamentTypeModel>, 
            ICrudGridRepository<FilamentTypeGridModel>
    {
        public FilamentTypeRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<FilamentTypeModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            ft.id,
                            ft.name,
                            ft.logcruddate AS LogCrudDate,
                            ft.logcrudtype AS LogCrudType,
                            ua.username AS LogUserName
                        FROM tb_filamenttype ft
                        LEFT JOIN tb_useraccount ua
                            ON ft.logcruduserid = ua.id
                        WHERE ft.id = @id
                        AND ft.logcrudtype <> '3'";
            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<FilamentTypeModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<FilamentTypeGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            ft.id,
                            ft.name
                        FROM tb_filamenttype ft
                        WHERE ft.logcrudtype <> '3'
                        ORDER BY ft.id";
            using (var con = CreateConnection())
            {
                return (await con.QueryAsync<FilamentTypeGridModel>(sql)).ToList();
            }
        }

        public async Task<FilamentTypeModel> InsertAsync(FilamentTypeModel model)
        {
            string sql = @"
                        INSERT INTO tb_filamenttype
                        (
                            name,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
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
        public async Task<IList<FilamentTypeModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_filamenttype
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentTypeModel>(sql);
                return result.ToList();
            }
        }
        public async Task<FilamentTypeModel> UpdateAsync(FilamentTypeModel model)
        {
            string sql = @"
                        UPDATE tb_filamenttype
                        SET
                            name = @Name,
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
                        UPDATE tb_filamenttype
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

        public async Task<List<FilamentTypeModel>> GetFilamentTypesAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name
                        FROM tb_filamenttype    
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<FilamentTypeModel> types;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<FilamentTypeModel>(sql);
                types = result.ToList();
            }

            return types;
        }
    }
}
