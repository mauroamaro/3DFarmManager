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
    public class UnitRepository : 
            DapperRepositoryBase, 
            ICrudRepository<UnitModel>, 
            ICrudGridRepository<UnitGridModel>
    {
        public UnitRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<UnitModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            u.id,
                            u.name,
                            u.shortname AS ShortName,
                            u.logcruddate AS LogCrudDate,
                            u.logcrudtype AS LogCrudType,
                            ua.username AS LogUserName
                        FROM tb_unit u
                        LEFT JOIN tb_useraccount ua
                            ON u.logcruduserid = ua.id
                        WHERE u.id = @id
                        AND u.logcrudtype <> '3'";
            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<UnitModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<UnitGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            u.id,
                            u.name,
                            u.shortname AS ShortName 
                        FROM tb_unit u
                        WHERE u.logcrudtype <> '3'
                        ORDER BY u.id";
            using (var con = CreateConnection())
            {
                return (await con.QueryAsync<UnitGridModel>(sql)).ToList();
            }
        }

        public async Task<UnitModel> InsertAsync(UnitModel model)
        {
            string sql = @"
                        INSERT INTO tb_unit
                        (
                            name,
                            shortname,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @ShortName,
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
        public async Task<IList<UnitModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_unit
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<UnitModel>(sql);
                return result.ToList();
            }
        }
        public async Task<UnitModel> UpdateAsync(UnitModel model)
        {
            string sql = @"
                        UPDATE tb_unit
                        SET
                            name = @Name,
                            shortname = @ShortName,
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
                        UPDATE tb_unit
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

        public async Task<List<UnitModel>> GetUnitsAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            shortname
                        FROM tb_unit    
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<UnitModel> units;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<UnitModel>(sql);
                units = result.ToList();
            }

            return units;
        }
    }
}
