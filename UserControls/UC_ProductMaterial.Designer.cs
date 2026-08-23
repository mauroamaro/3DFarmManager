namespace _3DFarmManager.UserControls
{
    partial class UC_ProductMaterial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelProductMaterial = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gtbPrinterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.panelGridView = new System.Windows.Forms.Panel();
            this.gDataGridMaterial = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.gbtSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbtDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gbtEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gbtAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gbtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelProductMaterial.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridMaterial)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductMaterial
            // 
            this.panelProductMaterial.Controls.Add(this.panelData);
            this.panelProductMaterial.Controls.Add(this.panelGridView);
            this.panelProductMaterial.Controls.Add(this.panelActions);
            this.panelProductMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductMaterial.Location = new System.Drawing.Point(0, 0);
            this.panelProductMaterial.Name = "panelProductMaterial";
            this.panelProductMaterial.Size = new System.Drawing.Size(764, 426);
            this.panelProductMaterial.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gtbPrinterName);
            this.panelData.Controls.Add(this.lbPrinterName);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(120, 240);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(644, 186);
            this.panelData.TabIndex = 28;
            // 
            // gtbPrinterName
            // 
            this.gtbPrinterName.BackColor = System.Drawing.Color.Transparent;
            this.gtbPrinterName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbPrinterName.BorderRadius = 5;
            this.gtbPrinterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPrinterName.DefaultText = "";
            this.gtbPrinterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbPrinterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbPrinterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPrinterName.DisabledState.Parent = this.gtbPrinterName;
            this.gtbPrinterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPrinterName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbPrinterName.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbPrinterName.FocusedState.Parent = this.gtbPrinterName;
            this.gtbPrinterName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbPrinterName.ForeColor = System.Drawing.Color.White;
            this.gtbPrinterName.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbPrinterName.HoverState.Parent = this.gtbPrinterName;
            this.gtbPrinterName.Location = new System.Drawing.Point(19, 33);
            this.gtbPrinterName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbPrinterName.Name = "gtbPrinterName";
            this.gtbPrinterName.PasswordChar = '\0';
            this.gtbPrinterName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbPrinterName.PlaceholderText = "";
            this.gtbPrinterName.SelectedText = "";
            this.gtbPrinterName.ShadowDecoration.Parent = this.gtbPrinterName;
            this.gtbPrinterName.Size = new System.Drawing.Size(343, 36);
            this.gtbPrinterName.TabIndex = 10;
            // 
            // lbPrinterName
            // 
            this.lbPrinterName.AutoSize = true;
            this.lbPrinterName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbPrinterName.Location = new System.Drawing.Point(16, 15);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(46, 13);
            this.lbPrinterName.TabIndex = 9;
            this.lbPrinterName.Text = "Nome *";
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.gDataGridMaterial);
            this.panelGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridView.Location = new System.Drawing.Point(120, 0);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.Size = new System.Drawing.Size(644, 240);
            this.panelGridView.TabIndex = 27;
            // 
            // gDataGridMaterial
            // 
            this.gDataGridMaterial.AllowUserToAddRows = false;
            this.gDataGridMaterial.AllowUserToDeleteRows = false;
            this.gDataGridMaterial.AllowUserToOrderColumns = true;
            this.gDataGridMaterial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.gDataGridMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDataGridMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDataGridMaterial.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridMaterial.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDataGridMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridMaterial.EnableHeadersVisualStyles = false;
            this.gDataGridMaterial.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridMaterial.Location = new System.Drawing.Point(0, 0);
            this.gDataGridMaterial.MultiSelect = false;
            this.gDataGridMaterial.Name = "gDataGridMaterial";
            this.gDataGridMaterial.ReadOnly = true;
            this.gDataGridMaterial.RowHeadersVisible = false;
            this.gDataGridMaterial.RowTemplate.Height = 26;
            this.gDataGridMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridMaterial.Size = new System.Drawing.Size(644, 240);
            this.gDataGridMaterial.TabIndex = 22;
            this.gDataGridMaterial.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gDataGridMaterial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridMaterial.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGridMaterial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridMaterial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGridMaterial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGridMaterial.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridMaterial.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGridMaterial.ThemeStyle.HeaderStyle.Height = 45;
            this.gDataGridMaterial.ThemeStyle.ReadOnly = true;
            this.gDataGridMaterial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.gDataGridMaterial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridMaterial.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridMaterial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridMaterial.ThemeStyle.RowsStyle.Height = 26;
            this.gDataGridMaterial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gDataGridMaterial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panelActions.Controls.Add(this.gbtCancel);
            this.panelActions.Controls.Add(this.gbtSave);
            this.panelActions.Controls.Add(this.gbtDelete);
            this.panelActions.Controls.Add(this.gbtEdit);
            this.panelActions.Controls.Add(this.gbtAdd);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(120, 426);
            this.panelActions.TabIndex = 25;
            // 
            // gbtSave
            // 
            this.gbtSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gbtSave.BorderRadius = 6;
            this.gbtSave.BorderThickness = 1;
            this.gbtSave.CheckedState.Parent = this.gbtSave;
            this.gbtSave.CustomImages.Parent = this.gbtSave;
            this.gbtSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.gbtSave.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gbtSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtSave.HoverState.Parent = this.gbtSave;
            this.gbtSave.Image = global::_3DFarmManager.Properties.Resources.Save;
            this.gbtSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtSave.Location = new System.Drawing.Point(11, 167);
            this.gbtSave.Name = "gbtSave";
            this.gbtSave.ShadowDecoration.Parent = this.gbtSave;
            this.gbtSave.Size = new System.Drawing.Size(96, 29);
            this.gbtSave.TabIndex = 4;
            this.gbtSave.Text = "Salvar";
            this.gbtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gbtDelete
            // 
            this.gbtDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gbtDelete.BorderRadius = 6;
            this.gbtDelete.BorderThickness = 1;
            this.gbtDelete.CheckedState.Parent = this.gbtDelete;
            this.gbtDelete.CustomImages.Parent = this.gbtDelete;
            this.gbtDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.gbtDelete.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gbtDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtDelete.HoverState.Parent = this.gbtDelete;
            this.gbtDelete.Image = global::_3DFarmManager.Properties.Resources.Trash;
            this.gbtDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtDelete.Location = new System.Drawing.Point(11, 91);
            this.gbtDelete.Name = "gbtDelete";
            this.gbtDelete.ShadowDecoration.Parent = this.gbtDelete;
            this.gbtDelete.Size = new System.Drawing.Size(96, 29);
            this.gbtDelete.TabIndex = 3;
            this.gbtDelete.Text = "Excluir";
            this.gbtDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gbtEdit
            // 
            this.gbtEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gbtEdit.BorderRadius = 6;
            this.gbtEdit.BorderThickness = 1;
            this.gbtEdit.CheckedState.Parent = this.gbtEdit;
            this.gbtEdit.CustomImages.Parent = this.gbtEdit;
            this.gbtEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.gbtEdit.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gbtEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtEdit.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtEdit.HoverState.Parent = this.gbtEdit;
            this.gbtEdit.Image = global::_3DFarmManager.Properties.Resources.Edit_Pencil;
            this.gbtEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtEdit.Location = new System.Drawing.Point(11, 53);
            this.gbtEdit.Name = "gbtEdit";
            this.gbtEdit.ShadowDecoration.Parent = this.gbtEdit;
            this.gbtEdit.Size = new System.Drawing.Size(96, 29);
            this.gbtEdit.TabIndex = 2;
            this.gbtEdit.Text = "Editar";
            this.gbtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gbtAdd
            // 
            this.gbtAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gbtAdd.BorderRadius = 6;
            this.gbtAdd.BorderThickness = 1;
            this.gbtAdd.CheckedState.Parent = this.gbtAdd;
            this.gbtAdd.CustomImages.Parent = this.gbtAdd;
            this.gbtAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.gbtAdd.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gbtAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtAdd.HoverState.Parent = this.gbtAdd;
            this.gbtAdd.Image = global::_3DFarmManager.Properties.Resources.Plus1;
            this.gbtAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtAdd.Location = new System.Drawing.Point(11, 15);
            this.gbtAdd.Name = "gbtAdd";
            this.gbtAdd.ShadowDecoration.Parent = this.gbtAdd;
            this.gbtAdd.Size = new System.Drawing.Size(96, 29);
            this.gbtAdd.TabIndex = 1;
            this.gbtAdd.Text = "Incluir";
            this.gbtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gbtCancel
            // 
            this.gbtCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gbtCancel.BorderRadius = 6;
            this.gbtCancel.BorderThickness = 1;
            this.gbtCancel.CheckedState.Parent = this.gbtCancel;
            this.gbtCancel.CustomImages.Parent = this.gbtCancel;
            this.gbtCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.gbtCancel.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gbtCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtCancel.HoverState.Parent = this.gbtCancel;
            this.gbtCancel.Image = global::_3DFarmManager.Properties.Resources.Cancel;
            this.gbtCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtCancel.Location = new System.Drawing.Point(11, 205);
            this.gbtCancel.Name = "gbtCancel";
            this.gbtCancel.ShadowDecoration.Parent = this.gbtCancel;
            this.gbtCancel.Size = new System.Drawing.Size(96, 29);
            this.gbtCancel.TabIndex = 5;
            this.gbtCancel.Text = "Cancelar";
            this.gbtCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UC_ProductMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panelProductMaterial);
            this.Name = "UC_ProductMaterial";
            this.Size = new System.Drawing.Size(764, 426);
            this.panelProductMaterial.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridMaterial)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductMaterial;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGridMaterial;
        private System.Windows.Forms.Panel panelActions;
        private Guna.UI2.WinForms.Guna2Button gbtSave;
        private Guna.UI2.WinForms.Guna2Button gbtDelete;
        private Guna.UI2.WinForms.Guna2Button gbtEdit;
        private Guna.UI2.WinForms.Guna2Button gbtAdd;
        private Guna.UI2.WinForms.Guna2TextBox gtbPrinterName;
        private System.Windows.Forms.Label lbPrinterName;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelGridView;
        private Guna.UI2.WinForms.Guna2Button gbtCancel;
    }
}
