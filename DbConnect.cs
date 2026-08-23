using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;
using System.Windows.Forms; 

namespace _3DFarmManager
{
    public class DbConnect
    {

        // vamos nos conectar ao POSTGRESQL e à base de dados
        // locadora usando Windows Authentication
        private static string connString = "";

        // representa a conexão com o banco
        private static NpgsqlConnection conn = null;

        //public static object ConfigurationManager { get; private set; }

        // método que permite obter a conexão
        public static NpgsqlConnection OpenConnection()
        {

            if (!Properties.Settings.Default.app_dev)
            {
                connString = System.Configuration.ConfigurationManager.ConnectionStrings["db_3dfmPRD"].ConnectionString;
            }
            else
            {
                connString = System.Configuration.ConfigurationManager.ConnectionStrings["db_3dfmDVL"].ConnectionString;
            }

            // vamos criar a conexão
            conn = new NpgsqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (NpgsqlException sqle)
            {
                conn = null;
                MessageBox.Show(sqle.Message);
            }

            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
