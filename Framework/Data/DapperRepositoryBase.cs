using Npgsql;
using System;

namespace _3DFarmManager.Framework.Data
{
    /// <summary>
    /// Classe base para todos os repositórios Dapper.
    /// Centraliza a criação da conexão com o PostgreSQL.
    /// </summary>
    public abstract class DapperRepositoryBase
    {
        protected string ConnectionString { get; }

        protected DapperRepositoryBase(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            ConnectionString = connectionString;
        }

        /// <summary>
        /// Cria uma nova conexão com o banco de dados.
        /// </summary>
        protected NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
