namespace _3DFarmManager.UserControls
{
    partial class UC_ExpensesFixed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelExpensesFixed = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gtbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.gtbExpenseTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbExpenseTotal = new System.Windows.Forms.Label();
            this.lbExpenseName = new System.Windows.Forms.Label();
            this.gtbExpenseValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExpenseValue = new System.Windows.Forms.Label();
            this.gtbExpenseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.gbtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gbtSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbtEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gbtAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gbtDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panelRecInfo = new System.Windows.Forms.Panel();
            this.panelRecInfoLog = new System.Windows.Forms.Panel();
            this.gchipRecLog = new Guna.UI2.WinForms.Guna2Chip();
            this.gchipTitle = new Guna.UI2.WinForms.Guna2Chip();
            this.panelGridView = new System.Windows.Forms.Panel();
            this.gDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbtRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panelExpensesFixed.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelRecInfo.SuspendLayout();
            this.panelRecInfoLog.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExpensesFixed
            // 
            this.panelExpensesFixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panelExpensesFixed.Controls.Add(this.panelData);
            this.panelExpensesFixed.Controls.Add(this.panelActions);
            this.panelExpensesFixed.Controls.Add(this.panelRecInfo);
            this.panelExpensesFixed.Controls.Add(this.panelGridView);
            this.panelExpensesFixed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExpensesFixed.Location = new System.Drawing.Point(0, 0);
            this.panelExpensesFixed.Name = "panelExpensesFixed";
            this.panelExpensesFixed.Size = new System.Drawing.Size(1005, 646);
            this.panelExpensesFixed.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gtbId);
            this.panelData.Controls.Add(this.lbId);
            this.panelData.Controls.Add(this.gtbExpenseTotal);
            this.panelData.Controls.Add(this.gtbDescription);
            this.panelData.Controls.Add(this.lbExpenseTotal);
            this.panelData.Controls.Add(this.lbExpenseName);
            this.panelData.Controls.Add(this.gtbExpenseValue);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.lbExpenseValue);
            this.panelData.Controls.Add(this.gtbExpenseName);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 375);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1005, 271);
            this.panelData.TabIndex = 33;
            // 
            // gtbId
            // 
            this.gtbId.BackColor = System.Drawing.Color.Transparent;
            this.gtbId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(135)))));
            this.gtbId.BorderRadius = 5;
            this.gtbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbId.DefaultText = "";
            this.gtbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbId.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.gtbId.DisabledState.Parent = this.gtbId;
            this.gtbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.gtbId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.gtbId.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbId.FocusedState.Parent = this.gtbId;
            this.gtbId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbId.ForeColor = System.Drawing.Color.White;
            this.gtbId.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbId.HoverState.Parent = this.gtbId;
            this.gtbId.Location = new System.Drawing.Point(11, 32);
            this.gtbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbId.Name = "gtbId";
            this.gtbId.PasswordChar = '\0';
            this.gtbId.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(184)))));
            this.gtbId.PlaceholderText = "";
            this.gtbId.SelectedText = "";
            this.gtbId.ShadowDecoration.Parent = this.gtbId;
            this.gtbId.Size = new System.Drawing.Size(106, 36);
            this.gtbId.TabIndex = 6;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbId.Location = new System.Drawing.Point(8, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(28, 13);
            this.lbId.TabIndex = 21;
            this.lbId.Text = "ID #";
            // 
            // gtbExpenseTotal
            // 
            this.gtbExpenseTotal.BackColor = System.Drawing.Color.Transparent;
            this.gtbExpenseTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbExpenseTotal.BorderRadius = 5;
            this.gtbExpenseTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbExpenseTotal.DefaultText = "";
            this.gtbExpenseTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbExpenseTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbExpenseTotal.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.gtbExpenseTotal.DisabledState.Parent = this.gtbExpenseTotal;
            this.gtbExpenseTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.gtbExpenseTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(146)))), ((int)(((byte)(87)))));
            this.gtbExpenseTotal.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbExpenseTotal.FocusedState.Parent = this.gtbExpenseTotal;
            this.gtbExpenseTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbExpenseTotal.ForeColor = System.Drawing.Color.Tan;
            this.gtbExpenseTotal.HoverState.BorderColor = System.Drawing.Color.Tan;
            this.gtbExpenseTotal.HoverState.Parent = this.gtbExpenseTotal;
            this.gtbExpenseTotal.IconLeft = global::_3DFarmManager.Properties.Resources.icons8_calculator_30_BLACK;
            this.gtbExpenseTotal.IconLeftSize = new System.Drawing.Size(30, 30);
            this.gtbExpenseTotal.Location = new System.Drawing.Point(786, 32);
            this.gtbExpenseTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbExpenseTotal.Name = "gtbExpenseTotal";
            this.gtbExpenseTotal.PasswordChar = '\0';
            this.gtbExpenseTotal.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(184)))));
            this.gtbExpenseTotal.PlaceholderText = "0,00";
            this.gtbExpenseTotal.SelectedText = "";
            this.gtbExpenseTotal.ShadowDecoration.Parent = this.gtbExpenseTotal;
            this.gtbExpenseTotal.Size = new System.Drawing.Size(166, 36);
            this.gtbExpenseTotal.TabIndex = 10;
            this.gtbExpenseTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbDescription
            // 
            this.gtbDescription.BackColor = System.Drawing.Color.Transparent;
            this.gtbDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(135)))));
            this.gtbDescription.BorderRadius = 5;
            this.gtbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbDescription.DefaultText = "";
            this.gtbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbDescription.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.gtbDescription.DisabledState.Parent = this.gtbDescription;
            this.gtbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.gtbDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.gtbDescription.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbDescription.FocusedState.Parent = this.gtbDescription;
            this.gtbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbDescription.ForeColor = System.Drawing.Color.White;
            this.gtbDescription.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbDescription.HoverState.Parent = this.gtbDescription;
            this.gtbDescription.Location = new System.Drawing.Point(148, 99);
            this.gtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbDescription.Multiline = true;
            this.gtbDescription.Name = "gtbDescription";
            this.gtbDescription.PasswordChar = '\0';
            this.gtbDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(184)))));
            this.gtbDescription.PlaceholderText = "";
            this.gtbDescription.SelectedText = "";
            this.gtbDescription.ShadowDecoration.Parent = this.gtbDescription;
            this.gtbDescription.Size = new System.Drawing.Size(804, 130);
            this.gtbDescription.TabIndex = 9;
            // 
            // lbExpenseTotal
            // 
            this.lbExpenseTotal.AutoSize = true;
            this.lbExpenseTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpenseTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbExpenseTotal.Location = new System.Drawing.Point(784, 14);
            this.lbExpenseTotal.Name = "lbExpenseTotal";
            this.lbExpenseTotal.Size = new System.Drawing.Size(133, 13);
            this.lbExpenseTotal.TabIndex = 18;
            this.lbExpenseTotal.Text = "Total Despesas (R$/Mês)";
            // 
            // lbExpenseName
            // 
            this.lbExpenseName.AutoSize = true;
            this.lbExpenseName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpenseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbExpenseName.Location = new System.Drawing.Point(145, 14);
            this.lbExpenseName.Name = "lbExpenseName";
            this.lbExpenseName.Size = new System.Drawing.Size(106, 13);
            this.lbExpenseName.TabIndex = 9;
            this.lbExpenseName.Text = "Título da Despesa *";
            // 
            // gtbExpenseValue
            // 
            this.gtbExpenseValue.BackColor = System.Drawing.Color.Transparent;
            this.gtbExpenseValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(135)))));
            this.gtbExpenseValue.BorderRadius = 5;
            this.gtbExpenseValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbExpenseValue.DefaultText = "";
            this.gtbExpenseValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbExpenseValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbExpenseValue.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.gtbExpenseValue.DisabledState.Parent = this.gtbExpenseValue;
            this.gtbExpenseValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.gtbExpenseValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.gtbExpenseValue.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbExpenseValue.FocusedState.Parent = this.gtbExpenseValue;
            this.gtbExpenseValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbExpenseValue.ForeColor = System.Drawing.Color.White;
            this.gtbExpenseValue.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbExpenseValue.HoverState.Parent = this.gtbExpenseValue;
            this.gtbExpenseValue.Location = new System.Drawing.Point(601, 32);
            this.gtbExpenseValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbExpenseValue.Name = "gtbExpenseValue";
            this.gtbExpenseValue.PasswordChar = '\0';
            this.gtbExpenseValue.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(184)))));
            this.gtbExpenseValue.PlaceholderText = "0,00";
            this.gtbExpenseValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gtbExpenseValue.SelectedText = "";
            this.gtbExpenseValue.ShadowDecoration.Parent = this.gtbExpenseValue;
            this.gtbExpenseValue.Size = new System.Drawing.Size(166, 36);
            this.gtbExpenseValue.TabIndex = 8;
            this.gtbExpenseValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gtbExpenseValue.TextChanged += new System.EventHandler(this.gtbExpenseValue_TextChanged);
            this.gtbExpenseValue.Click += new System.EventHandler(this.gtbExpenseValue_Click);
            this.gtbExpenseValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtbExpenseValue_KeyPress);
            this.gtbExpenseValue.Leave += new System.EventHandler(this.gtbExpenseValue_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(145, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrição da Despesa";
            // 
            // lbExpenseValue
            // 
            this.lbExpenseValue.AutoSize = true;
            this.lbExpenseValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpenseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.lbExpenseValue.Location = new System.Drawing.Point(598, 14);
            this.lbExpenseValue.Name = "lbExpenseValue";
            this.lbExpenseValue.Size = new System.Drawing.Size(91, 13);
            this.lbExpenseValue.TabIndex = 15;
            this.lbExpenseValue.Text = "Valor (R$/Mês) *";
            // 
            // gtbExpenseName
            // 
            this.gtbExpenseName.BackColor = System.Drawing.Color.Transparent;
            this.gtbExpenseName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(135)))));
            this.gtbExpenseName.BorderRadius = 5;
            this.gtbExpenseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbExpenseName.DefaultText = "";
            this.gtbExpenseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.gtbExpenseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gtbExpenseName.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.gtbExpenseName.DisabledState.Parent = this.gtbExpenseName;
            this.gtbExpenseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.gtbExpenseName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.gtbExpenseName.FocusedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.gtbExpenseName.FocusedState.Parent = this.gtbExpenseName;
            this.gtbExpenseName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbExpenseName.ForeColor = System.Drawing.Color.White;
            this.gtbExpenseName.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.gtbExpenseName.HoverState.Parent = this.gtbExpenseName;
            this.gtbExpenseName.Location = new System.Drawing.Point(148, 32);
            this.gtbExpenseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbExpenseName.Name = "gtbExpenseName";
            this.gtbExpenseName.PasswordChar = '\0';
            this.gtbExpenseName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(184)))));
            this.gtbExpenseName.PlaceholderText = "";
            this.gtbExpenseName.SelectedText = "";
            this.gtbExpenseName.ShadowDecoration.Parent = this.gtbExpenseName;
            this.gtbExpenseName.Size = new System.Drawing.Size(432, 36);
            this.gtbExpenseName.TabIndex = 7;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.panelActions.Controls.Add(this.gbtRefresh);
            this.panelActions.Controls.Add(this.gbtCancel);
            this.panelActions.Controls.Add(this.gbtSave);
            this.panelActions.Controls.Add(this.gbtEdit);
            this.panelActions.Controls.Add(this.gbtAdd);
            this.panelActions.Controls.Add(this.gbtDelete);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 330);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1005, 45);
            this.panelActions.TabIndex = 32;
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
            this.gbtCancel.Location = new System.Drawing.Point(584, 8);
            this.gbtCancel.Name = "gbtCancel";
            this.gbtCancel.ShadowDecoration.Parent = this.gbtCancel;
            this.gbtCancel.Size = new System.Drawing.Size(96, 29);
            this.gbtCancel.TabIndex = 5;
            this.gbtCancel.Text = "Cancelar";
            this.gbtCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtCancel.Click += new System.EventHandler(this.gbtCancel_Click);
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
            this.gbtSave.Location = new System.Drawing.Point(482, 8);
            this.gbtSave.Name = "gbtSave";
            this.gbtSave.ShadowDecoration.Parent = this.gbtSave;
            this.gbtSave.Size = new System.Drawing.Size(96, 29);
            this.gbtSave.TabIndex = 4;
            this.gbtSave.Text = "Salvar";
            this.gbtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtSave.Click += new System.EventHandler(this.gbtSave_Click);
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
            this.gbtEdit.Location = new System.Drawing.Point(113, 8);
            this.gbtEdit.Name = "gbtEdit";
            this.gbtEdit.ShadowDecoration.Parent = this.gbtEdit;
            this.gbtEdit.Size = new System.Drawing.Size(96, 29);
            this.gbtEdit.TabIndex = 2;
            this.gbtEdit.Text = "Editar";
            this.gbtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtEdit.Click += new System.EventHandler(this.gbtEdit_Click);
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
            this.gbtAdd.Location = new System.Drawing.Point(11, 8);
            this.gbtAdd.Name = "gbtAdd";
            this.gbtAdd.ShadowDecoration.Parent = this.gbtAdd;
            this.gbtAdd.Size = new System.Drawing.Size(96, 29);
            this.gbtAdd.TabIndex = 1;
            this.gbtAdd.Text = "Incluir";
            this.gbtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtAdd.Click += new System.EventHandler(this.gbtAdd_Click);
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
            this.gbtDelete.Location = new System.Drawing.Point(215, 8);
            this.gbtDelete.Name = "gbtDelete";
            this.gbtDelete.ShadowDecoration.Parent = this.gbtDelete;
            this.gbtDelete.Size = new System.Drawing.Size(96, 29);
            this.gbtDelete.TabIndex = 3;
            this.gbtDelete.Text = "Excluir";
            this.gbtDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtDelete.Click += new System.EventHandler(this.gbtDelete_Click);
            // 
            // panelRecInfo
            // 
            this.panelRecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelRecInfo.Controls.Add(this.panelRecInfoLog);
            this.panelRecInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecInfo.Location = new System.Drawing.Point(0, 300);
            this.panelRecInfo.Name = "panelRecInfo";
            this.panelRecInfo.Size = new System.Drawing.Size(1005, 30);
            this.panelRecInfo.TabIndex = 31;
            // 
            // panelRecInfoLog
            // 
            this.panelRecInfoLog.Controls.Add(this.gchipRecLog);
            this.panelRecInfoLog.Controls.Add(this.gchipTitle);
            this.panelRecInfoLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecInfoLog.Location = new System.Drawing.Point(0, 0);
            this.panelRecInfoLog.Name = "panelRecInfoLog";
            this.panelRecInfoLog.Size = new System.Drawing.Size(1005, 30);
            this.panelRecInfoLog.TabIndex = 21;
            // 
            // gchipRecLog
            // 
            this.gchipRecLog.BorderRadius = 6;
            this.gchipRecLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchipRecLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.gchipRecLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gchipRecLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipRecLog.Location = new System.Drawing.Point(121, 0);
            this.gchipRecLog.Name = "gchipRecLog";
            this.gchipRecLog.ShadowDecoration.Parent = this.gchipRecLog;
            this.gchipRecLog.Size = new System.Drawing.Size(884, 30);
            this.gchipRecLog.TabIndex = 22;
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
            this.gchipTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gchipTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.gchipTitle.Location = new System.Drawing.Point(0, 0);
            this.gchipTitle.Name = "gchipTitle";
            this.gchipTitle.ShadowDecoration.Parent = this.gchipTitle;
            this.gchipTitle.Size = new System.Drawing.Size(121, 30);
            this.gchipTitle.TabIndex = 21;
            this.gchipTitle.TabStop = false;
            this.gchipTitle.Text = "Última Atualização";
            this.gchipTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.gDataGrid);
            this.panelGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridView.Location = new System.Drawing.Point(0, 0);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.Size = new System.Drawing.Size(1005, 300);
            this.panelGridView.TabIndex = 28;
            // 
            // gDataGrid
            // 
            this.gDataGrid.AllowUserToAddRows = false;
            this.gDataGrid.AllowUserToDeleteRows = false;
            this.gDataGrid.AllowUserToOrderColumns = true;
            this.gDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.gDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.gDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.gDataGrid.Size = new System.Drawing.Size(1005, 300);
            this.gDataGrid.TabIndex = 22;
            this.gDataGrid.TabStop = false;
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
            this.gDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            this.gDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDataGrid_CellClick);
            this.gDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDataGrid_CellValueChanged);
            this.gDataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.gDataGrid_CurrentCellDirtyStateChanged);
            this.gDataGrid.SelectionChanged += new System.EventHandler(this.gDataGrid_SelectionChanged);
            this.gDataGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.gDataGrid_SortCompare);
            this.gDataGrid.Sorted += new System.EventHandler(this.gDataGrid_Sorted);
            this.gDataGrid.SizeChanged += new System.EventHandler(this.gDataGrid_SizeChanged);
            // 
            // gbtRefresh
            // 
            this.gbtRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtRefresh.BorderColor = System.Drawing.Color.SlateGray;
            this.gbtRefresh.BorderRadius = 6;
            this.gbtRefresh.BorderThickness = 1;
            this.gbtRefresh.CheckedState.Parent = this.gbtRefresh;
            this.gbtRefresh.CustomImages.Parent = this.gbtRefresh;
            this.gbtRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.gbtRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtRefresh.ForeColor = System.Drawing.Color.White;
            this.gbtRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.gbtRefresh.HoverState.Parent = this.gbtRefresh;
            this.gbtRefresh.Image = global::_3DFarmManager.Properties.Resources.icons8_refresh_30_ORANGE;
            this.gbtRefresh.Location = new System.Drawing.Point(963, 8);
            this.gbtRefresh.Name = "gbtRefresh";
            this.gbtRefresh.ShadowDecoration.Parent = this.gbtRefresh;
            this.gbtRefresh.Size = new System.Drawing.Size(29, 29);
            this.gbtRefresh.TabIndex = 9;
            this.gbtRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtRefresh.Click += new System.EventHandler(this.gbtRefresh_Click);
            // 
            // UC_ExpensesFixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelExpensesFixed);
            this.Name = "UC_ExpensesFixed";
            this.Size = new System.Drawing.Size(1005, 646);
            this.panelExpensesFixed.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelRecInfo.ResumeLayout(false);
            this.panelRecInfoLog.ResumeLayout(false);
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExpensesFixed;
        private Guna.UI2.WinForms.Guna2Button gbtCancel;
        private Guna.UI2.WinForms.Guna2Button gbtSave;
        private Guna.UI2.WinForms.Guna2Button gbtDelete;
        private Guna.UI2.WinForms.Guna2Button gbtEdit;
        private Guna.UI2.WinForms.Guna2Button gbtAdd;
        private System.Windows.Forms.Panel panelGridView;
        private Guna.UI2.WinForms.Guna2DataGridView gDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox gtbExpenseName;
        private System.Windows.Forms.Label lbExpenseName;
        private Guna.UI2.WinForms.Guna2TextBox gtbDescription;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gtbExpenseValue;
        private System.Windows.Forms.Label lbExpenseValue;
        private Guna.UI2.WinForms.Guna2TextBox gtbExpenseTotal;
        private System.Windows.Forms.Label lbExpenseTotal;
        private System.Windows.Forms.Panel panelRecInfo;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2TextBox gtbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panelRecInfoLog;
        private Guna.UI2.WinForms.Guna2Chip gchipTitle;
        private Guna.UI2.WinForms.Guna2Chip gchipRecLog;
        private Guna.UI2.WinForms.Guna2Button gbtRefresh;
    }
}
