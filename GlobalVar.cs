using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager
{
    public static class GlobalVar
    {
        // parameterless constructor required for static class
        static GlobalVar()
        {
            /*
            string AppConnString = "";
            string AppUser = "";
            string AppPerfilUser = "";
            int AppUserID = 0;
            int AppPerfilUserID = 0;
            string AssinaturaEmail = "";
            long IDCategProdTxtEmail = 0;
            long IDVoucherTemp = 0;
            int parLimiteMinDesc = 0;
            int parLimiteMaxDesc = 0;
            int parQtMaxLote = 0;
            */

        } // default value

        public static string AppConnString { get; private set; }
        public static void SetAppConnString(string newAppConnString)
        {
            AppConnString = newAppConnString;
        }

        public static string AppUser { get; private set; }
        public static void SetAppUser(string newAppUser)
        {
            AppUser = newAppUser;
        }
        public static string AppPerfilUser { get; private set; }
        public static void SetAppPerfilUser(string newAppPerfilUser)
        {
            AppPerfilUser = newAppPerfilUser;
        }

        public static int AppUserID { get; private set; }
        public static void SetAppUserID(int newAppUserID)
        {
            AppUserID = newAppUserID;
        }

        public static int AppPerfilUserID { get; private set; }
        public static void SetAppPerfilUserID(int newAppPerfilUserID)
        {
            AppPerfilUserID = newAppPerfilUserID;
        }
        public static string ParAssinaturaEmail { get; private set; }
        public static void SetParAssinaturaEmail(string newParAssinaturaEmail)
        {
            ParAssinaturaEmail = newParAssinaturaEmail;
        }
        public static string ParTituloEmailVoucher { get; private set; }
        public static void SetParTituloEmailVoucher(string newParTituloEmailVoucher)
        {
            ParTituloEmailVoucher = newParTituloEmailVoucher;
        }
        public static string ParEmailPadraoVoucher { get; private set; }
        public static void SetParEmailPadraoVoucher(string newParEmailPadraoVoucher)
        {
            ParEmailPadraoVoucher = newParEmailPadraoVoucher;
        }

        public static int ParDiasValidadeVoucher { get; private set; }
        public static void SetParDiasValidadeVoucher(int newParDiasValidadeVoucher)
        {
            ParDiasValidadeVoucher = newParDiasValidadeVoucher;
        }

        public static int ParLimiteMinDescVoucher { get; private set; }
        public static void SetParLimiteMinDescVoucher(int newParLimiteMinDescVoucher)
        {
            ParLimiteMinDescVoucher = newParLimiteMinDescVoucher;
        }

        public static int ParLimiteMaxDescVoucher { get; private set; }
        public static void SetParLimiteMaxDescVoucher(int newParLimiteMaxDescVoucher)
        {
            ParLimiteMaxDescVoucher = newParLimiteMaxDescVoucher;
        }

        public static int ParQtMaxLoteVoucher { get; private set; }
        public static void SetParQtMaxLoteVoucher(int newParQtMaxLoteVoucher)
        {
            ParQtMaxLoteVoucher = newParQtMaxLoteVoucher;
        }

        public static long IDCategProdTxtEmail { get; private set; }
        public static void SetIDCategProdTxtEmail(long newIDCategProdTxtEmail)
        {
            IDCategProdTxtEmail = newIDCategProdTxtEmail;
        }
        public static long IDVoucherTemp { get; private set; }
        public static void SetIDVoucherTemp(long newIDVoucherTemp)
        {
            IDVoucherTemp = newIDVoucherTemp;
        }

    }
}
