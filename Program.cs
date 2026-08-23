using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Properties.Settings.Default.app_dev)
            {
                GlobalVar.SetAppConnString(System.Configuration.ConfigurationManager.ConnectionStrings["db_3dfmPRD"].ConnectionString);
            }
            else
            {
                GlobalVar.SetAppConnString(System.Configuration.ConfigurationManager.ConnectionStrings["db_3dfmDVL"].ConnectionString);
            }

            Application.Run(new formMain());
        }
    }
}
