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
    public partial class UC_ProductsGroup : UserControl
    {
        public UC_ProductsGroup()
        {
            InitializeComponent();
            UC_Products uc = new UC_Products();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void DisableInternalButton()
        {
            this.gbtProducts.Enabled = false; // "botaoAlvo" continua private
            this.gbtParts.Enabled = false; // "botaoAlvo" continua private
        }

        private void gbtProducts_Click(object sender, EventArgs e)
        {
            UC_Products uc = new UC_Products();
            addUserControl(uc);
        }

        private void gbtParts_Click(object sender, EventArgs e)
        {
            UC_Parts uc = new UC_Parts();
            addUserControl(uc);
        }

        private void gbtFilaments_Click(object sender, EventArgs e)
        {
            UC_Filaments uc = new UC_Filaments();
            addUserControl(uc);
        }

        private void gbtMaterials_Click(object sender, EventArgs e)
        {
            UC_Materials uc = new UC_Materials();
            addUserControl(uc);
        }

        private void gbtPacking_Click(object sender, EventArgs e)
        {
            UC_Packing uc = new UC_Packing();
            addUserControl(uc);
        }
    }
}
