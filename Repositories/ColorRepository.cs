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
    public class ColorRepository : 
            DapperRepositoryBase, 
            ICrudRepository<ColorModel>, 
            ICrudGridRepository<ColorGridModel>
    {
        public ColorRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<ColorModel> GetByIdAsync(long id)
        {
            string sql = @"
                        SELECT
                            c.id,
                            c.name,
                            c.colorhexcode,
                            c.colorrgbcode,
                            c.logcruddate AS LogCrudDate,
                            c.logcrudtype AS LogCrudType,
                            u.username AS LogUserName
                        FROM tb_color c
                        LEFT JOIN tb_useraccount u
                            ON c.logcruduserid = u.id
                        WHERE c.id = @id
                        AND c.logcrudtype <> '3'";
            using (var con = CreateConnection())
            {
                return await con.QueryFirstOrDefaultAsync<ColorModel>(
                    sql,
                    new { id });
            }
        }

        public async Task<IList<ColorGridModel>> GetGridDataAsync()
        {
            string sql = @"
                        SELECT
                            c.id,
                            c.name,
                            c.colorhexcode,
                            c.colorrgbcode
                        FROM tb_color c
                        WHERE c.logcrudtype <> '3'
                        ORDER BY c.id";
            using (var con = CreateConnection())
            {
                return (await con.QueryAsync<ColorGridModel>(sql)).ToList();
            }
        }

        public async Task<ColorModel> InsertAsync(ColorModel model)
        {
            string sql = @"
                        INSERT INTO tb_color
                        (
                            name,
                            colorhexcode,
                            colorrgbcode,
                            logcruddate,
                            logcruduserid,
                            logcrudtype
                        )
                        VALUES
                        (
                            @Name,
                            @ColorHexCode,
                            @ColorRgbCode,
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
        public async Task<IList<ColorModel>> GetAllAsync()
        {
            string sql = @"
                        SELECT *
                        FROM tb_color
                        WHERE logcrudtype <> '3'
                        ORDER BY id";

            using (var con = CreateConnection())
            {
                var result = await con.QueryAsync<ColorModel>(sql);
                return result.ToList();
            }
        }
        public async Task<ColorModel> UpdateAsync(ColorModel model)
        {
            string sql = @"
                        UPDATE tb_color
                        SET
                            name = @Name,
                            colorhexcode = @ColorHexCode,
                            colorrgbcode = @ColorRgbCode,
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
                        UPDATE tb_color 
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

        public async Task<List<ColorModel>> GetColorsAsync()
        {
            string sql = @"
                        SELECT
                            id,
                            name,
                            colorhexcode,
                            colorrgbcode
                        FROM tb_color    
                        WHERE logcrudtype <> '3'
                        ORDER BY name";

            List<ColorModel> colors;
            using (var con = new NpgsqlConnection(GlobalVar.AppConnString))
            {
                var result = await con.QueryAsync<ColorModel>(sql);
                colors = result.ToList();
            }

            return colors;
        }
    }
}
