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
    public class _3DPrinterRepository :
        DapperRepositoryBase,
        ICrudRepository<_3DPrinterModel>,
        ICrudGridRepository<_3DPrinterGridModel>
    {

        public _3DPrinterRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<_3DPrinterModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            p.id,
                            p.name,
                            p.brandid AS BrandId,
                            p.purchasedate AS PurchaseDate,
                            p.startdateoperation AS StartOperationDate,
                            p.purchaseprice AS PurchasePrice,
                            p.estimatedmaintenancecost AS MaintenanceCost,
                            p.annualmaintenancecostincurred AS AnnualMaintenanceCost,
                            p.usefulllife AS UsefullLife,
                            p.electricityconsumption AS ElectricityConsumption,
                            p.depreciation AS Depreciation,
                            p.logcruddate AS LogCrudDate,
                            p.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_3dprinter p
                        LEFT JOIN tb_useraccount u
                            ON p.logcruduserid = u.id
                        WHERE p.id = @id
                        AND p.logcrudtype <> '3'";

            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<_3DPrinterModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<_3DPrinterGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            p.id,
                            p.name,
                            b.name AS BrandName,
                            p.purchasedate AS PurchaseDate,
                            p.purchaseprice AS PurchasePrice,
                            p.startdateoperation AS StartOperationDate,
                            p.usefulllife AS UsefullLife,
                            p.estimatedmaintenancecost AS MaintenanceCost,
                            p.annualmaintenancecostincurred AS AnnualMaintenanceCost,
                            p.electricityconsumption AS ElectricityConsumption,
                            p.depreciation AS DepreciationValue
                        FROM tb_3dprinter p
                        LEFT JOIN tb_brand b
                            ON p.brandid = b.id
                        WHERE p.logcrudtype <> '3'
                        ORDER BY p.id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<_3DPrinterGridModel>(sql);
                return result.ToList();
            }
        }

        public async Task<_3DPrinterModel> InsertAsync(_3DPrinterModel model)
        {
            string sql = @"
                        INSERT INTO tb_3dprinter
                        (
                            name,
                            brandid,
                            purchasedate,
                            startdateoperation,
                            purchaseprice,
                            estimatedmaintenancecost,
                            annualmaintenancecostincurred,
                            usefulllife,
                            electricityconsumption,
                            depreciation,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @BrandId,
                            @PurchaseDate,
                            @StartOperationDate,
                            @PurchasePrice,
                            @MaintenanceCost,
                            @AnnualMaintenanceCost,
                            @UsefullLife,
                            @ElectricityConsumption,
                            @Depreciation,
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

        public async Task<List<_3DPrinterModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_3dprinter
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<_3DPrinterModel>(sql);
                return result.ToList();
            }
        }

        public async Task<_3DPrinterModel> UpdateAsync(_3DPrinterModel model)
        {
            string sql = @"
                        UPDATE tb_3dprinter
                        SET
                        name = @Name,
                        brandid = @BrandId,
                        purchasedate = @PurchaseDate,
                        startdateoperation = @StartOperationDate,
                        purchaseprice = @PurchasePrice,
                        estimatedmaintenancecost = @MaintenanceCost,
                        annualmaintenancecostincurred = @AnnualMaintenanceCost,
                        usefulllife = @UsefullLife,
                        electricityconsumption = @ElectricityConsumption,
                        depreciation = @Depreciation,
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
                        UPDATE tb_3dprinter
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
        public async Task<List<_3DPrinterModel>> Get3DPrintersAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            url
                        FROM tb_3dprinter
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<_3DPrinterModel> printers;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<_3DPrinterModel>(sql);
                printers = result.ToList();
            }

            return printers;
        }

    }
}
