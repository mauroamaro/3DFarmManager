using _3DFarmManager.UserControls;
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
    public partial class UC_Expenses : UserControl
    {
        public UC_Expenses()
        {
            InitializeComponent();
            UC_ExpensesFixed uc = new UC_ExpensesFixed();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gbtFixedExpenses_Click(object sender, EventArgs e)
        {
            UC_ExpensesFixed uc = new UC_ExpensesFixed();
            addUserControl(uc);
        }

        private void gbtFixedAssets_Click(object sender, EventArgs e)
        {
            UC_ExpensesFixedAssets uc = new UC_ExpensesFixedAssets();
            addUserControl(uc);
        }

        private void gbtRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
