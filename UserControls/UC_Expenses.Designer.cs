namespace _3DFarmManager
{
    partial class UC_Expenses
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictUCTitle = new System.Windows.Forms.PictureBox();
            this.glbUCTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gtbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gcbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.gbtFixedAssets = new Guna.UI2.WinForms.Guna2Button();
            this.gbtFixedExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUCTitle)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(1090, 50);
            this.panelTitle.TabIndex = 2;
            // 
            // pictUCTitle
            // 
            this.pictUCTitle.Image = global::_3DFarmManager.Properties.Resources.icons8_expense_40;
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
            this.glbUCTitle.Size = new System.Drawing.Size(104, 31);
            this.glbUCTitle.TabIndex = 5;
            this.glbUCTitle.Text = "Despesas";
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
            this.gtbSearch.Location = new System.Drawing.Point(867, 7);
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
            this.gcbSearch.Location = new System.Drawing.Point(641, 7);
            this.gcbSearch.Name = "gcbSearch";
            this.gcbSearch.ShadowDecoration.Parent = this.gcbSearch;
            this.gcbSearch.Size = new System.Drawing.Size(210, 36);
            this.gcbSearch.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.panelMenu.Controls.Add(this.gbtFixedAssets);
            this.panelMenu.Controls.Add(this.gbtFixedExpenses);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1090, 54);
            this.panelMenu.TabIndex = 3;
            // 
            // gbtFixedAssets
            // 
            this.gbtFixedAssets.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtFixedAssets.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFixedAssets.CheckedState.Parent = this.gbtFixedAssets;
            this.gbtFixedAssets.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtFixedAssets.CustomImages.Parent = this.gbtFixedAssets;
            this.gbtFixedAssets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFixedAssets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtFixedAssets.ForeColor = System.Drawing.Color.White;
            this.gbtFixedAssets.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtFixedAssets.HoverState.Parent = this.gbtFixedAssets;
            this.gbtFixedAssets.Location = new System.Drawing.Point(151, 6);
            this.gbtFixedAssets.Name = "gbtFixedAssets";
            this.gbtFixedAssets.ShadowDecoration.Parent = this.gbtFixedAssets;
            this.gbtFixedAssets.Size = new System.Drawing.Size(120, 42);
            this.gbtFixedAssets.TabIndex = 3;
            this.gbtFixedAssets.Text = "Imobilizado";
            this.gbtFixedAssets.Click += new System.EventHandler(this.gbtFixedAssets_Click);
            // 
            // gbtFixedExpenses
            // 
            this.gbtFixedExpenses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtFixedExpenses.Checked = true;
            this.gbtFixedExpenses.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFixedExpenses.CheckedState.Parent = this.gbtFixedExpenses;
            this.gbtFixedExpenses.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtFixedExpenses.CustomImages.Parent = this.gbtFixedExpenses;
            this.gbtFixedExpenses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFixedExpenses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtFixedExpenses.ForeColor = System.Drawing.Color.White;
            this.gbtFixedExpenses.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtFixedExpenses.HoverState.Parent = this.gbtFixedExpenses;
            this.gbtFixedExpenses.Location = new System.Drawing.Point(11, 6);
            this.gbtFixedExpenses.Name = "gbtFixedExpenses";
            this.gbtFixedExpenses.ShadowDecoration.Parent = this.gbtFixedExpenses;
            this.gbtFixedExpenses.Size = new System.Drawing.Size(120, 42);
            this.gbtFixedExpenses.TabIndex = 3;
            this.gbtFixedExpenses.Text = "Fixas";
            this.gbtFixedExpenses.Click += new System.EventHandler(this.gbtFixedExpenses_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 104);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1090, 467);
            this.panelContainer.TabIndex = 4;
            // 
            // UC_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.Name = "UC_Expenses";
            this.Size = new System.Drawing.Size(1090, 571);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUCTitle)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictUCTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel glbUCTitle;
        private Guna.UI2.WinForms.Guna2TextBox gtbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox gcbSearch;
        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button gbtFixedAssets;
        private Guna.UI2.WinForms.Guna2Button gbtFixedExpenses;
        private System.Windows.Forms.Panel panelContainer;
    }
}
