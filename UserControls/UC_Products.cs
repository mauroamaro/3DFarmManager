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
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();

            ConfigureProductsGrid();
            LoadControl(new UC_ProductData());

            //ConfigurePartsGrid();
            //ConfigureMaterialsGrid();
        }
        private void LoadControl(UserControl uc)
        {
            panelProductContainer.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelProductContainer.Controls.Add(uc);

            uc.BringToFront();
        }
        
        private void ConfigureProductsGrid()
        {

            //var dgv = sDataGridView.GridView;
            var dgv = gDataGridView;

            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersHeight = 45;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID #",
                DataPropertyName = "Id",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partname",
                HeaderText = "Nome",
                DataPropertyName = "Name",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partversion",
                HeaderText = "Versão",
                DataPropertyName = "PartVersion",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filamentqt",
                HeaderText = "Qt Filamento (g)",
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
                Name = "partweight",
                HeaderText = "Peso (g)",
                DataPropertyName = "PartWeight",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            //            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.ForeColor = Color.Tan;

            //            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.Alignment =
            //                    DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }
        /*
        private void ConfigurePartsGrid()
        {

            //var dgv = sDataGridView.GridView;
            var dgv = gDataGridViewParts;

            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

            /*
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID #",
                DataPropertyName = "Id",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partname",
                HeaderText = "Nome",
                DataPropertyName = "Name",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "partversion",
                HeaderText = "Versão",
                DataPropertyName = "PartVersion",
                Width = 100
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filamentqt",
                HeaderText = "Filamento (g)",
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
                Name = "partweight",
                HeaderText = "Peso (g)",
                DataPropertyName = "PartWeight",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

//            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.ForeColor = Color.Tan;

//            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.Alignment =
//                    DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }
        
        private void ConfigureMaterialsGrid()
        {

            //var dgv = sDataGridView.GridView;
            var dgv = gDataGridMaterial;

            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

            
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID #",
                DataPropertyName = "Id",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "name",
                HeaderText = "Nome",
                DataPropertyName = "Name",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "brandname",
                HeaderText = "Marca/Fabricante",
                DataPropertyName = "BrandName",
                Width = 130
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "color",
                HeaderText = "Cor",
                DataPropertyName = "Color",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                HeaderText = "UN",
                DataPropertyName = "Unit",
                Width = 70,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "materialqt",
                HeaderText = "Quantidade",
                DataPropertyName = "MaterialQt",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "materialcost",
                HeaderText = "Custo (R$)",
                DataPropertyName = "MaterialCost",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

//            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.ForeColor = Color.Tan;

//            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.Alignment =
//                    DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }
        */
        private void gbtAdd_Click(object sender, EventArgs e)
        {
            Control atual = this;

            // Sobe na hierarquia de controles até achar o UC_ProductsGroup ou acabar os pais
            while (atual != null && !(atual is UC_ProductsGroup))
            {
                atual = atual.Parent;
            }

            // Se encontrou, faz a conversão e executa o comando
            var userControlPai = atual as UC_ProductsGroup;
            if (userControlPai != null)
            {
                userControlPai.DisableInternalButton();
            }
        }

        private void gbtBasicDataView_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_ProductData());
        }

        private void gbtPartsView_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_ProductParts());
        }

        private void gbtMaterialsView_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_ProductMaterial());
        }

        private void gchipTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
