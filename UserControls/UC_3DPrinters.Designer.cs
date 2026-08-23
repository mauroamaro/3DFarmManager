namespace _3DFarmManager
{
    partial class UC_3DPrinters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitleAndGrid = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.gDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelRecInfo = new System.Windows.Forms.Panel();
            this.gchipRecLog = new Guna.UI2.WinForms.Guna2Chip();
            this.gchipTitle = new Guna.UI2.WinForms.Guna2Chip();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictUCTitle = new System.Windows.Forms.PictureBox();
            this.glbUCTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gtbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gcbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gcbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gtbMaintenanceCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbUsefullLife = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbPurchaseCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbAnnualCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbDepreciation = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbElectricityConsumption = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbPurchaseDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbPrinterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gdtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gdtPurchase = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDepreciation = new System.Windows.Forms.Label();
            this.lbElectricityConsumption = new System.Windows.Forms.Label();
            this.lbAnnualCost = new System.Windows.Forms.Label();
            this.lbMaintenanceCost = new System.Windows.Forms.Label();
            this.lbPurchaseCost = new System.Windows.Forms.Label();
            this.lbUsefullLife = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbPurchase = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.gHtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.gActionBtDelete = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtEdit = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtRefresh = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtCancel = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtSave = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtAdd = new _3DFarmManager.Framework.Controls.GActionButton();
            this.panelTitleAndGrid.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).BeginInit();
            this.panelRecInfo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUCTitle)).BeginInit();
            this.panelActions.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleAndGrid
            // 
            this.panelTitleAndGrid.Controls.Add(this.panelDataGrid);
            this.panelTitleAndGrid.Controls.Add(this.panelRecInfo);
            this.panelTitleAndGrid.Controls.Add(this.panelTitle);
            this.panelTitleAndGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleAndGrid.Location = new System.Drawing.Point(0, 0);
            this.panelTitleAndGrid.Name = "panelTitleAndGrid";
            this.panelTitleAndGrid.Size = new System.Drawing.Size(1166, 410);
            this.panelTitleAndGrid.TabIndex = 3;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDataGrid.Controls.Add(this.gDataGridView);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 50);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1166, 330);
            this.panelDataGrid.TabIndex = 4;
            // 
            // gDataGridView
            // 
            this.gDataGridView.AllowUserToAddRows = false;
            this.gDataGridView.AllowUserToDeleteRows = false;
            this.gDataGridView.AllowUserToOrderColumns = true;
            this.gDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.gDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridView.EnableHeadersVisualStyles = false;
            this.gDataGridView.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gDataGridView.MultiSelect = false;
            this.gDataGridView.Name = "gDataGridView";
            this.gDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gDataGridView.RowHeadersVisible = false;
            this.gDataGridView.RowTemplate.Height = 26;
            this.gDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridView.Size = new System.Drawing.Size(1166, 330);
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
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDataGridView_CellClick);
            this.gDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDataGridView_CellContentClick);
            this.gDataGridView.SelectionChanged += new System.EventHandler(this.gDataGridView_SelectionChanged);
            // 
            // panelRecInfo
            // 
            this.panelRecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelRecInfo.Controls.Add(this.gchipRecLog);
            this.panelRecInfo.Controls.Add(this.gchipTitle);
            this.panelRecInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRecInfo.Location = new System.Drawing.Point(0, 380);
            this.panelRecInfo.Name = "panelRecInfo";
            this.panelRecInfo.Size = new System.Drawing.Size(1166, 30);
            this.panelRecInfo.TabIndex = 3;
            // 
            // gchipRecLog
            // 
            this.gchipRecLog.BackColor = System.Drawing.Color.Transparent;
            this.gchipRecLog.BorderRadius = 6;
            this.gchipRecLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchipRecLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.gchipRecLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gchipRecLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipRecLog.Location = new System.Drawing.Point(121, 0);
            this.gchipRecLog.Name = "gchipRecLog";
            this.gchipRecLog.ShadowDecoration.Parent = this.gchipRecLog;
            this.gchipRecLog.Size = new System.Drawing.Size(1045, 30);
            this.gchipRecLog.TabIndex = 22;
            this.gchipRecLog.TabStop = false;
            this.gchipRecLog.Text = "99/99/9999 99:99:99 | Inclusão | Mauro de Jesus  Amaro";
            this.gchipRecLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gchipRecLog.TextOffset = new System.Drawing.Point(6, 0);
            this.gchipRecLog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // gchipTitle
            // 
            this.gchipTitle.BorderRadius = 6;
            this.gchipTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.gchipTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            this.gchipTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gchipTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipTitle.Location = new System.Drawing.Point(0, 0);
            this.gchipTitle.Name = "gchipTitle";
            this.gchipTitle.ShadowDecoration.Parent = this.gchipTitle;
            this.gchipTitle.Size = new System.Drawing.Size(121, 30);
            this.gchipTitle.TabIndex = 18;
            this.gchipTitle.Text = "Última Atualização";
            this.gchipTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panelTitle.Controls.Add(this.pictUCTitle);
            this.panelTitle.Controls.Add(this.glbUCTitle);
            this.panelTitle.Controls.Add(this.gtbSearch);
            this.panelTitle.Controls.Add(this.gcbSearch);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1166, 50);
            this.panelTitle.TabIndex = 0;
            // 
            // pictUCTitle
            // 
            this.pictUCTitle.Image = global::_3DFarmManager.Properties.Resources.icons8_impressora_3d_50_GREEN;
            this.pictUCTitle.Location = new System.Drawing.Point(11, 7);
            this.pictUCTitle.Name = "pictUCTitle";
            this.pictUCTitle.Size = new System.Drawing.Size(43, 34);
            this.pictUCTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUCTitle.TabIndex = 6;
            this.pictUCTitle.TabStop = false;
            // 
            // glbUCTitle
            // 
            this.glbUCTitle.BackColor = System.Drawing.Color.Transparent;
            this.glbUCTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbUCTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.glbUCTitle.Location = new System.Drawing.Point(60, 9);
            this.glbUCTitle.Name = "glbUCTitle";
            this.glbUCTitle.Size = new System.Drawing.Size(135, 31);
            this.glbUCTitle.TabIndex = 5;
            this.glbUCTitle.Text = "Impressoras";
            // 
            // gtbSearch
            // 
            this.gtbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gtbSearch.BorderColor = System.Drawing.Color.LightSlateGray;
            this.gtbSearch.BorderRadius = 5;
            this.gtbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbSearch.DefaultText = "";
            this.gtbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbSearch.DisabledState.Parent = this.gtbSearch;
            this.gtbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbSearch.FocusedState.Parent = this.gtbSearch;
            this.gtbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbSearch.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbSearch.HoverState.Parent = this.gtbSearch;
            this.gtbSearch.IconRight = global::_3DFarmManager.Properties.Resources.icons8_loupe_30_WHITE;
            this.gtbSearch.Location = new System.Drawing.Point(943, 7);
            this.gtbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbSearch.Name = "gtbSearch";
            this.gtbSearch.PasswordChar = '\0';
            this.gtbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.gtbSearch.PlaceholderText = "pesquisar...";
            this.gtbSearch.SelectedText = "";
            this.gtbSearch.ShadowDecoration.Parent = this.gtbSearch;
            this.gtbSearch.Size = new System.Drawing.Size(213, 36);
            this.gtbSearch.TabIndex = 4;
            // 
            // gcbSearch
            // 
            this.gcbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcbSearch.BackColor = System.Drawing.Color.Transparent;
            this.gcbSearch.BorderColor = System.Drawing.Color.LightSlateGray;
            this.gcbSearch.BorderRadius = 5;
            this.gcbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gcbSearch.FocusedColor = System.Drawing.Color.MediumPurple;
            this.gcbSearch.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gcbSearch.FocusedState.Parent = this.gcbSearch;
            this.gcbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbSearch.ForeColor = System.Drawing.Color.White;
            this.gcbSearch.FormattingEnabled = true;
            this.gcbSearch.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gcbSearch.HoverState.Parent = this.gcbSearch;
            this.gcbSearch.ItemHeight = 30;
            this.gcbSearch.ItemsAppearance.Parent = this.gcbSearch;
            this.gcbSearch.Location = new System.Drawing.Point(717, 7);
            this.gcbSearch.Name = "gcbSearch";
            this.gcbSearch.ShadowDecoration.Parent = this.gcbSearch;
            this.gcbSearch.Size = new System.Drawing.Size(210, 36);
            this.gcbSearch.TabIndex = 3;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panelActions.Controls.Add(this.gActionBtDelete);
            this.panelActions.Controls.Add(this.gActionBtEdit);
            this.panelActions.Controls.Add(this.gActionBtRefresh);
            this.panelActions.Controls.Add(this.gActionBtCancel);
            this.panelActions.Controls.Add(this.gActionBtSave);
            this.panelActions.Controls.Add(this.gActionBtAdd);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 410);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1166, 45);
            this.panelActions.TabIndex = 4;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.SlateGray;
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 779);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1166, 31);
            this.panelStatus.TabIndex = 5;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panelData.Controls.Add(this.gcbBrand);
            this.panelData.Controls.Add(this.gtbMaintenanceCost);
            this.panelData.Controls.Add(this.gtbUsefullLife);
            this.panelData.Controls.Add(this.gtbPurchaseCost);
            this.panelData.Controls.Add(this.gtbAnnualCost);
            this.panelData.Controls.Add(this.gtbDepreciation);
            this.panelData.Controls.Add(this.gtbElectricityConsumption);
            this.panelData.Controls.Add(this.gtbId);
            this.panelData.Controls.Add(this.gtbStartDate);
            this.panelData.Controls.Add(this.gtbPurchaseDate);
            this.panelData.Controls.Add(this.gtbPrinterName);
            this.panelData.Controls.Add(this.gdtStartDate);
            this.panelData.Controls.Add(this.gdtPurchase);
            this.panelData.Controls.Add(this.lbId);
            this.panelData.Controls.Add(this.lbDepreciation);
            this.panelData.Controls.Add(this.lbElectricityConsumption);
            this.panelData.Controls.Add(this.lbAnnualCost);
            this.panelData.Controls.Add(this.lbMaintenanceCost);
            this.panelData.Controls.Add(this.lbPurchaseCost);
            this.panelData.Controls.Add(this.lbUsefullLife);
            this.panelData.Controls.Add(this.lbStartDate);
            this.panelData.Controls.Add(this.lbPurchase);
            this.panelData.Controls.Add(this.lbBrand);
            this.panelData.Controls.Add(this.lbPrinterName);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 455);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1166, 324);
            this.panelData.TabIndex = 6;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // gcbBrand
            // 
            this.gcbBrand.BackColor = System.Drawing.Color.Transparent;
            this.gcbBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gcbBrand.BorderRadius = 5;
            this.gcbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gcbBrand.FocusedColor = System.Drawing.Color.Empty;
            this.gcbBrand.FocusedState.Parent = this.gcbBrand;
            this.gcbBrand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcbBrand.ForeColor = System.Drawing.Color.White;
            this.gcbBrand.FormattingEnabled = true;
            this.gcbBrand.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gcbBrand.HoverState.Parent = this.gcbBrand;
            this.gcbBrand.IntegralHeight = false;
            this.gcbBrand.ItemHeight = 30;
            this.gcbBrand.ItemsAppearance.Parent = this.gcbBrand;
            this.gcbBrand.Location = new System.Drawing.Point(151, 102);
            this.gcbBrand.Name = "gcbBrand";
            this.gcbBrand.ShadowDecoration.Parent = this.gcbBrand;
            this.gcbBrand.Size = new System.Drawing.Size(343, 36);
            this.gcbBrand.TabIndex = 8;
            this.gHtmlToolTip1.SetToolTip(this.gcbBrand, "Selecione a marca da impressora");
            this.gcbBrand.Enter += new System.EventHandler(this.gcbBrand_Enter);
            // 
            // gtbMaintenanceCost
            // 
            this.gtbMaintenanceCost.BackColor = System.Drawing.Color.Transparent;
            this.gtbMaintenanceCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbMaintenanceCost.BorderRadius = 5;
            this.gtbMaintenanceCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbMaintenanceCost.DefaultText = "";
            this.gtbMaintenanceCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbMaintenanceCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbMaintenanceCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbMaintenanceCost.DisabledState.Parent = this.gtbMaintenanceCost;
            this.gtbMaintenanceCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbMaintenanceCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbMaintenanceCost.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbMaintenanceCost.FocusedState.Parent = this.gtbMaintenanceCost;
            this.gtbMaintenanceCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbMaintenanceCost.ForeColor = System.Drawing.Color.White;
            this.gtbMaintenanceCost.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbMaintenanceCost.HoverState.Parent = this.gtbMaintenanceCost;
            this.gtbMaintenanceCost.Location = new System.Drawing.Point(531, 37);
            this.gtbMaintenanceCost.Margin = new System.Windows.Forms.Padding(4);
            this.gtbMaintenanceCost.Name = "gtbMaintenanceCost";
            this.gtbMaintenanceCost.PasswordChar = '\0';
            this.gtbMaintenanceCost.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbMaintenanceCost.PlaceholderText = "0,00";
            this.gtbMaintenanceCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gtbMaintenanceCost.SelectedText = "";
            this.gtbMaintenanceCost.ShadowDecoration.Parent = this.gtbMaintenanceCost;
            this.gtbMaintenanceCost.Size = new System.Drawing.Size(166, 36);
            this.gtbMaintenanceCost.TabIndex = 13;
            this.gtbMaintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbMaintenanceCost, "Insira o custo mensal estimado de manutenção dessa impressora");
            this.gtbMaintenanceCost.TextChanged += new System.EventHandler(this.gtbMaintenanceCost_TextChanged);
            this.gtbMaintenanceCost.Click += new System.EventHandler(this.gtbMaintenanceCost_Click);
            this.gtbMaintenanceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbMaintenanceCost_KeyPress);
            this.gtbMaintenanceCost.Leave += new System.EventHandler(this.gtbMaintenanceCost_Leave);
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
            this.gtbUsefullLife.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbUsefullLife.ForeColor = System.Drawing.Color.White;
            this.gtbUsefullLife.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbUsefullLife.HoverState.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.Location = new System.Drawing.Point(329, 234);
            this.gtbUsefullLife.Margin = new System.Windows.Forms.Padding(4);
            this.gtbUsefullLife.Name = "gtbUsefullLife";
            this.gtbUsefullLife.PasswordChar = '\0';
            this.gtbUsefullLife.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbUsefullLife.PlaceholderText = "0";
            this.gtbUsefullLife.SelectedText = "";
            this.gtbUsefullLife.ShadowDecoration.Parent = this.gtbUsefullLife;
            this.gtbUsefullLife.Size = new System.Drawing.Size(165, 36);
            this.gtbUsefullLife.TabIndex = 12;
            this.gtbUsefullLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbUsefullLife, "Insira a quantidade de horas de vida útil da impressora");
            this.gtbUsefullLife.TextChanged += new System.EventHandler(this.gtbUsefullLife_TextChanged);
            this.gtbUsefullLife.Click += new System.EventHandler(this.gtbUsefullLife_Click);
            this.gtbUsefullLife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbUsefullLife_KeyPress);
            this.gtbUsefullLife.Leave += new System.EventHandler(this.gtbUsefullLife_Leave);
            // 
            // gtbPurchaseCost
            // 
            this.gtbPurchaseCost.BackColor = System.Drawing.Color.Transparent;
            this.gtbPurchaseCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbPurchaseCost.BorderRadius = 5;
            this.gtbPurchaseCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPurchaseCost.DefaultText = "";
            this.gtbPurchaseCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbPurchaseCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbPurchaseCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPurchaseCost.DisabledState.Parent = this.gtbPurchaseCost;
            this.gtbPurchaseCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPurchaseCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbPurchaseCost.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbPurchaseCost.FocusedState.Parent = this.gtbPurchaseCost;
            this.gtbPurchaseCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbPurchaseCost.ForeColor = System.Drawing.Color.White;
            this.gtbPurchaseCost.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbPurchaseCost.HoverState.Parent = this.gtbPurchaseCost;
            this.gtbPurchaseCost.Location = new System.Drawing.Point(329, 168);
            this.gtbPurchaseCost.Margin = new System.Windows.Forms.Padding(4);
            this.gtbPurchaseCost.Name = "gtbPurchaseCost";
            this.gtbPurchaseCost.PasswordChar = '\0';
            this.gtbPurchaseCost.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbPurchaseCost.PlaceholderText = "0,00";
            this.gtbPurchaseCost.SelectedText = "";
            this.gtbPurchaseCost.ShadowDecoration.Parent = this.gtbPurchaseCost;
            this.gtbPurchaseCost.Size = new System.Drawing.Size(165, 36);
            this.gtbPurchaseCost.TabIndex = 10;
            this.gtbPurchaseCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbPurchaseCost, "Valor pago pela impressora");
            this.gtbPurchaseCost.TextChanged += new System.EventHandler(this.gtbPurchaseCost_TextChanged);
            this.gtbPurchaseCost.Click += new System.EventHandler(this.gtbPurchaseCost_Click);
            this.gtbPurchaseCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbPurchaseCost_KeyPress);
            this.gtbPurchaseCost.Leave += new System.EventHandler(this.gtbPurchaseCost_Leave);
            // 
            // gtbAnnualCost
            // 
            this.gtbAnnualCost.BackColor = System.Drawing.Color.Transparent;
            this.gtbAnnualCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbAnnualCost.BorderRadius = 5;
            this.gtbAnnualCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbAnnualCost.DefaultText = "";
            this.gtbAnnualCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbAnnualCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbAnnualCost.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.DisabledState.Parent = this.gtbAnnualCost;
            this.gtbAnnualCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(146)))), ((int)(((byte)(87)))));
            this.gtbAnnualCost.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbAnnualCost.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.FocusedState.Parent = this.gtbAnnualCost;
            this.gtbAnnualCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbAnnualCost.ForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbAnnualCost.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.HoverState.Parent = this.gtbAnnualCost;
            this.gtbAnnualCost.IconLeft = global::_3DFarmManager.Properties.Resources.icons8_calculator_30_BLACK;
            this.gtbAnnualCost.IconLeftSize = new System.Drawing.Size(28, 28);
            this.gtbAnnualCost.Location = new System.Drawing.Point(531, 234);
            this.gtbAnnualCost.Margin = new System.Windows.Forms.Padding(4);
            this.gtbAnnualCost.Name = "gtbAnnualCost";
            this.gtbAnnualCost.PasswordChar = '\0';
            this.gtbAnnualCost.PlaceholderForeColor = System.Drawing.Color.Black;
            this.gtbAnnualCost.PlaceholderText = "0,00";
            this.gtbAnnualCost.SelectedText = "";
            this.gtbAnnualCost.ShadowDecoration.Parent = this.gtbAnnualCost;
            this.gtbAnnualCost.Size = new System.Drawing.Size(166, 36);
            this.gtbAnnualCost.TabIndex = 17;
            this.gtbAnnualCost.TabStop = false;
            this.gtbAnnualCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbAnnualCost, "[CALC] Custo total atual de manutenção dos ultimos 12 meses");
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
            this.gtbDepreciation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbDepreciation.ForeColor = System.Drawing.Color.White;
            this.gtbDepreciation.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbDepreciation.HoverState.Parent = this.gtbDepreciation;
            this.gtbDepreciation.Location = new System.Drawing.Point(531, 168);
            this.gtbDepreciation.Margin = new System.Windows.Forms.Padding(4);
            this.gtbDepreciation.Name = "gtbDepreciation";
            this.gtbDepreciation.PasswordChar = '\0';
            this.gtbDepreciation.PlaceholderText = "0,00";
            this.gtbDepreciation.SelectedText = "";
            this.gtbDepreciation.ShadowDecoration.Parent = this.gtbDepreciation;
            this.gtbDepreciation.Size = new System.Drawing.Size(166, 36);
            this.gtbDepreciation.TabIndex = 15;
            this.gtbDepreciation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbDepreciation, "Insira o valor de depreciação estimado por hora de trabalho");
            this.gtbDepreciation.TextChanged += new System.EventHandler(this.gtbDepreciation_TextChanged);
            this.gtbDepreciation.TabIndexChanged += new System.EventHandler(this.gtbDepreciation_TabIndexChanged);
            this.gtbDepreciation.Click += new System.EventHandler(this.gtbDepreciation_Click);
            this.gtbDepreciation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbDepreciation_KeyPress);
            this.gtbDepreciation.Leave += new System.EventHandler(this.gtbDepreciation_Leave);
            // 
            // gtbElectricityConsumption
            // 
            this.gtbElectricityConsumption.BackColor = System.Drawing.Color.Transparent;
            this.gtbElectricityConsumption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbElectricityConsumption.BorderRadius = 5;
            this.gtbElectricityConsumption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbElectricityConsumption.DefaultText = "";
            this.gtbElectricityConsumption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbElectricityConsumption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbElectricityConsumption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbElectricityConsumption.DisabledState.Parent = this.gtbElectricityConsumption;
            this.gtbElectricityConsumption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbElectricityConsumption.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbElectricityConsumption.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbElectricityConsumption.FocusedState.Parent = this.gtbElectricityConsumption;
            this.gtbElectricityConsumption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbElectricityConsumption.ForeColor = System.Drawing.Color.White;
            this.gtbElectricityConsumption.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbElectricityConsumption.HoverState.Parent = this.gtbElectricityConsumption;
            this.gtbElectricityConsumption.Location = new System.Drawing.Point(531, 102);
            this.gtbElectricityConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.gtbElectricityConsumption.Name = "gtbElectricityConsumption";
            this.gtbElectricityConsumption.PasswordChar = '\0';
            this.gtbElectricityConsumption.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbElectricityConsumption.PlaceholderText = "0,00";
            this.gtbElectricityConsumption.SelectedText = "";
            this.gtbElectricityConsumption.ShadowDecoration.Parent = this.gtbElectricityConsumption;
            this.gtbElectricityConsumption.Size = new System.Drawing.Size(166, 36);
            this.gtbElectricityConsumption.TabIndex = 14;
            this.gtbElectricityConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gHtmlToolTip1.SetToolTip(this.gtbElectricityConsumption, "Insira o consumo de energia em Kw/h");
            this.gtbElectricityConsumption.TextChanged += new System.EventHandler(this.gtbElectricityConsumption_TextChanged);
            this.gtbElectricityConsumption.Click += new System.EventHandler(this.gtbElectricityConsumption_Click);
            this.gtbElectricityConsumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbElectricityConsumption_KeyPress);
            this.gtbElectricityConsumption.Leave += new System.EventHandler(this.gtbElectricityConsumption_Leave);
            // 
            // gtbId
            // 
            this.gtbId.BackColor = System.Drawing.Color.Transparent;
            this.gtbId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbId.BorderRadius = 5;
            this.gtbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbId.DefaultText = "";
            this.gtbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbId.DisabledState.Parent = this.gtbId;
            this.gtbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbId.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbId.FocusedState.Parent = this.gtbId;
            this.gtbId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbId.ForeColor = System.Drawing.Color.White;
            this.gtbId.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbId.HoverState.Parent = this.gtbId;
            this.gtbId.Location = new System.Drawing.Point(15, 37);
            this.gtbId.Margin = new System.Windows.Forms.Padding(4);
            this.gtbId.Name = "gtbId";
            this.gtbId.PasswordChar = '\0';
            this.gtbId.PlaceholderText = "";
            this.gtbId.SelectedText = "";
            this.gtbId.ShadowDecoration.Parent = this.gtbId;
            this.gtbId.Size = new System.Drawing.Size(106, 36);
            this.gtbId.TabIndex = 6;
            this.gHtmlToolTip1.SetToolTip(this.gtbId, "ID da impressora na base de dados");
            // 
            // gtbStartDate
            // 
            this.gtbStartDate.BackColor = System.Drawing.Color.Transparent;
            this.gtbStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbStartDate.BorderRadius = 5;
            this.gtbStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbStartDate.DefaultText = "";
            this.gtbStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbStartDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbStartDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbStartDate.DisabledState.Parent = this.gtbStartDate;
            this.gtbStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbStartDate.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbStartDate.FocusedState.Parent = this.gtbStartDate;
            this.gtbStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbStartDate.ForeColor = System.Drawing.Color.White;
            this.gtbStartDate.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbStartDate.HoverState.Parent = this.gtbStartDate;
            this.gtbStartDate.Location = new System.Drawing.Point(151, 234);
            this.gtbStartDate.Margin = new System.Windows.Forms.Padding(5);
            this.gtbStartDate.Name = "gtbStartDate";
            this.gtbStartDate.PasswordChar = '\0';
            this.gtbStartDate.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbStartDate.PlaceholderText = "";
            this.gtbStartDate.SelectedText = "";
            this.gtbStartDate.ShadowDecoration.Parent = this.gtbStartDate;
            this.gtbStartDate.Size = new System.Drawing.Size(141, 36);
            this.gtbStartDate.TabIndex = 8;
            this.gtbStartDate.TextChanged += new System.EventHandler(this.gtbPrinterName_TextChanged);
            // 
            // gtbPurchaseDate
            // 
            this.gtbPurchaseDate.BackColor = System.Drawing.Color.Transparent;
            this.gtbPurchaseDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbPurchaseDate.BorderRadius = 5;
            this.gtbPurchaseDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPurchaseDate.DefaultText = "";
            this.gtbPurchaseDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbPurchaseDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbPurchaseDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPurchaseDate.DisabledState.Parent = this.gtbPurchaseDate;
            this.gtbPurchaseDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPurchaseDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbPurchaseDate.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbPurchaseDate.FocusedState.Parent = this.gtbPurchaseDate;
            this.gtbPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbPurchaseDate.ForeColor = System.Drawing.Color.White;
            this.gtbPurchaseDate.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbPurchaseDate.HoverState.Parent = this.gtbPurchaseDate;
            this.gtbPurchaseDate.Location = new System.Drawing.Point(151, 168);
            this.gtbPurchaseDate.Margin = new System.Windows.Forms.Padding(5);
            this.gtbPurchaseDate.Name = "gtbPurchaseDate";
            this.gtbPurchaseDate.PasswordChar = '\0';
            this.gtbPurchaseDate.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbPurchaseDate.PlaceholderText = "";
            this.gtbPurchaseDate.SelectedText = "";
            this.gtbPurchaseDate.ShadowDecoration.Parent = this.gtbPurchaseDate;
            this.gtbPurchaseDate.Size = new System.Drawing.Size(141, 36);
            this.gtbPurchaseDate.TabIndex = 8;
            this.gtbPurchaseDate.TabStop = false;
            this.gtbPurchaseDate.TextChanged += new System.EventHandler(this.gtbPrinterName_TextChanged);
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
            this.gtbPrinterName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbPrinterName.ForeColor = System.Drawing.Color.White;
            this.gtbPrinterName.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbPrinterName.HoverState.Parent = this.gtbPrinterName;
            this.gtbPrinterName.Location = new System.Drawing.Point(151, 37);
            this.gtbPrinterName.Margin = new System.Windows.Forms.Padding(4);
            this.gtbPrinterName.Name = "gtbPrinterName";
            this.gtbPrinterName.PasswordChar = '\0';
            this.gtbPrinterName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbPrinterName.PlaceholderText = "";
            this.gtbPrinterName.SelectedText = "";
            this.gtbPrinterName.ShadowDecoration.Parent = this.gtbPrinterName;
            this.gtbPrinterName.Size = new System.Drawing.Size(343, 36);
            this.gtbPrinterName.TabIndex = 7;
            this.gHtmlToolTip1.SetToolTip(this.gtbPrinterName, "Insira o nome da impressora dentro da sua Farm");
            this.gtbPrinterName.TextChanged += new System.EventHandler(this.gtbPrinterName_TextChanged);
            // 
            // gdtStartDate
            // 
            this.gdtStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.gdtStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gdtStartDate.BorderRadius = 5;
            this.gdtStartDate.BorderThickness = 1;
            this.gdtStartDate.CheckedState.Parent = this.gdtStartDate;
            this.gdtStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gdtStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtStartDate.ForeColor = System.Drawing.Color.White;
            this.gdtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gdtStartDate.HoverState.Parent = this.gdtStartDate;
            this.gdtStartDate.Location = new System.Drawing.Point(151, 234);
            this.gdtStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtStartDate.Name = "gdtStartDate";
            this.gdtStartDate.ShadowDecoration.Parent = this.gdtStartDate;
            this.gdtStartDate.Size = new System.Drawing.Size(141, 36);
            this.gdtStartDate.TabIndex = 11;
            this.gHtmlToolTip1.SetToolTip(this.gdtStartDate, "Informe a data de inicio de operação da impressora");
            this.gdtStartDate.Value = new System.DateTime(2026, 6, 14, 11, 5, 24, 493);
            this.gdtStartDate.Enter += new System.EventHandler(this.gdtStartDate_Enter);
            // 
            // gdtPurchase
            // 
            this.gdtPurchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gdtPurchase.BorderRadius = 5;
            this.gdtPurchase.BorderThickness = 1;
            this.gdtPurchase.CheckedState.Parent = this.gdtPurchase;
            this.gdtPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gdtPurchase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtPurchase.ForeColor = System.Drawing.Color.White;
            this.gdtPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gdtPurchase.HoverState.Parent = this.gdtPurchase;
            this.gdtPurchase.Location = new System.Drawing.Point(151, 168);
            this.gdtPurchase.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtPurchase.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtPurchase.Name = "gdtPurchase";
            this.gdtPurchase.ShadowDecoration.Parent = this.gdtPurchase;
            this.gdtPurchase.Size = new System.Drawing.Size(141, 36);
            this.gdtPurchase.TabIndex = 9;
            this.gHtmlToolTip1.SetToolTip(this.gdtPurchase, "Informe a data em que a impressora foi comprada");
            this.gdtPurchase.Value = new System.DateTime(2026, 6, 14, 11, 23, 57, 112);
            this.gdtPurchase.Click += new System.EventHandler(this.gdtPurchase_Click);
            this.gdtPurchase.Enter += new System.EventHandler(this.gdtPurchase_Enter);
            this.gdtPurchase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gdtPurchase_MouseClick);
            this.gdtPurchase.MouseEnter += new System.EventHandler(this.gdtPurchase_MouseEnter);
            this.gdtPurchase.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gdtPurchase_PreviewKeyDown);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbId.Location = new System.Drawing.Point(12, 19);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(28, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "ID #";
            // 
            // lbDepreciation
            // 
            this.lbDepreciation.AutoSize = true;
            this.lbDepreciation.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepreciation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbDepreciation.Location = new System.Drawing.Point(529, 150);
            this.lbDepreciation.Name = "lbDepreciation";
            this.lbDepreciation.Size = new System.Drawing.Size(78, 13);
            this.lbDepreciation.TabIndex = 1;
            this.lbDepreciation.Text = "Depreciação *";
            // 
            // lbElectricityConsumption
            // 
            this.lbElectricityConsumption.AutoSize = true;
            this.lbElectricityConsumption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElectricityConsumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbElectricityConsumption.Location = new System.Drawing.Point(528, 84);
            this.lbElectricityConsumption.Name = "lbElectricityConsumption";
            this.lbElectricityConsumption.Size = new System.Drawing.Size(141, 13);
            this.lbElectricityConsumption.TabIndex = 1;
            this.lbElectricityConsumption.Text = "Consumo Energia (Kw/h) *";
            // 
            // lbAnnualCost
            // 
            this.lbAnnualCost.AutoSize = true;
            this.lbAnnualCost.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnualCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbAnnualCost.Location = new System.Drawing.Point(529, 216);
            this.lbAnnualCost.Name = "lbAnnualCost";
            this.lbAnnualCost.Size = new System.Drawing.Size(150, 13);
            this.lbAnnualCost.TabIndex = 1;
            this.lbAnnualCost.Text = "Custo Manutenção (R$/Ano)";
            // 
            // lbMaintenanceCost
            // 
            this.lbMaintenanceCost.AutoSize = true;
            this.lbMaintenanceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaintenanceCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbMaintenanceCost.Location = new System.Drawing.Point(528, 19);
            this.lbMaintenanceCost.Name = "lbMaintenanceCost";
            this.lbMaintenanceCost.Size = new System.Drawing.Size(172, 13);
            this.lbMaintenanceCost.TabIndex = 1;
            this.lbMaintenanceCost.Text = "Custo Mensal Manutenção (R$) *";
            // 
            // lbPurchaseCost
            // 
            this.lbPurchaseCost.AutoSize = true;
            this.lbPurchaseCost.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPurchaseCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbPurchaseCost.Location = new System.Drawing.Point(326, 150);
            this.lbPurchaseCost.Name = "lbPurchaseCost";
            this.lbPurchaseCost.Size = new System.Drawing.Size(101, 13);
            this.lbPurchaseCost.TabIndex = 1;
            this.lbPurchaseCost.Text = "Valor Compra (R$)";
            // 
            // lbUsefullLife
            // 
            this.lbUsefullLife.AutoSize = true;
            this.lbUsefullLife.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsefullLife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbUsefullLife.Location = new System.Drawing.Point(326, 216);
            this.lbUsefullLife.Name = "lbUsefullLife";
            this.lbUsefullLife.Size = new System.Drawing.Size(90, 13);
            this.lbUsefullLife.TabIndex = 1;
            this.lbUsefullLife.Text = "Vida Útil (horas)";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbStartDate.Location = new System.Drawing.Point(148, 216);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(102, 13);
            this.lbStartDate.TabIndex = 1;
            this.lbStartDate.Text = "Inicio de Operação";
            // 
            // lbPurchase
            // 
            this.lbPurchase.AutoSize = true;
            this.lbPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbPurchase.Location = new System.Drawing.Point(148, 150);
            this.lbPurchase.Name = "lbPurchase";
            this.lbPurchase.Size = new System.Drawing.Size(91, 13);
            this.lbPurchase.TabIndex = 1;
            this.lbPurchase.Text = "Data da Compra";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbBrand.Location = new System.Drawing.Point(148, 84);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(104, 13);
            this.lbBrand.TabIndex = 1;
            this.lbBrand.Text = "Fabricante/Marca *";
            // 
            // lbPrinterName
            // 
            this.lbPrinterName.AutoSize = true;
            this.lbPrinterName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbPrinterName.Location = new System.Drawing.Point(148, 19);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(46, 13);
            this.lbPrinterName.TabIndex = 1;
            this.lbPrinterName.Text = "Nome *";
            // 
            // gHtmlToolTip1
            // 
            this.gHtmlToolTip1.AllowLinksHandling = true;
            this.gHtmlToolTip1.AutoPopDelay = 5000;
            this.gHtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.gHtmlToolTip1.BorderColor = System.Drawing.Color.Silver;
            this.gHtmlToolTip1.ForeColor = System.Drawing.Color.White;
            this.gHtmlToolTip1.InitialDelay = 100;
            this.gHtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.gHtmlToolTip1.ReshowDelay = 100;
            this.gHtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // gActionBtDelete
            // 
            this.gActionBtDelete.ActionEnabled = true;
            this.gActionBtDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtDelete.BorderRadius = 6;
            this.gActionBtDelete.BorderThickness = 1;
            this.gActionBtDelete.CheckedState.Parent = this.gActionBtDelete;
            this.gActionBtDelete.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Delete;
            this.gActionBtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtDelete.CustomImages.Parent = this.gActionBtDelete;
            this.gActionBtDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtDelete.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtDelete.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtDelete.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtDelete.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtDelete.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtDelete.DisabledImage = global::_3DFarmManager.Properties.Resources.trash_can_regular_DARK_GREEN;
            this.gActionBtDelete.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtDelete.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtDelete.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtDelete.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtDelete.EnabledImage = global::_3DFarmManager.Properties.Resources.trash_can_regular_GREEN;
            this.gActionBtDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtDelete.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtDelete.HoverState.Image = global::_3DFarmManager.Properties.Resources.trash_can_regular_DARK_GREEN;
            this.gActionBtDelete.HoverState.Parent = this.gActionBtDelete;
            this.gActionBtDelete.Image = global::_3DFarmManager.Properties.Resources.trash_can_regular_GREEN;
            this.gActionBtDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtDelete.ImageSize = new System.Drawing.Size(24, 24);
            this.gActionBtDelete.Location = new System.Drawing.Point(215, 8);
            this.gActionBtDelete.Name = "gActionBtDelete";
            this.gActionBtDelete.ShadowDecoration.Parent = this.gActionBtDelete;
            this.gActionBtDelete.Size = new System.Drawing.Size(96, 29);
            this.gActionBtDelete.TabIndex = 3;
            this.gActionBtDelete.Text = "Excluir";
            this.gActionBtDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtDelete, "Excluir Impressora");
            this.gActionBtDelete.Click += new System.EventHandler(this.gActionBtDelete_Click);
            // 
            // gActionBtEdit
            // 
            this.gActionBtEdit.ActionEnabled = true;
            this.gActionBtEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtEdit.BorderRadius = 6;
            this.gActionBtEdit.BorderThickness = 1;
            this.gActionBtEdit.CheckedState.Parent = this.gActionBtEdit;
            this.gActionBtEdit.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Edit;
            this.gActionBtEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtEdit.CustomImages.Parent = this.gActionBtEdit;
            this.gActionBtEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtEdit.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtEdit.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtEdit.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtEdit.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtEdit.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtEdit.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtEdit.DisabledImage = global::_3DFarmManager.Properties.Resources.pen_to_square_solid_DARK_GREEN;
            this.gActionBtEdit.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtEdit.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtEdit.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtEdit.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtEdit.EnabledImage = global::_3DFarmManager.Properties.Resources.pen_to_square_solid_GREEN;
            this.gActionBtEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtEdit.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtEdit.HoverState.Image = global::_3DFarmManager.Properties.Resources.pen_to_square_solid_DARK_GREEN;
            this.gActionBtEdit.HoverState.Parent = this.gActionBtEdit;
            this.gActionBtEdit.Image = global::_3DFarmManager.Properties.Resources.pen_to_square_solid_GREEN;
            this.gActionBtEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtEdit.Location = new System.Drawing.Point(113, 8);
            this.gActionBtEdit.Name = "gActionBtEdit";
            this.gActionBtEdit.ShadowDecoration.Parent = this.gActionBtEdit;
            this.gActionBtEdit.Size = new System.Drawing.Size(96, 29);
            this.gActionBtEdit.TabIndex = 2;
            this.gActionBtEdit.Text = "Editar";
            this.gActionBtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtEdit, "Editar dados da impressora");
            this.gActionBtEdit.Click += new System.EventHandler(this.gActionBtEdit_Click);
            // 
            // gActionBtRefresh
            // 
            this.gActionBtRefresh.ActionEnabled = true;
            this.gActionBtRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gActionBtRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtRefresh.BorderRadius = 6;
            this.gActionBtRefresh.BorderThickness = 1;
            this.gActionBtRefresh.CheckedState.Parent = this.gActionBtRefresh;
            this.gActionBtRefresh.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Refresh;
            this.gActionBtRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtRefresh.CustomImages.Parent = this.gActionBtRefresh;
            this.gActionBtRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtRefresh.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtRefresh.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtRefresh.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtRefresh.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtRefresh.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtRefresh.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtRefresh.DisabledImage = global::_3DFarmManager.Properties.Resources.icons8_refresh_30_ORANGE_DARK;
            this.gActionBtRefresh.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtRefresh.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtRefresh.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtRefresh.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtRefresh.EnabledImage = global::_3DFarmManager.Properties.Resources.icons8_refresh_30_ORANGE;
            this.gActionBtRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtRefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtRefresh.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtRefresh.HoverState.Image = global::_3DFarmManager.Properties.Resources.icons8_refresh_30_ORANGE_DARK;
            this.gActionBtRefresh.HoverState.Parent = this.gActionBtRefresh;
            this.gActionBtRefresh.Image = global::_3DFarmManager.Properties.Resources.icons8_refresh_30_ORANGE;
            this.gActionBtRefresh.Location = new System.Drawing.Point(1127, 8);
            this.gActionBtRefresh.Name = "gActionBtRefresh";
            this.gActionBtRefresh.ShadowDecoration.Parent = this.gActionBtRefresh;
            this.gActionBtRefresh.Size = new System.Drawing.Size(29, 29);
            this.gActionBtRefresh.TabIndex = 8;
            this.gActionBtRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtRefresh, "Atualizar Lista");
            this.gActionBtRefresh.Click += new System.EventHandler(this.gActionBtRefresh_Click);
            // 
            // gActionBtCancel
            // 
            this.gActionBtCancel.ActionEnabled = true;
            this.gActionBtCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtCancel.BorderRadius = 6;
            this.gActionBtCancel.BorderThickness = 1;
            this.gActionBtCancel.CheckedState.Parent = this.gActionBtCancel;
            this.gActionBtCancel.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Cancel;
            this.gActionBtCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtCancel.CustomImages.Parent = this.gActionBtCancel;
            this.gActionBtCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtCancel.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtCancel.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtCancel.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtCancel.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtCancel.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtCancel.DisabledImage = global::_3DFarmManager.Properties.Resources.circle_xmark_regular_DARK_GREEN;
            this.gActionBtCancel.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtCancel.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtCancel.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtCancel.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtCancel.EnabledImage = global::_3DFarmManager.Properties.Resources.circle_xmark_regular_GREEN;
            this.gActionBtCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtCancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtCancel.HoverState.Image = global::_3DFarmManager.Properties.Resources.circle_xmark_regular_DARK_GREEN;
            this.gActionBtCancel.HoverState.Parent = this.gActionBtCancel;
            this.gActionBtCancel.Image = global::_3DFarmManager.Properties.Resources.circle_xmark_regular_GREEN;
            this.gActionBtCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtCancel.Location = new System.Drawing.Point(521, 8);
            this.gActionBtCancel.Name = "gActionBtCancel";
            this.gActionBtCancel.ShadowDecoration.Parent = this.gActionBtCancel;
            this.gActionBtCancel.Size = new System.Drawing.Size(96, 29);
            this.gActionBtCancel.TabIndex = 5;
            this.gActionBtCancel.Text = "Cancelar";
            this.gActionBtCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtCancel, "Cancelar operação");
            this.gActionBtCancel.Click += new System.EventHandler(this.gActionBtCancel_Click);
            // 
            // gActionBtSave
            // 
            this.gActionBtSave.ActionEnabled = true;
            this.gActionBtSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtSave.BorderRadius = 6;
            this.gActionBtSave.BorderThickness = 1;
            this.gActionBtSave.CheckedState.Parent = this.gActionBtSave;
            this.gActionBtSave.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Save;
            this.gActionBtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtSave.CustomImages.Parent = this.gActionBtSave;
            this.gActionBtSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtSave.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtSave.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtSave.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtSave.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtSave.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtSave.DisabledImage = global::_3DFarmManager.Properties.Resources.floppy_disk_regular_DARK_GREEN;
            this.gActionBtSave.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtSave.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtSave.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtSave.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtSave.EnabledImage = global::_3DFarmManager.Properties.Resources.floppy_disk_regular_GREEN;
            this.gActionBtSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtSave.HoverState.Image = global::_3DFarmManager.Properties.Resources.floppy_disk_regular_DARK_GREEN;
            this.gActionBtSave.HoverState.Parent = this.gActionBtSave;
            this.gActionBtSave.Image = global::_3DFarmManager.Properties.Resources.floppy_disk_regular_GREEN;
            this.gActionBtSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtSave.Location = new System.Drawing.Point(419, 8);
            this.gActionBtSave.Name = "gActionBtSave";
            this.gActionBtSave.ShadowDecoration.Parent = this.gActionBtSave;
            this.gActionBtSave.Size = new System.Drawing.Size(96, 29);
            this.gActionBtSave.TabIndex = 4;
            this.gActionBtSave.Text = "Salvar";
            this.gActionBtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtSave, "Salvar dados da Impressora");
            this.gActionBtSave.Click += new System.EventHandler(this.gActionBtSave_Click);
            // 
            // gActionBtAdd
            // 
            this.gActionBtAdd.ActionEnabled = true;
            this.gActionBtAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtAdd.BorderRadius = 6;
            this.gActionBtAdd.BorderThickness = 1;
            this.gActionBtAdd.CheckedState.Parent = this.gActionBtAdd;
            this.gActionBtAdd.CrudAction = _3DFarmManager.Framework.Crud.CrudAction.Insert;
            this.gActionBtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtAdd.CustomImages.Parent = this.gActionBtAdd;
            this.gActionBtAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtAdd.DisabledCursor = System.Windows.Forms.Cursors.No;
            this.gActionBtAdd.DisabledFillColor = System.Drawing.Color.DimGray;
            this.gActionBtAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.gActionBtAdd.DisabledHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtAdd.DisabledHoverFillColor = System.Drawing.Color.DimGray;
            this.gActionBtAdd.DisabledHoverForeColor = System.Drawing.Color.Gray;
            this.gActionBtAdd.DisabledImage = global::_3DFarmManager.Properties.Resources.file_regular_DARK_GREEN;
            this.gActionBtAdd.EnabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gActionBtAdd.EnabledCursor = System.Windows.Forms.Cursors.Hand;
            this.gActionBtAdd.EnabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtAdd.EnabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtAdd.EnabledImage = global::_3DFarmManager.Properties.Resources.file_regular_GREEN;
            this.gActionBtAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gActionBtAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gActionBtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.gActionBtAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(206)))), ((int)(((byte)(188)))));
            this.gActionBtAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(188)))));
            this.gActionBtAdd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gActionBtAdd.HoverState.Image = global::_3DFarmManager.Properties.Resources.file_regular_DARK_GREEN;
            this.gActionBtAdd.HoverState.Parent = this.gActionBtAdd;
            this.gActionBtAdd.Image = global::_3DFarmManager.Properties.Resources.file_regular_GREEN;
            this.gActionBtAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtAdd.ImageSize = new System.Drawing.Size(18, 20);
            this.gActionBtAdd.Location = new System.Drawing.Point(11, 8);
            this.gActionBtAdd.Name = "gActionBtAdd";
            this.gActionBtAdd.ShadowDecoration.Parent = this.gActionBtAdd;
            this.gActionBtAdd.Size = new System.Drawing.Size(96, 29);
            this.gActionBtAdd.TabIndex = 1;
            this.gActionBtAdd.Text = "Incluir";
            this.gActionBtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gHtmlToolTip1.SetToolTip(this.gActionBtAdd, "Adicionar Impressora");
            this.gActionBtAdd.Click += new System.EventHandler(this.gActionBtAdd_Click);
            // 
            // UC_3DPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelTitleAndGrid);
            this.Name = "UC_3DPrinters";
            this.Size = new System.Drawing.Size(1166, 810);
            this.panelTitleAndGrid.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).EndInit();
            this.panelRecInfo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUCTitle)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleAndGrid;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lbPrinterName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbPurchaseCost;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbPurchase;
        private System.Windows.Forms.Label lbUsefullLife;
        private System.Windows.Forms.Label lbMaintenanceCost;
        private System.Windows.Forms.Label lbElectricityConsumption;
        private System.Windows.Forms.Label lbDepreciation;
        private System.Windows.Forms.Label lbAnnualCost;
        private System.Windows.Forms.Panel panelRecInfo;
        private System.Windows.Forms.Panel panelDataGrid;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox gtbPrinterName;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdtStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdtPurchase;
        private Guna.UI2.WinForms.Guna2TextBox gtbMaintenanceCost;
        private Guna.UI2.WinForms.Guna2TextBox gtbUsefullLife;
        private Guna.UI2.WinForms.Guna2TextBox gtbPurchaseCost;
        private Guna.UI2.WinForms.Guna2TextBox gtbAnnualCost;
        private Guna.UI2.WinForms.Guna2TextBox gtbDepreciation;
        private Guna.UI2.WinForms.Guna2TextBox gtbElectricityConsumption;
        private Guna.UI2.WinForms.Guna2ComboBox gcbBrand;
        private Guna.UI2.WinForms.Guna2TextBox gtbId;
        private Guna.UI2.WinForms.Guna2TextBox gtbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox gcbSearch;
        private Guna.UI2.WinForms.Guna2HtmlToolTip gHtmlToolTip1;
        private Guna.UI2.WinForms.Guna2HtmlLabel glbUCTitle;
        private System.Windows.Forms.PictureBox pictUCTitle;
        private Guna.UI2.WinForms.Guna2Chip gchipTitle;
        private Guna.UI2.WinForms.Guna2Chip gchipRecLog;
        private Guna.UI2.WinForms.Guna2TextBox gtbPurchaseDate;
        private Guna.UI2.WinForms.Guna2TextBox gtbStartDate;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtAdd;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtDelete;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtEdit;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtSave;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtCancel;
        private _3DFarmManager.Framework.Controls.GActionButton gActionBtRefresh;
    }
}
