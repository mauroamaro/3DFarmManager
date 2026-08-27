namespace _3DFarmManager
{
    partial class formUnits
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.gbtExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.gDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelRecInfo = new System.Windows.Forms.Panel();
            this.gchipRecLog = new Guna.UI2.WinForms.Guna2Chip();
            this.gchipTitle = new Guna.UI2.WinForms.Guna2Chip();
            this.panelActions = new System.Windows.Forms.Panel();
            this.gActionBtRefresh = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtDelete = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtEdit = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtCancel = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtSave = new _3DFarmManager.Framework.Controls.GActionButton();
            this.gActionBtAdd = new _3DFarmManager.Framework.Controls.GActionButton();
            this.panelData = new System.Windows.Forms.Panel();
            this.gtbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbShortName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTitle.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).BeginInit();
            this.panelRecInfo.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.panelTitle.Controls.Add(this.gbtExit);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(766, 35);
            this.panelTitle.TabIndex = 1;
            // 
            // gbtExit
            // 
            this.gbtExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtExit.BackColor = System.Drawing.Color.Transparent;
            this.gbtExit.CheckedState.Parent = this.gbtExit;
            this.gbtExit.CustomImages.Parent = this.gbtExit;
            this.gbtExit.FillColor = System.Drawing.Color.Transparent;
            this.gbtExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtExit.ForeColor = System.Drawing.Color.White;
            this.gbtExit.HoverState.BorderColor = System.Drawing.Color.White;
            this.gbtExit.HoverState.Image = global::_3DFarmManager.Properties.Resources.CloseBold;
            this.gbtExit.HoverState.Parent = this.gbtExit;
            this.gbtExit.Image = global::_3DFarmManager.Properties.Resources.Close;
            this.gbtExit.Location = new System.Drawing.Point(735, 6);
            this.gbtExit.Name = "gbtExit";
            this.gbtExit.ShadowDecoration.Parent = this.gbtExit;
            this.gbtExit.Size = new System.Drawing.Size(23, 22);
            this.gbtExit.TabIndex = 1;
            this.gbtExit.Click += new System.EventHandler(this.gbtExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(12, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Unidades de Medida";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.panelDataGrid.Controls.Add(this.gDataGridView);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 35);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(766, 271);
            this.panelDataGrid.TabIndex = 2;
            // 
            // gDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(157)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.gDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridView.EnableHeadersVisualStyles = false;
            this.gDataGridView.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gDataGridView.Name = "gDataGridView";
            this.gDataGridView.ReadOnly = true;
            this.gDataGridView.RowHeadersVisible = false;
            this.gDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridView.Size = new System.Drawing.Size(766, 271);
            this.gDataGridView.TabIndex = 10;
            this.gDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(157)))), ((int)(((byte)(153)))));
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.gDataGridView.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.gDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.gDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.gDataGridView.ThemeStyle.ReadOnly = true;
            this.gDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.gDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            this.gDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDataGridView_CellClick);
            this.gDataGridView.SelectionChanged += new System.EventHandler(this.gDataGridView_SelectionChanged);
            // 
            // panelRecInfo
            // 
            this.panelRecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(162)))), ((int)(((byte)(157)))));
            this.panelRecInfo.Controls.Add(this.gchipRecLog);
            this.panelRecInfo.Controls.Add(this.gchipTitle);
            this.panelRecInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecInfo.Location = new System.Drawing.Point(0, 306);
            this.panelRecInfo.Name = "panelRecInfo";
            this.panelRecInfo.Size = new System.Drawing.Size(766, 32);
            this.panelRecInfo.TabIndex = 3;
            // 
            // gchipRecLog
            // 
            this.gchipRecLog.BackColor = System.Drawing.Color.Transparent;
            this.gchipRecLog.BorderRadius = 6;
            this.gchipRecLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchipRecLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(93)))), ((int)(((byte)(104)))));
            this.gchipRecLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gchipRecLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipRecLog.Location = new System.Drawing.Point(121, 0);
            this.gchipRecLog.Name = "gchipRecLog";
            this.gchipRecLog.ShadowDecoration.Parent = this.gchipRecLog;
            this.gchipRecLog.Size = new System.Drawing.Size(645, 32);
            this.gchipRecLog.TabIndex = 26;
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
            this.gchipTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(83)))));
            this.gchipTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gchipTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipTitle.Location = new System.Drawing.Point(0, 0);
            this.gchipTitle.Name = "gchipTitle";
            this.gchipTitle.ShadowDecoration.Parent = this.gchipTitle;
            this.gchipTitle.Size = new System.Drawing.Size(121, 32);
            this.gchipTitle.TabIndex = 25;
            this.gchipTitle.Text = "Última Atualização";
            this.gchipTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.panelActions.Controls.Add(this.gActionBtRefresh);
            this.panelActions.Controls.Add(this.gActionBtDelete);
            this.panelActions.Controls.Add(this.gActionBtEdit);
            this.panelActions.Controls.Add(this.gActionBtCancel);
            this.panelActions.Controls.Add(this.gActionBtSave);
            this.panelActions.Controls.Add(this.gActionBtAdd);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 338);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(766, 45);
            this.panelActions.TabIndex = 4;
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
            this.gActionBtRefresh.Location = new System.Drawing.Point(729, 8);
            this.gActionBtRefresh.Name = "gActionBtRefresh";
            this.gActionBtRefresh.ShadowDecoration.Parent = this.gActionBtRefresh;
            this.gActionBtRefresh.Size = new System.Drawing.Size(29, 29);
            this.gActionBtRefresh.TabIndex = 6;
            this.gActionBtRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtRefresh.Click += new System.EventHandler(this.gActionBtRefresh_Click);
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
            this.gActionBtDelete.Location = new System.Drawing.Point(211, 9);
            this.gActionBtDelete.Name = "gActionBtDelete";
            this.gActionBtDelete.ShadowDecoration.Parent = this.gActionBtDelete;
            this.gActionBtDelete.Size = new System.Drawing.Size(96, 29);
            this.gActionBtDelete.TabIndex = 3;
            this.gActionBtDelete.Text = "Excluir";
            this.gActionBtDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gActionBtEdit.Location = new System.Drawing.Point(109, 9);
            this.gActionBtEdit.Name = "gActionBtEdit";
            this.gActionBtEdit.ShadowDecoration.Parent = this.gActionBtEdit;
            this.gActionBtEdit.Size = new System.Drawing.Size(96, 29);
            this.gActionBtEdit.TabIndex = 2;
            this.gActionBtEdit.Text = "Editar";
            this.gActionBtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtEdit.Click += new System.EventHandler(this.gActionBtEdit_Click);
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
            this.gActionBtCancel.Location = new System.Drawing.Point(517, 9);
            this.gActionBtCancel.Name = "gActionBtCancel";
            this.gActionBtCancel.ShadowDecoration.Parent = this.gActionBtCancel;
            this.gActionBtCancel.Size = new System.Drawing.Size(96, 29);
            this.gActionBtCancel.TabIndex = 5;
            this.gActionBtCancel.Text = "Cancelar";
            this.gActionBtCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gActionBtSave.Location = new System.Drawing.Point(415, 9);
            this.gActionBtSave.Name = "gActionBtSave";
            this.gActionBtSave.ShadowDecoration.Parent = this.gActionBtSave;
            this.gActionBtSave.Size = new System.Drawing.Size(96, 29);
            this.gActionBtSave.TabIndex = 4;
            this.gActionBtSave.Text = "Salvar";
            this.gActionBtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gActionBtAdd.Location = new System.Drawing.Point(7, 9);
            this.gActionBtAdd.Name = "gActionBtAdd";
            this.gActionBtAdd.ShadowDecoration.Parent = this.gActionBtAdd;
            this.gActionBtAdd.Size = new System.Drawing.Size(96, 29);
            this.gActionBtAdd.TabIndex = 1;
            this.gActionBtAdd.Text = "Incluir";
            this.gActionBtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gActionBtAdd.Click += new System.EventHandler(this.gActionBtAdd_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.panelData.Controls.Add(this.gtbName);
            this.panelData.Controls.Add(this.gtbShortName);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.lbPrinterName);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 383);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(766, 100);
            this.panelData.TabIndex = 5;
            // 
            // gtbName
            // 
            this.gtbName.BackColor = System.Drawing.Color.Transparent;
            this.gtbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.gtbName.BorderRadius = 5;
            this.gtbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbName.DefaultText = "";
            this.gtbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbName.DisabledState.Parent = this.gtbName;
            this.gtbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.gtbName.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbName.FocusedState.Parent = this.gtbName;
            this.gtbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbName.ForeColor = System.Drawing.Color.White;
            this.gtbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(162)))), ((int)(((byte)(157)))));
            this.gtbName.HoverState.Parent = this.gtbName;
            this.gtbName.Location = new System.Drawing.Point(13, 36);
            this.gtbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbName.MaxLength = 50;
            this.gtbName.Name = "gtbName";
            this.gtbName.PasswordChar = '\0';
            this.gtbName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbName.PlaceholderText = "";
            this.gtbName.SelectedText = "";
            this.gtbName.ShadowDecoration.Parent = this.gtbName;
            this.gtbName.Size = new System.Drawing.Size(600, 36);
            this.gtbName.TabIndex = 7;
            // 
            // gtbShortName
            // 
            this.gtbShortName.BackColor = System.Drawing.Color.Transparent;
            this.gtbShortName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.gtbShortName.BorderRadius = 5;
            this.gtbShortName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbShortName.DefaultText = "";
            this.gtbShortName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbShortName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbShortName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbShortName.DisabledState.Parent = this.gtbShortName;
            this.gtbShortName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbShortName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.gtbShortName.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbShortName.FocusedState.Parent = this.gtbShortName;
            this.gtbShortName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbShortName.ForeColor = System.Drawing.Color.White;
            this.gtbShortName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(162)))), ((int)(((byte)(157)))));
            this.gtbShortName.HoverState.Parent = this.gtbShortName;
            this.gtbShortName.Location = new System.Drawing.Point(640, 36);
            this.gtbShortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbShortName.MaxLength = 10;
            this.gtbShortName.Name = "gtbShortName";
            this.gtbShortName.PasswordChar = '\0';
            this.gtbShortName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbShortName.PlaceholderText = "";
            this.gtbShortName.SelectedText = "";
            this.gtbShortName.ShadowDecoration.Parent = this.gtbShortName;
            this.gtbShortName.Size = new System.Drawing.Size(118, 36);
            this.gtbShortName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(637, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sigla *";
            // 
            // lbPrinterName
            // 
            this.lbPrinterName.AutoSize = true;
            this.lbPrinterName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinterName.ForeColor = System.Drawing.Color.LightGray;
            this.lbPrinterName.Location = new System.Drawing.Point(10, 18);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(46, 13);
            this.lbPrinterName.TabIndex = 8;
            this.lbPrinterName.Text = "Nome *";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelTitle;
            // 
            // formUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 483);
            this.ControlBox = false;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelRecInfo);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView)).EndInit();
            this.panelRecInfo.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        public Guna.UI2.WinForms.Guna2Button gbtExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDataGrid;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGridView;
        private System.Windows.Forms.Panel panelRecInfo;
        private Guna.UI2.WinForms.Guna2Chip gchipRecLog;
        private Guna.UI2.WinForms.Guna2Chip gchipTitle;
        private System.Windows.Forms.Panel panelActions;
        private Framework.Controls.GActionButton gActionBtRefresh;
        private Framework.Controls.GActionButton gActionBtDelete;
        private Framework.Controls.GActionButton gActionBtEdit;
        private Framework.Controls.GActionButton gActionBtCancel;
        private Framework.Controls.GActionButton gActionBtSave;
        private Framework.Controls.GActionButton gActionBtAdd;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2TextBox gtbName;
        private Guna.UI2.WinForms.Guna2TextBox gtbShortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrinterName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}