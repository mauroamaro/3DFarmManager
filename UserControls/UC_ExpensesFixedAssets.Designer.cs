namespace _3DFarmManager.UserControls
{
    partial class UC_ExpensesFixedAssets
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
            this.panelExpensesFixedAssets = new System.Windows.Forms.Panel();
            this.panelGridView = new System.Windows.Forms.Panel();
            this.gDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gbtSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbtDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gbtEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gbtAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gtbDepreciation = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDepreciation = new System.Windows.Forms.Label();
            this.lbAssetName = new System.Windows.Forms.Label();
            this.gtbAssetValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbAssetValue = new System.Windows.Forms.Label();
            this.gtbAssetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotalDepreciation = new System.Windows.Forms.Label();
            this.gtbTotalDepreciation = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbUsefullLife = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbUsefullLife = new System.Windows.Forms.Label();
            this.panelRecInfo = new System.Windows.Forms.Panel();
            this.gchipRecLog = new Guna.UI2.WinForms.Guna2Chip();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gdtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.panelExpensesFixedAssets.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGrid)).BeginInit();
            this.panelRecInfo.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExpensesFixedAssets
            // 
            this.panelExpensesFixedAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panelExpensesFixedAssets.Controls.Add(this.panelData);
            this.panelExpensesFixedAssets.Controls.Add(this.panelActions);
            this.panelExpensesFixedAssets.Controls.Add(this.panelRecInfo);
            this.panelExpensesFixedAssets.Controls.Add(this.panelGridView);
            this.panelExpensesFixedAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExpensesFixedAssets.Location = new System.Drawing.Point(0, 0);
            this.panelExpensesFixedAssets.Name = "panelExpensesFixedAssets";
            this.panelExpensesFixedAssets.Size = new System.Drawing.Size(928, 697);
            this.panelExpensesFixedAssets.TabIndex = 0;
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.gDataGrid);
            this.panelGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridView.Location = new System.Drawing.Point(0, 0);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.Size = new System.Drawing.Size(928, 300);
            this.panelGridView.TabIndex = 29;
            // 
            // gDataGrid
            // 
            this.gDataGrid.AllowUserToAddRows = false;
            this.gDataGrid.AllowUserToDeleteRows = false;
            this.gDataGrid.AllowUserToOrderColumns = true;
            this.gDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.gDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGrid.EnableHeadersVisualStyles = false;
            this.gDataGrid.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGrid.Location = new System.Drawing.Point(0, 0);
            this.gDataGrid.MultiSelect = false;
            this.gDataGrid.Name = "gDataGrid";
            this.gDataGrid.ReadOnly = true;
            this.gDataGrid.RowHeadersVisible = false;
            this.gDataGrid.RowTemplate.Height = 26;
            this.gDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGrid.Size = new System.Drawing.Size(928, 300);
            this.gDataGrid.TabIndex = 22;
            this.gDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGrid.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.gDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.gDataGrid.ThemeStyle.ReadOnly = true;
            this.gDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.gDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGrid.ThemeStyle.RowsStyle.Height = 26;
            this.gDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.gbtCancel.Location = new System.Drawing.Point(528, 8);
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
            this.gbtSave.Location = new System.Drawing.Point(426, 8);
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
            this.gbtDelete.Location = new System.Drawing.Point(228, 8);
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
            this.gbtEdit.Location = new System.Drawing.Point(119, 8);
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
            this.gbtAdd.Location = new System.Drawing.Point(8, 8);
            this.gbtAdd.Name = "gbtAdd";
            this.gbtAdd.ShadowDecoration.Parent = this.gbtAdd;
            this.gbtAdd.Size = new System.Drawing.Size(96, 29);
            this.gbtAdd.TabIndex = 1;
            this.gbtAdd.Text = "Incluir";
            this.gbtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gtbDepreciation
            // 
            this.gtbDepreciation.BackColor = System.Drawing.Color.Transparent;
            this.gtbDepreciation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbDepreciation.BorderRadius = 5;
            this.gtbDepreciation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbDepreciation.DefaultText = "";
            this.gtbDepreciation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbDepreciation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbDepreciation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbDepreciation.DisabledState.Parent = this.gtbDepreciation;
            this.gtbDepreciation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbDepreciation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbDepreciation.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbDepreciation.FocusedState.Parent = this.gtbDepreciation;
            this.gtbDepreciation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbDepreciation.ForeColor = System.Drawing.Color.Tan;
            this.gtbDepreciation.HoverState.BorderColor = System.Drawing.Color.Tan;
            this.gtbDepreciation.HoverState.Parent = this.gtbDepreciation;
            this.gtbDepreciation.IconLeft = global::_3DFarmManager.Properties.Resources.icons8_calculadora_24;
            this.gtbDepreciation.IconLeftSize = new System.Drawing.Size(24, 24);
            this.gtbDepreciation.Location = new System.Drawing.Point(283, 112);
            this.gtbDepreciation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbDepreciation.Name = "gtbDepreciation";
            this.gtbDepreciation.PasswordChar = '\0';
            this.gtbDepreciation.PlaceholderText = "0,00";
            this.gtbDepreciation.SelectedText = "";
            this.gtbDepreciation.ShadowDecoration.Parent = this.gtbDepreciation;
            this.gtbDepreciation.Size = new System.Drawing.Size(166, 36);
            this.gtbDepreciation.TabIndex = 27;
            this.gtbDepreciation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbDescription
            // 
            this.gtbDescription.BackColor = System.Drawing.Color.Transparent;
            this.gtbDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbDescription.BorderRadius = 5;
            this.gtbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbDescription.DefaultText = "";
            this.gtbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbDescription.DisabledState.Parent = this.gtbDescription;
            this.gtbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbDescription.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbDescription.FocusedState.Parent = this.gtbDescription;
            this.gtbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbDescription.ForeColor = System.Drawing.Color.White;
            this.gtbDescription.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbDescription.HoverState.Parent = this.gtbDescription;
            this.gtbDescription.Location = new System.Drawing.Point(17, 182);
            this.gtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbDescription.Multiline = true;
            this.gtbDescription.Name = "gtbDescription";
            this.gtbDescription.PasswordChar = '\0';
            this.gtbDescription.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbDescription.PlaceholderText = "";
            this.gtbDescription.SelectedText = "";
            this.gtbDescription.ShadowDecoration.Parent = this.gtbDescription;
            this.gtbDescription.Size = new System.Drawing.Size(804, 130);
            this.gtbDescription.TabIndex = 22;
            // 
            // lbDepreciation
            // 
            this.lbDepreciation.AutoSize = true;
            this.lbDepreciation.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepreciation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbDepreciation.Location = new System.Drawing.Point(281, 94);
            this.lbDepreciation.Name = "lbDepreciation";
            this.lbDepreciation.Size = new System.Drawing.Size(120, 13);
            this.lbDepreciation.TabIndex = 26;
            this.lbDepreciation.Text = "Depreciação (R$/Mês)";
            // 
            // lbAssetName
            // 
            this.lbAssetName.AutoSize = true;
            this.lbAssetName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbAssetName.Location = new System.Drawing.Point(14, 29);
            this.lbAssetName.Name = "lbAssetName";
            this.lbAssetName.Size = new System.Drawing.Size(102, 13);
            this.lbAssetName.TabIndex = 20;
            this.lbAssetName.Text = "Item Imobilizado *";
            // 
            // gtbAssetValue
            // 
            this.gtbAssetValue.BackColor = System.Drawing.Color.Transparent;
            this.gtbAssetValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbAssetValue.BorderRadius = 5;
            this.gtbAssetValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbAssetValue.DefaultText = "";
            this.gtbAssetValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbAssetValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbAssetValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAssetValue.DisabledState.Parent = this.gtbAssetValue;
            this.gtbAssetValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAssetValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbAssetValue.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbAssetValue.FocusedState.Parent = this.gtbAssetValue;
            this.gtbAssetValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbAssetValue.ForeColor = System.Drawing.Color.White;
            this.gtbAssetValue.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbAssetValue.HoverState.Parent = this.gtbAssetValue;
            this.gtbAssetValue.Location = new System.Drawing.Point(465, 47);
            this.gtbAssetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbAssetValue.Name = "gtbAssetValue";
            this.gtbAssetValue.PasswordChar = '\0';
            this.gtbAssetValue.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbAssetValue.PlaceholderText = "0,00";
            this.gtbAssetValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gtbAssetValue.SelectedText = "";
            this.gtbAssetValue.ShadowDecoration.Parent = this.gtbAssetValue;
            this.gtbAssetValue.Size = new System.Drawing.Size(166, 36);
            this.gtbAssetValue.TabIndex = 25;
            this.gtbAssetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbDescription.Location = new System.Drawing.Point(14, 165);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(99, 13);
            this.lbDescription.TabIndex = 21;
            this.lbDescription.Text = "Descrição do item";
            // 
            // lbAssetValue
            // 
            this.lbAssetValue.AutoSize = true;
            this.lbAssetValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbAssetValue.Location = new System.Drawing.Point(462, 29);
            this.lbAssetValue.Name = "lbAssetValue";
            this.lbAssetValue.Size = new System.Drawing.Size(108, 13);
            this.lbAssetValue.TabIndex = 24;
            this.lbAssetValue.Text = "Valor do Item (R$) *";
            // 
            // gtbAssetName
            // 
            this.gtbAssetName.BackColor = System.Drawing.Color.Transparent;
            this.gtbAssetName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbAssetName.BorderRadius = 5;
            this.gtbAssetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbAssetName.DefaultText = "";
            this.gtbAssetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbAssetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbAssetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAssetName.DisabledState.Parent = this.gtbAssetName;
            this.gtbAssetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAssetName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbAssetName.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbAssetName.FocusedState.Parent = this.gtbAssetName;
            this.gtbAssetName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbAssetName.ForeColor = System.Drawing.Color.White;
            this.gtbAssetName.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbAssetName.HoverState.Parent = this.gtbAssetName;
            this.gtbAssetName.Location = new System.Drawing.Point(17, 47);
            this.gtbAssetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbAssetName.Name = "gtbAssetName";
            this.gtbAssetName.PasswordChar = '\0';
            this.gtbAssetName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbAssetName.PlaceholderText = "";
            this.gtbAssetName.SelectedText = "";
            this.gtbAssetName.ShadowDecoration.Parent = this.gtbAssetName;
            this.gtbAssetName.Size = new System.Drawing.Size(432, 36);
            this.gtbAssetName.TabIndex = 23;
            // 
            // lbTotalDepreciation
            // 
            this.lbTotalDepreciation.AutoSize = true;
            this.lbTotalDepreciation.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDepreciation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbTotalDepreciation.Location = new System.Drawing.Point(642, 94);
            this.lbTotalDepreciation.Name = "lbTotalDepreciation";
            this.lbTotalDepreciation.Size = new System.Drawing.Size(148, 13);
            this.lbTotalDepreciation.TabIndex = 26;
            this.lbTotalDepreciation.Text = "Depreciação Total (R$/Mês)";
            // 
            // gtbTotalDepreciation
            // 
            this.gtbTotalDepreciation.BackColor = System.Drawing.Color.Transparent;
            this.gtbTotalDepreciation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbTotalDepreciation.BorderRadius = 5;
            this.gtbTotalDepreciation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbTotalDepreciation.DefaultText = "";
            this.gtbTotalDepreciation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbTotalDepreciation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbTotalDepreciation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbTotalDepreciation.DisabledState.Parent = this.gtbTotalDepreciation;
            this.gtbTotalDepreciation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbTotalDepreciation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbTotalDepreciation.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbTotalDepreciation.FocusedState.Parent = this.gtbTotalDepreciation;
            this.gtbTotalDepreciation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbTotalDepreciation.ForeColor = System.Drawing.Color.Tan;
            this.gtbTotalDepreciation.HoverState.BorderColor = System.Drawing.Color.Tan;
            this.gtbTotalDepreciation.HoverState.Parent = this.gtbTotalDepreciation;
            this.gtbTotalDepreciation.IconLeft = global::_3DFarmManager.Properties.Resources.icons8_calculadora_24;
            this.gtbTotalDepreciation.IconLeftSize = new System.Drawing.Size(24, 24);
            this.gtbTotalDepreciation.Location = new System.Drawing.Point(645, 111);
            this.gtbTotalDepreciation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbTotalDepreciation.Name = "gtbTotalDepreciation";
            this.gtbTotalDepreciation.PasswordChar = '\0';
            this.gtbTotalDepreciation.PlaceholderText = "0,00";
            this.gtbTotalDepreciation.SelectedText = "";
            this.gtbTotalDepreciation.ShadowDecoration.Parent = this.gtbTotalDepreciation;
            this.gtbTotalDepreciation.Size = new System.Drawing.Size(176, 36);
            this.gtbTotalDepreciation.TabIndex = 27;
            this.gtbTotalDepreciation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbUsefullLife
            // 
            this.gtbUsefullLife.BackColor = System.Drawing.Color.Transparent;
            this.gtbUsefullLife.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbUsefullLife.BorderRadius = 5;
            this.gtbUsefullLife.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbUsefullLife.DefaultText = "";
            this.gtbUsefullLife.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbUsefullLife.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbUsefullLife.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUsefullLife.DisabledState.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUsefullLife.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbUsefullLife.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbUsefullLife.FocusedState.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbUsefullLife.ForeColor = System.Drawing.Color.White;
            this.gtbUsefullLife.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbUsefullLife.HoverState.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.Location = new System.Drawing.Point(17, 112);
            this.gtbUsefullLife.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbUsefullLife.Name = "gtbUsefullLife";
            this.gtbUsefullLife.PasswordChar = '\0';
            this.gtbUsefullLife.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbUsefullLife.PlaceholderText = "0";
            this.gtbUsefullLife.SelectedText = "";
            this.gtbUsefullLife.ShadowDecoration.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.Size = new System.Drawing.Size(165, 36);
            this.gtbUsefullLife.TabIndex = 29;
            this.gtbUsefullLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbUsefullLife
            // 
            this.lbUsefullLife.AutoSize = true;
            this.lbUsefullLife.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsefullLife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbUsefullLife.Location = new System.Drawing.Point(14, 94);
            this.lbUsefullLife.Name = "lbUsefullLife";
            this.lbUsefullLife.Size = new System.Drawing.Size(87, 13);
            this.lbUsefullLife.TabIndex = 28;
            this.lbUsefullLife.Text = "Vida Útil (Anos)";
            // 
            // panelRecInfo
            // 
            this.panelRecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelRecInfo.Controls.Add(this.gchipRecLog);
            this.panelRecInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecInfo.Location = new System.Drawing.Point(0, 300);
            this.panelRecInfo.Name = "panelRecInfo";
            this.panelRecInfo.Size = new System.Drawing.Size(928, 30);
            this.panelRecInfo.TabIndex = 31;
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
            this.gchipRecLog.Size = new System.Drawing.Size(928, 30);
            this.gchipRecLog.TabIndex = 20;
            this.gchipRecLog.Text = "Última Atualização do Registro: 99/99/9999 99:99:99 | Inclusão | Mauro de Jesus  " +
    "Amaro";
            this.gchipRecLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gchipRecLog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panelActions.Controls.Add(this.gbtCancel);
            this.panelActions.Controls.Add(this.gbtAdd);
            this.panelActions.Controls.Add(this.gbtDelete);
            this.panelActions.Controls.Add(this.gbtEdit);
            this.panelActions.Controls.Add(this.gbtSave);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 330);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(928, 45);
            this.panelActions.TabIndex = 34;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gdtStartDate);
            this.panelData.Controls.Add(this.lbStartDate);
            this.panelData.Controls.Add(this.gtbUsefullLife);
            this.panelData.Controls.Add(this.gtbAssetName);
            this.panelData.Controls.Add(this.gtbDescription);
            this.panelData.Controls.Add(this.lbDepreciation);
            this.panelData.Controls.Add(this.lbUsefullLife);
            this.panelData.Controls.Add(this.lbAssetName);
            this.panelData.Controls.Add(this.gtbAssetValue);
            this.panelData.Controls.Add(this.gtbTotalDepreciation);
            this.panelData.Controls.Add(this.lbTotalDepreciation);
            this.panelData.Controls.Add(this.lbAssetValue);
            this.panelData.Controls.Add(this.lbDescription);
            this.panelData.Controls.Add(this.gtbDepreciation);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 375);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(928, 322);
            this.panelData.TabIndex = 35;
            // 
            // gdtStartDate
            // 
            this.gdtStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gdtStartDate.BorderRadius = 5;
            this.gdtStartDate.BorderThickness = 1;
            this.gdtStartDate.CheckedState.Parent = this.gdtStartDate;
            this.gdtStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gdtStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtStartDate.ForeColor = System.Drawing.Color.White;
            this.gdtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gdtStartDate.HoverState.Parent = this.gdtStartDate;
            this.gdtStartDate.Location = new System.Drawing.Point(645, 47);
            this.gdtStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtStartDate.Name = "gdtStartDate";
            this.gdtStartDate.ShadowDecoration.Parent = this.gdtStartDate;
            this.gdtStartDate.Size = new System.Drawing.Size(176, 36);
            this.gdtStartDate.TabIndex = 31;
            this.gdtStartDate.Value = new System.DateTime(2026, 6, 14, 11, 23, 57, 112);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbStartDate.Location = new System.Drawing.Point(642, 29);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(91, 13);
            this.lbStartDate.TabIndex = 30;
            this.lbStartDate.Text = "Data da Compra";
            // 
            // UC_ExpensesFixedAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelExpensesFixedAssets);
            this.Name = "UC_ExpensesFixedAssets";
            this.Size = new System.Drawing.Size(928, 697);
            this.panelExpensesFixedAssets.ResumeLayout(false);
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGrid)).EndInit();
            this.panelRecInfo.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExpensesFixedAssets;
        private Guna.UI2.WinForms.Guna2Button gbtCancel;
        private Guna.UI2.WinForms.Guna2Button gbtSave;
        private Guna.UI2.WinForms.Guna2Button gbtDelete;
        private Guna.UI2.WinForms.Guna2Button gbtEdit;
        private Guna.UI2.WinForms.Guna2Button gbtAdd;
        private System.Windows.Forms.Panel panelGridView;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox gtbTotalDepreciation;
        private Guna.UI2.WinForms.Guna2TextBox gtbDepreciation;
        private System.Windows.Forms.Label lbTotalDepreciation;
        private Guna.UI2.WinForms.Guna2TextBox gtbDescription;
        private System.Windows.Forms.Label lbDepreciation;
        private System.Windows.Forms.Label lbAssetName;
        private Guna.UI2.WinForms.Guna2TextBox gtbAssetValue;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbAssetValue;
        private Guna.UI2.WinForms.Guna2TextBox gtbAssetName;
        private Guna.UI2.WinForms.Guna2TextBox gtbUsefullLife;
        private System.Windows.Forms.Label lbUsefullLife;
        private System.Windows.Forms.Panel panelRecInfo;
        private Guna.UI2.WinForms.Guna2Chip gchipRecLog;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelActions;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdtStartDate;
        private System.Windows.Forms.Label lbStartDate;
    }
}
