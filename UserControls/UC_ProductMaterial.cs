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
    public partial class UC_ProductMaterial : UserControl
    {
        public UC_ProductMaterial()
        {
            InitializeComponent();
            
            ConfigureMaterialGrid();
        }

        private void ConfigureMaterialGrid()
        {
            var dgv = gDataGridMaterial;

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
                Name = "materialname",
                HeaderText = "Nome",
                DataPropertyName = "MaterialName",
                Width = 300
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "brandname",
                HeaderText = "Marca/Fabricante",
                DataPropertyName = "BrandName",
                Width = 180
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "color",
                HeaderText = "Cor",
                DataPropertyName = "Color",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                HeaderText = "UN",
                DataPropertyName = "Unit",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "materialqt",
                HeaderText = "Qt.",
                DataPropertyName = "MaterialQt",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "materialcost",
                HeaderText = "Custo (R$)",
                DataPropertyName = "MaterialCost",
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
