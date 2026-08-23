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
    public partial class UC_ProductParts : UserControl
    {
        public UC_ProductParts()
        {
            InitializeComponent();

            ConfigurePartsGrid();
        }

        private void ConfigurePartsGrid()
        {
            var dgv = gDataGridViewParts;

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
                Name = "partname",
                HeaderText = "Nome",
                DataPropertyName = "PartName",
                Width = 300
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partversion",
                HeaderText = "Versão",
                DataPropertyName = "PartVersion",
                Width = 180
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filament",
                HeaderText = "Filamento",
                DataPropertyName = "Filament",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filamentqt",
                HeaderText = "Qt.Filamento (g)",
                DataPropertyName = "FilamentQt",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "productiontime",
                HeaderText = "Tempo de Máquina (hh:mm:ss)",
                DataPropertyName = "ProductionTime",
                Width = 150
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partqt",
                HeaderText = "Qt. Peças",
                DataPropertyName = "PartQt",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }
    }

 }
