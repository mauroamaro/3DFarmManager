using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public partial class MsgBoxValidator : Form
    {
        public MsgBoxValidator(List<string> errors)
        {
            InitializeComponent();

            if (errors == null || errors.Count == 0)
            {
                lboxErrors.Items.Add("Nenhum erro encontrado.");
            }
            else
            {
                foreach (var error in errors)
                {
                    lboxErrors.Items.Add(error);
                }
            }
        }

        private void lboxErrors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
