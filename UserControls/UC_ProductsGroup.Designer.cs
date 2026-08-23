namespace _3DFarmManager
{
    partial class UC_ProductsGroup
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
            this.gbtPacking = new Guna.UI2.WinForms.Guna2Button();
            this.gbtMaterials = new Guna.UI2.WinForms.Guna2Button();
            this.gbtFilaments = new Guna.UI2.WinForms.Guna2Button();
            this.gbtParts = new Guna.UI2.WinForms.Guna2Button();
            this.gbtProducts = new Guna.UI2.WinForms.Guna2Button();
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
            this.panelTitle.Size = new System.Drawing.Size(1097, 50);
            this.panelTitle.TabIndex = 1;
            // 
            // pictUCTitle
            // 
            this.pictUCTitle.Image = global::_3DFarmManager.Properties.Resources.icons8_qr_40_GREEN;
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
            this.glbUCTitle.Size = new System.Drawing.Size(96, 31);
            this.glbUCTitle.TabIndex = 5;
            this.glbUCTitle.Text = "Produtos";
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
            this.gtbSearch.Location = new System.Drawing.Point(874, 7);
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
            this.gcbSearch.Location = new System.Drawing.Point(648, 7);
            this.gcbSearch.Name = "gcbSearch";
            this.gcbSearch.ShadowDecoration.Parent = this.gcbSearch;
            this.gcbSearch.Size = new System.Drawing.Size(210, 36);
            this.gcbSearch.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.panelMenu.Controls.Add(this.gbtPacking);
            this.panelMenu.Controls.Add(this.gbtMaterials);
            this.panelMenu.Controls.Add(this.gbtFilaments);
            this.panelMenu.Controls.Add(this.gbtParts);
            this.panelMenu.Controls.Add(this.gbtProducts);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1097, 54);
            this.panelMenu.TabIndex = 2;
            // 
            // gbtPacking
            // 
            this.gbtPacking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtPacking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtPacking.CheckedState.Parent = this.gbtPacking;
            this.gbtPacking.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtPacking.CustomImages.Parent = this.gbtPacking;
            this.gbtPacking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtPacking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtPacking.ForeColor = System.Drawing.Color.White;
            this.gbtPacking.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtPacking.HoverState.Parent = this.gbtPacking;
            this.gbtPacking.Location = new System.Drawing.Point(571, 6);
            this.gbtPacking.Name = "gbtPacking";
            this.gbtPacking.ShadowDecoration.Parent = this.gbtPacking;
            this.gbtPacking.Size = new System.Drawing.Size(120, 42);
            this.gbtPacking.TabIndex = 3;
            this.gbtPacking.Text = "Embalagens";
            this.gbtPacking.Click += new System.EventHandler(this.gbtPacking_Click);
            // 
            // gbtMaterials
            // 
            this.gbtMaterials.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtMaterials.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtMaterials.CheckedState.Parent = this.gbtMaterials;
            this.gbtMaterials.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtMaterials.CustomImages.Parent = this.gbtMaterials;
            this.gbtMaterials.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtMaterials.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtMaterials.ForeColor = System.Drawing.Color.White;
            this.gbtMaterials.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtMaterials.HoverState.Parent = this.gbtMaterials;
            this.gbtMaterials.Location = new System.Drawing.Point(431, 6);
            this.gbtMaterials.Name = "gbtMaterials";
            this.gbtMaterials.ShadowDecoration.Parent = this.gbtMaterials;
            this.gbtMaterials.Size = new System.Drawing.Size(120, 42);
            this.gbtMaterials.TabIndex = 3;
            this.gbtMaterials.Text = "Insumos";
            this.gbtMaterials.Click += new System.EventHandler(this.gbtMaterials_Click);
            // 
            // gbtFilaments
            // 
            this.gbtFilaments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtFilaments.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFilaments.CheckedState.Parent = this.gbtFilaments;
            this.gbtFilaments.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtFilaments.CustomImages.Parent = this.gbtFilaments;
            this.gbtFilaments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtFilaments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtFilaments.ForeColor = System.Drawing.Color.White;
            this.gbtFilaments.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtFilaments.HoverState.Parent = this.gbtFilaments;
            this.gbtFilaments.Location = new System.Drawing.Point(291, 6);
            this.gbtFilaments.Name = "gbtFilaments";
            this.gbtFilaments.ShadowDecoration.Parent = this.gbtFilaments;
            this.gbtFilaments.Size = new System.Drawing.Size(120, 42);
            this.gbtFilaments.TabIndex = 3;
            this.gbtFilaments.Text = "Filamentos";
            this.gbtFilaments.Click += new System.EventHandler(this.gbtFilaments_Click);
            // 
            // gbtParts
            // 
            this.gbtParts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtParts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtParts.CheckedState.Parent = this.gbtParts;
            this.gbtParts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtParts.CustomImages.Parent = this.gbtParts;
            this.gbtParts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtParts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtParts.ForeColor = System.Drawing.Color.White;
            this.gbtParts.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtParts.HoverState.Parent = this.gbtParts;
            this.gbtParts.Location = new System.Drawing.Point(151, 6);
            this.gbtParts.Name = "gbtParts";
            this.gbtParts.ShadowDecoration.Parent = this.gbtParts;
            this.gbtParts.Size = new System.Drawing.Size(120, 42);
            this.gbtParts.TabIndex = 3;
            this.gbtParts.Text = "Peças";
            this.gbtParts.Click += new System.EventHandler(this.gbtParts_Click);
            // 
            // gbtProducts
            // 
            this.gbtProducts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtProducts.Checked = true;
            this.gbtProducts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtProducts.CheckedState.Parent = this.gbtProducts;
            this.gbtProducts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtProducts.CustomImages.Parent = this.gbtProducts;
            this.gbtProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.gbtProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtProducts.ForeColor = System.Drawing.Color.White;
            this.gbtProducts.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(199)))));
            this.gbtProducts.HoverState.Parent = this.gbtProducts;
            this.gbtProducts.Location = new System.Drawing.Point(11, 6);
            this.gbtProducts.Name = "gbtProducts";
            this.gbtProducts.ShadowDecoration.Parent = this.gbtProducts;
            this.gbtProducts.Size = new System.Drawing.Size(120, 42);
            this.gbtProducts.TabIndex = 3;
            this.gbtProducts.Text = "Produtos";
            this.gbtProducts.Click += new System.EventHandler(this.gbtProducts_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 104);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1097, 495);
            this.panelContainer.TabIndex = 3;
            // 
            // UC_ProductsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.Name = "UC_ProductsGroup";
            this.Size = new System.Drawing.Size(1097, 599);
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
        private Guna.UI2.WinForms.Guna2Button gbtPacking;
        private Guna.UI2.WinForms.Guna2Button gbtMaterials;
        private Guna.UI2.WinForms.Guna2Button gbtFilaments;
        private Guna.UI2.WinForms.Guna2Button gbtParts;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button gbtProducts;
    }
}
