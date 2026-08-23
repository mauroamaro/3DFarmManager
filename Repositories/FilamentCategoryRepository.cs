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
    public class FilamentCategoryRepository : 
            DapperRepositoryBase, 
            ICrudRepository<FilamentCategoryModel>, 
            ICrudGridRepository<FilamentCategoryGridModel>

    {
        public FilamentCategoryRepository(string connectionString) : base(connectionString)
        {
        }
        public async Task<FilamentCategoryModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.logcruddate AS LogCrudDate,
                            f.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_filamentcategory f
                        LEFT JOIN tb_useraccount u
                            ON f.logcruduserid = u.id
                        WHERE f.id = @id
                        AND f.logcrudtype <> '3'";
            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<FilamentCategoryModel>(
                    sql,
                    new { id });
            }
        }
        public async Task<IList<FilamentCategoryGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name
                        FROM tb_filamentcategory f
                        WHERE f.logcrudtype <> '3'
                        ORDER BY f.id";
            using (var con = CreateConnection())
            {
                return (await con.QueryAsync<FilamentCategoryGridModel>(sql)).ToList();
            }
        }

        public async Task<FilamentCategoryModel> InsertAsync(FilamentCategoryModel model)
        {
            string sql = @"
                        INSERT INTO tb_filamentcategory
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
        public async Task<IList<FilamentCategoryModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_filamentcategory
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentCategoryModel>(sql);
                return result.ToList();
            }
        }
        public async Task<FilamentCategoryModel> UpdateAsync(FilamentCategoryModel model)
        {
            string sql = @"
                        UPDATE tb_filamentcategory
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
                        UPDATE tb_filamentcategory
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

        public async Task<List<FilamentCategoryModel>> GetFilamentCategoriesAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name
                        FROM tb_filamentcategory    
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<FilamentCategoryModel> filamentCategories;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<FilamentCategoryModel>(sql);
                filamentCategories = result.ToList();
            }

            return filamentCategories;
        }



    }
}
