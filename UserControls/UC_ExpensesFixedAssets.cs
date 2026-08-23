using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager.UserControls
{
    public partial class UC_ExpensesFixedAssets : UserControl
    {
        public UC_ExpensesFixedAssets()
        {
            InitializeComponent();

            ConfigureExpensesAssetsGrid();
        }

        private void ConfigureExpensesAssetsGrid()
        {
            var dgv = gDataGrid;

            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Set the column header border style to single
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersHeight = 45;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "assetname",
                HeaderText = "Item Imobilizado",
                DataPropertyName = "AssetName",
                Width = 400
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "assetvalue",
                HeaderText = "Valor do Item (R$)",
                DataPropertyName = "AssetValue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "dtstart",
                HeaderText = "Data de Início",
                DataPropertyName = "StartDate",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "usefulllife",
                HeaderText = "Vida Útil (Anos)",
                DataPropertyName = "UsefullLife",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "depreciationvalue",
                HeaderText = "Depreciação (R$/h)",
                DataPropertyName = "DepreciationValue",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

        }

    }
}
