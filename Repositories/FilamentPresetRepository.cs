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
    public class FilamentPresetRepository :
        DapperRepositoryBase,
        ICrudRepository<FilamentPresetModel>,
        ICrudGridRepository<FilamentPresetGridModel>
    {
        public FilamentPresetRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<FilamentPresetModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.nozzletemp AS NozzleTemp,
                            f.platetemp AS PlateTemp,
                            f.flowrate AS FlowRate,
                            f.logcruddate AS LogCrudDate,
                            f.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_filamentpreset f
                        LEFT JOIN tb_useraccount u
                            ON f.logcruduserid = u.id
                        WHERE f.id = @id
                        AND f.logcrudtype <> '3'";

            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<FilamentPresetModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<FilamentPresetGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.nozzletemp AS NozzleTemp,
                            f.platetemp AS PlateTemp,
                            f.flowrate AS FlowRate
                        FROM tb_filamentpreset f
                        WHERE f.logcrudtype <> '3'
                        ORDER BY f.id";
            using (var con = CreateConnection())
            {
                var result =
                    await con.QueryAsync<FilamentPresetGridModel>(sql);
                return result.ToList();
            }
        }
        public async Task<FilamentPresetModel> InsertAsync(FilamentPresetModel model)
        {
            string sql = @"
                        INSERT INTO tb_filamentpreset
                        (
                            name,
                            nozzletemp,
                            platetemp,
                            flowrate,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @NozzleTemp,
                            @PlateTemp,
                            @FlowRate,
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
        public async Task<IList<FilamentPresetModel>> GetAllAsync()
        {
            string sql = @"
        SELECT *
        FROM tb_filamentpreset
        WHERE logcrudtype <> '3'
        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentPresetModel>(sql);
                return result.ToList();
            }
        }
        public async Task<FilamentPresetModel> UpdateAsync(FilamentPresetModel model)
        {
            string sql = @"
                        UPDATE tb_filamentpreset
                        SET
                            name = @Name,
                            nozzletemp = @NozzleTemp,
                            platetemp = @PlateTemp,
                            flowrate = @FlowRate,
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
                        UPDATE tb_filamentpreset
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

        public async Task<List<FilamentPresetModel>> GetFilamentPresetsAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            nozzletemp,
                            platetemp,
                            flowrate
                        FROM tb_filamentpreset
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<FilamentPresetModel> filamentPresets;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<FilamentPresetModel>(sql);
                filamentPresets = result.ToList();
            }

            return filamentPresets;
        }

    }
}
