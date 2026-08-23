using _3DFarmManager.Framework.Data;
using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Models;
using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DFarmManager.Repositories
{
    public class FilamentRepository :
        DapperRepositoryBase,
        ICrudRepository<FilamentModel>,
        ICrudGridRepository<FilamentGridModel>
    {
        public FilamentRepository(string connectionString) : base(connectionString)
        {
        }
        
        public async Task<FilamentModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            f.idbrand AS BrandId,
                            f.idcategory AS CategoryId,
                            f.idsubcategory AS SubCategoryId,
                            f.idcolor AS ColorId,
                            f.idunit AS UnitId,
                            f.idpreset AS PresetId,
                            f.idfilamenttype AS FilamentTypeId,
                            f.filamentcost AS FilamentCost,
                            f.qtinventory AS StockQuantity,
                            f.recommnozzletemp AS RecommNozzleTemp,
                            f.recommplatetemp AS RecommPlateTemp,
                            f.recommflowrate AS RecommFlowRate,
                            f.logcruddate AS LogCrudDate,
                            f.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_filament f
                        LEFT JOIN tb_useraccount u
                            ON f.logcruduserid = u.id
                        WHERE f.id = @id
                        AND f.logcrudtype <> '3'";

            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<FilamentModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<FilamentGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            f.id,
                            f.name,
                            b.name AS BrandName,
                            c.name AS CategoryName,
                            s.name AS SubCategoryName,
                            l.name AS ColorName,
                            u.shortname AS UnitShortName,
                            p.name AS PresetName,
                            t.name AS FilamentTypeName,
                            f.filamentcost AS FilamentCost,
                            f.qtinventory AS StockQuantity,
                            f.recommnozzletemp AS RecommNozzleTemp,
                            f.recommplatetemp AS RecommPlateTemp,
                            f.recommflowrate AS RecommFlowRate
                        FROM tb_filament f
                        LEFT JOIN tb_brand b
                            ON f.idbrand = b.id
                        LEFT JOIN tb_filamentcategory c
                            ON f.idcategory = c.id
                        LEFT JOIN tb_filamentsubcategory s
                            ON f.idsubcategory = s.id
                        LEFT JOIN tb_color l
                            ON f.idcolor = l.id
                        LEFT JOIN tb_unit u
                            ON f.idunit = u.id
                        LEFT JOIN tb_filamentpreset p
                            ON f.idpreset = p.id
                        LEFT JOIN tb_filamenttype t
                            ON f.idfilamenttype = t.id
                        WHERE f.logcrudtype <> '3'
                        ORDER BY f.id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentGridModel>(sql);
                return result.ToList();
            }
        }

        public async Task<FilamentModel> InsertAsync(FilamentModel model)
        {
            string sql = @"
                        INSERT INTO tb_filament
                        (
                            name,
                            idbrand,
                            idcategory,
                            idsubcategory,
                            idcolor,
                            idunit,
                            idpreset,
                            idfilamenttype,
                            filamentcost,
                            qtinventory,
                            recommnozzletemp,
                            recommplatetemp,
                            recommflowrate,
                            logcruddate,
                            logcrudtype,
                            logcruduserid
                        )
                        VALUES
                        (
                            @Name,
                            @BrandId,
                            @CategoryId,
                            @SubCategoryId,
                            @ColorId,
                            @UnitId,
                            @PresetId,
                            @FilamentTypeId,
                            @FilamentCost,
                            @StockQuantity,
                            @RecommNozzleTemp,
                            @RecommPlateTemp,
                            @RecommFlowRate,
                            @LogCrudDate,
                            @LogCrudUserId,
                            '1'
                        )
                        RETURNING id;";

            using (var con = CreateConnection())
            {
                long id = await con.ExecuteScalarAsync<long>(sql, model);

                return await GetByIdAsync(id);
            }
        }

        public async Task<List<FilamentModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_filament
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<FilamentModel>(sql);
                return result.ToList();
            }
        }

        public async Task<FilamentModel> UpdateAsync(FilamentModel model)
        {
            string sql = @"
                        UPDATE tb_filament
                        SET
                        name = @Name,
                        idbrand = @BrandId,
                        idcategory = @CategoryId,
                        idsubcategory = @SubCategoryId,
                        idcolor = @ColorId,
                        idunit = @UnitId,
                        idpreset = @PresetId,
                        idfilamenttype = @FilamentTypeId,
                        filamentcost = @FilamentCost,
                        qtinventory = @StockQuantity,
                        recommnozzletemp = @RecommNozzleTemp,
                        recommplatetemp = @RecommPlateTemp,
                        recommflowrate = @RecommFlowRate,
                        logcruddate = @LogCrudDate,
                        logcrudtype = '2',
                        logcruduserid = @LogCrudUserId
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
                        UPDATE tb_filament
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
        public async Task<List<FilamentModel>> GetFilamentsAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            url
                        FROM tb_filament
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<FilamentModel> printers;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<FilamentModel>(sql);
                printers = result.ToList();
            }

            return printers;
        }


    }
}
