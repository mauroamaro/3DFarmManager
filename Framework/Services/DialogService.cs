using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager.Framework.Services
{
    public static class DialogService
    {
        public static void Error(string message)
        {
            using (MsgBox msg = new MsgBox(message,"danger","Ok"))
            {
                msg.ShowDialog();
            }
        }

        public static void Warning(string message)
        {
            using (MsgBox msg = new MsgBox(message,"warning","Ok"))
            {
                msg.ShowDialog();
            }
        }

        public static void Information(string message)
        {
            using (MsgBox msg = new MsgBox(message,"info","Ok"))
            {
                msg.ShowDialog();
            }
        }

        public static bool Confirm(string message)
        {
            using (MsgBox msg = new MsgBox(message,"warning","YesNo"))
            {
                return msg.ShowDialog() == DialogResult.Yes;
            }
        }
    }
}
