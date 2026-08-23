using _3DFarmManager.Framework.Data;
using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DFarmManager.Repositories
{
    public class ExpensesFixedRepository :
        DapperRepositoryBase,
        ICrudRepository<ExpensesFixedModel>,
        ICrudGridRepository<ExpensesFixedGridModel>
    {
        public ExpensesFixedRepository(string connectionString) : base(connectionString)
        {
        }

        #region Grid

        public async Task<IList<ExpensesFixedGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            b.id,
                            b.name,
                            b.description AS Description,
                            b.expensevalue AS ExpenseValue
                        FROM tb_expensesfixed b
                        WHERE b.logcrudtype <> '3'
                        ORDER BY b.id;";

            using (var con = CreateConnection())
            {
                var result =
                    await con.QueryAsync<ExpensesFixedGridModel>(sql);

                return result.ToList();
            }
        }

        #endregion

        #region GetById

        public async Task<ExpensesFixedModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            b.id,
                            b.name,
                            b.description AS Description,
                            b.expensevalue AS ExpenseValue,
                            b.logcruddate AS LogCrudDate,
                            b.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_expensesfixed b
                        LEFT JOIN tb_useraccount u
                            ON u.id = b.logcruduserid
                        WHERE b.id = @id
                        AND b.logcrudtype <> '3';";

            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<ExpensesFixedModel>(
                    sql,
                    new { id });
            }
        }

        #endregion

        #region Insert

        public async Task<ExpensesFixedModel> InsertAsync(
            ExpensesFixedModel model)
        {
            string sql = @"
                        INSERT INTO tb_expensesfixed
                        (
                            name,
                            description,
                            expensevalue,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @Description,
                            @ExpenseValue,
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

        #endregion

        #region Update

        public async Task<ExpensesFixedModel> UpdateAsync(
            ExpensesFixedModel model)
        {
            string sql = @"
                        UPDATE tb_expensesfixed
                        SET
                            name = @Name,
                            description = @Description,
                            expensevalue = @ExpenseValue,
                            logcruddate = @LogCrudDate,
                            logcruduserid = @LogCrudUserId,
                            logcrudtype = '2'
                        WHERE id = @Id;";

            using (var con = CreateConnection())
            {
                await con.ExecuteAsync(sql, model);
            }

            return await GetByIdAsync(model.Id);
        }

        #endregion

        #region Delete

        public async Task DeleteAsync(long id, long userId)
        {
            string sql = @"
                        UPDATE tb_expensesfixed
                        SET
                            logcrudtype = '3',
                            logcruddate = NOW(),
                            logcruduserid = @userId
                        WHERE id = @id;";

            using (var con = CreateConnection())
            {
                await con.ExecuteAsync(sql, new
                {
                    id,
                    userId
                });
            }
        }

        #endregion

        #region Extra Methods

        public async Task<IList<ExpensesFixedModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_expensesfixed
                        WHERE logcrudtype <> '3'
                        ORDER BY id;";

            using (var con = CreateConnection())
            {
                var result =
                    await con.QueryAsync<ExpensesFixedModel>(sql);

                return result.ToList();
            }
        }

        #endregion
    }
}
