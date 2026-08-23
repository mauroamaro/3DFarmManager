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
    public class FilamentSubCategoryRepository : 
            DapperRepositoryBase, 
            ICrudRepository<FilamentSubCategoryModel>, 
            ICrudGridRepository<FilamentSubCategoryGridModel>
    {
        public FilamentSubCategoryRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<FilamentSubCategoryModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.categoryid AS CategoryId,
                            f.logcruddate AS LogCrudDate,
                            f.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_filamentsubcategory f
                        LEFT JOIN tb_useraccount u
                            ON f.logcruduserid = u.id
                        WHERE f.id = @id
                        AND f.logcrudtype <> '3'";
            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<FilamentSubCategoryModel>(
                    sql,
                    new { id });
            }
        }
        public async Task<IList<FilamentSubCategoryGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.categoryid
                        FROM tb_filamentsubcategory f
                        WHERE f.logcrudtype <> '3'
                        ORDER BY f.id";
            using (var con = CreateConnection())
            {
                return (await con.QueryAsync<FilamentSubCategoryGridModel>(sql)).ToList();
            }
        }

        public async Task<FilamentSubCategoryModel> InsertAsync(FilamentSubCategoryModel model)
        {
            string sql = @"
                        INSERT INTO tb_filamentsubcategory
                        (
                            name,
                            categoryid,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @CategoryId,
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
        public async Task<IList<FilamentSubCategoryModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_filamentsubcategory
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentSubCategoryModel>(sql);
                return result.ToList();
            }
        }
        public async Task<FilamentSubCategoryModel> UpdateAsync(FilamentSubCategoryModel model)
        {
            string sql = @"
                        UPDATE tb_filamentsubcategory
                        SET
                            name = @Name,
                            categoryid = @CategoryId,
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
                        UPDATE tb_filamentsubcategory
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

        public async Task<List<FilamentSubCategoryModel>> GetFilamentSubCategoriesAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            categoryid
                        FROM tb_filamentsubcategory    
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<FilamentSubCategoryModel> filamentSubCategories;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<FilamentSubCategoryModel>(sql);
                filamentSubCategories = result.ToList();
            }

            return filamentSubCategories;
        }

    }
}
