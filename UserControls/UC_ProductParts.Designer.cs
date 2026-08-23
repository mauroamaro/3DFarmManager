namespace _3DFarmManager.UserControls
{
    partial class UC_ProductParts
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
            this.panelProductParts = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gtbPrinterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.panelGridView = new System.Windows.Forms.Panel();
            this.gDataGridViewParts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.gbtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gbtSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbtDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gbtEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gbtAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panelProductParts.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridViewParts)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductParts
            // 
            this.panelProductParts.Controls.Add(this.panelData);
            this.panelProductParts.Controls.Add(this.panelGridView);
            this.panelProductParts.Controls.Add(this.panelActions);
            this.panelProductParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductParts.Location = new System.Drawing.Point(0, 0);
            this.panelProductParts.Name = "panelProductParts";
            this.panelProductParts.Size = new System.Drawing.Size(911, 405);
            this.panelProductParts.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gtbPrinterName);
            this.panelData.Controls.Add(this.lbPrinterName);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(120, 262);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(791, 143);
            this.panelData.TabIndex = 27;
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
            this.gtbPrinterName.Location = new System.Drawing.Point(17, 41);
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
            this.lbPrinterName.Location = new System.Drawing.Point(14, 23);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(46, 13);
            this.lbPrinterName.TabIndex = 9;
            this.lbPrinterName.Text = "Nome *";
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.gDataGridViewParts);
            this.panelGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridView.Location = new System.Drawing.Point(120, 0);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.Size = new System.Drawing.Size(791, 262);
            this.panelGridView.TabIndex = 26;
            // 
            // gDataGridViewParts
            // 
            this.gDataGridViewParts.AllowUserToAddRows = false;
            this.gDataGridViewParts.AllowUserToDeleteRows = false;
            this.gDataGridViewParts.AllowUserToOrderColumns = true;
            this.gDataGridViewParts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.gDataGridViewParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridViewParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridViewParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridViewParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridViewParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDataGridViewParts.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridViewParts.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDataGridViewParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridViewParts.EnableHeadersVisualStyles = false;
            this.gDataGridViewParts.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridViewParts.Location = new System.Drawing.Point(0, 0);
            this.gDataGridViewParts.MultiSelect = false;
            this.gDataGridViewParts.Name = "gDataGridViewParts";
            this.gDataGridViewParts.ReadOnly = true;
            this.gDataGridViewParts.RowHeadersVisible = false;
            this.gDataGridViewParts.RowTemplate.Height = 26;
            this.gDataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridViewParts.Size = new System.Drawing.Size(791, 262);
            this.gDataGridViewParts.TabIndex = 22;
            this.gDataGridViewParts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gDataGridViewParts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridViewParts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGridViewParts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridViewParts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGridViewParts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGridViewParts.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridViewParts.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGridViewParts.ThemeStyle.HeaderStyle.Height = 45;
            this.gDataGridViewParts.ThemeStyle.ReadOnly = true;
            this.gDataGridViewParts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.gDataGridViewParts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridViewParts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridViewParts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridViewParts.ThemeStyle.RowsStyle.Height = 26;
            this.gDataGridViewParts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gDataGridViewParts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.panelActions.Size = new System.Drawing.Size(120, 405);
            this.panelActions.TabIndex = 24;
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
            // UC_ProductParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panelProductParts);
            this.Name = "UC_ProductParts";
            this.Size = new System.Drawing.Size(911, 405);
            this.panelProductParts.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridViewParts)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductParts;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGridViewParts;
        private System.Windows.Forms.Panel panelActions;
        private Guna.UI2.WinForms.Guna2Button gbtSave;
        private Guna.UI2.WinForms.Guna2Button gbtDelete;
        private Guna.UI2.WinForms.Guna2Button gbtEdit;
        private Guna.UI2.WinForms.Guna2Button gbtAdd;
        private Guna.UI2.WinForms.Guna2Button gbtCancel;
        private Guna.UI2.WinForms.Guna2TextBox gtbPrinterName;
        private System.Windows.Forms.Label lbPrinterName;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelGridView;
    }
}
