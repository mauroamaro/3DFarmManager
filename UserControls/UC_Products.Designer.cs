namespace _3DFarmManager.UserControls
{
    partial class UC_Products
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.gDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelRecInfo = new System.Windows.Forms.Panel();
            this.gchipRecLog = new Guna.UI2.WinForms.Guna2Chip();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelProductContainer = new System.Windows.Forms.Panel();
            this.panelMenuProduct = new System.Windows.Forms.Panel();
            this.gbtMaterialsView = new Guna.UI2.WinForms.Guna2Button();
            this.gbtPartsView = new Guna.UI2.WinForms.Guna2Button();
            this.gbtBasicDataView = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).BeginInit();
            this.panelRecInfo.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelMenuProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDataGrid.Controls.Add(this.gDataGridView);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1372, 280);
            this.panelDataGrid.TabIndex = 5;
            // 
            // gDataGridView
            // 
            this.gDataGridView.AllowUserToAddRows = false;
            this.gDataGridView.AllowUserToDeleteRows = false;
            this.gDataGridView.AllowUserToOrderColumns = true;
            this.gDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.gDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridView.EnableHeadersVisualStyles = false;
            this.gDataGridView.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gDataGridView.MultiSelect = false;
            this.gDataGridView.Name = "gDataGridView";
            this.gDataGridView.ReadOnly = true;
            this.gDataGridView.RowHeadersVisible = false;
            this.gDataGridView.RowTemplate.Height = 26;
            this.gDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridView.Size = new System.Drawing.Size(1372, 280);
            this.gDataGridView.TabIndex = 3;
            this.gDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridView.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.gDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.gDataGridView.ThemeStyle.ReadOnly = true;
            this.gDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.gDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.ThemeStyle.RowsStyle.Height = 26;
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panelRecInfo
            // 
            this.panelRecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelRecInfo.Controls.Add(this.gchipRecLog);
            this.panelRecInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecInfo.Location = new System.Drawing.Point(0, 280);
            this.panelRecInfo.Name = "panelRecInfo";
            this.panelRecInfo.Size = new System.Drawing.Size(1372, 30);
            this.panelRecInfo.TabIndex = 6;
            // 
            // gchipRecLog
            // 
            this.gchipRecLog.BorderRadius = 6;
            this.gchipRecLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchipRecLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gchipRecLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gchipRecLog.ForeColor = System.Drawing.Color.Silver;
            this.gchipRecLog.Location = new System.Drawing.Point(0, 0);
            this.gchipRecLog.Name = "gchipRecLog";
            this.gchipRecLog.ShadowDecoration.Parent = this.gchipRecLog;
            this.gchipRecLog.Size = new System.Drawing.Size(1372, 30);
            this.gchipRecLog.TabIndex = 18;
            this.gchipRecLog.Text = "Última Atualização do Registro: 99/99/9999 99:99:99 | Inclusão | Mauro de Jesus  " +
    "Amaro";
            this.gchipRecLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gchipRecLog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panelData.Controls.Add(this.panelProductContainer);
            this.panelData.Controls.Add(this.panelMenuProduct);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 310);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1372, 409);
            this.panelData.TabIndex = 8;
            // 
            // panelProductContainer
            // 
            this.panelProductContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductContainer.Location = new System.Drawing.Point(0, 44);
            this.panelProductContainer.Name = "panelProductContainer";
            this.panelProductContainer.Size = new System.Drawing.Size(1372, 365);
            this.panelProductContainer.TabIndex = 1;
            // 
            // panelMenuProduct
            // 
            this.panelMenuProduct.Controls.Add(this.panel1);
            this.panelMenuProduct.Controls.Add(this.gbtMaterialsView);
            this.panelMenuProduct.Controls.Add(this.gbtPartsView);
            this.panelMenuProduct.Controls.Add(this.gbtBasicDataView);
            this.panelMenuProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProduct.Location = new System.Drawing.Point(0, 0);
            this.panelMenuProduct.Name = "panelMenuProduct";
            this.panelMenuProduct.Size = new System.Drawing.Size(1372, 44);
            this.panelMenuProduct.TabIndex = 0;
            // 
            // gbtMaterialsView
            // 
            this.gbtMaterialsView.BorderRadius = 6;
            this.gbtMaterialsView.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtMaterialsView.CheckedState.Parent = this.gbtMaterialsView;
            this.gbtMaterialsView.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtMaterialsView.CustomImages.Parent = this.gbtMaterialsView;
            this.gbtMaterialsView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(145)))));
            this.gbtMaterialsView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtMaterialsView.ForeColor = System.Drawing.Color.White;
            this.gbtMaterialsView.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtMaterialsView.HoverState.Parent = this.gbtMaterialsView;
            this.gbtMaterialsView.Image = global::_3DFarmManager.Properties.Resources.icons8_insumo_24;
            this.gbtMaterialsView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtMaterialsView.Location = new System.Drawing.Point(381, 6);
            this.gbtMaterialsView.Name = "gbtMaterialsView";
            this.gbtMaterialsView.ShadowDecoration.Parent = this.gbtMaterialsView;
            this.gbtMaterialsView.Size = new System.Drawing.Size(119, 33);
            this.gbtMaterialsView.TabIndex = 0;
            this.gbtMaterialsView.Text = "Insumos";
            this.gbtMaterialsView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtMaterialsView.Click += new System.EventHandler(this.gbtMaterialsView_Click);
            // 
            // gbtPartsView
            // 
            this.gbtPartsView.BorderRadius = 6;
            this.gbtPartsView.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtPartsView.CheckedState.Parent = this.gbtPartsView;
            this.gbtPartsView.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtPartsView.CustomImages.Parent = this.gbtPartsView;
            this.gbtPartsView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(145)))));
            this.gbtPartsView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtPartsView.ForeColor = System.Drawing.Color.White;
            this.gbtPartsView.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtPartsView.HoverState.Parent = this.gbtPartsView;
            this.gbtPartsView.Image = global::_3DFarmManager.Properties.Resources.icons8_peça_24;
            this.gbtPartsView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtPartsView.Location = new System.Drawing.Point(256, 6);
            this.gbtPartsView.Name = "gbtPartsView";
            this.gbtPartsView.ShadowDecoration.Parent = this.gbtPartsView;
            this.gbtPartsView.Size = new System.Drawing.Size(119, 33);
            this.gbtPartsView.TabIndex = 0;
            this.gbtPartsView.Text = "Peças";
            this.gbtPartsView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtPartsView.Click += new System.EventHandler(this.gbtPartsView_Click);
            // 
            // gbtBasicDataView
            // 
            this.gbtBasicDataView.BorderRadius = 6;
            this.gbtBasicDataView.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtBasicDataView.Checked = true;
            this.gbtBasicDataView.CheckedState.Parent = this.gbtBasicDataView;
            this.gbtBasicDataView.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtBasicDataView.CustomImages.Parent = this.gbtBasicDataView;
            this.gbtBasicDataView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(145)))));
            this.gbtBasicDataView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtBasicDataView.ForeColor = System.Drawing.Color.White;
            this.gbtBasicDataView.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtBasicDataView.HoverState.Parent = this.gbtBasicDataView;
            this.gbtBasicDataView.Image = global::_3DFarmManager.Properties.Resources.icons8_data_management_24;
            this.gbtBasicDataView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtBasicDataView.Location = new System.Drawing.Point(131, 5);
            this.gbtBasicDataView.Name = "gbtBasicDataView";
            this.gbtBasicDataView.ShadowDecoration.Parent = this.gbtBasicDataView;
            this.gbtBasicDataView.Size = new System.Drawing.Size(119, 33);
            this.gbtBasicDataView.TabIndex = 0;
            this.gbtBasicDataView.Text = "Dados Básicos";
            this.gbtBasicDataView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtBasicDataView.Click += new System.EventHandler(this.gbtBasicDataView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 44);
            this.panel1.TabIndex = 1;
            // 
            // UC_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelRecInfo);
            this.Controls.Add(this.panelDataGrid);
            this.Name = "UC_Products";
            this.Size = new System.Drawing.Size(1372, 719);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).EndInit();
            this.panelRecInfo.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelMenuProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGrid;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGridView;
        private System.Windows.Forms.Panel panelRecInfo;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelProductContainer;
        private System.Windows.Forms.Panel panelMenuProduct;
        private Guna.UI2.WinForms.Guna2Button gbtBasicDataView;
        private Guna.UI2.WinForms.Guna2Button gbtMaterialsView;
        private Guna.UI2.WinForms.Guna2Button gbtPartsView;
        private Guna.UI2.WinForms.Guna2Chip gchipRecLog;
        private System.Windows.Forms.Panel panel1;
    }
}
