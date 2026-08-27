namespace _3DFarmManager
{
    partial class MsgBox
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.gbtOk = new Guna.UI2.WinForms.Guna2Button();
            this.gbtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbtNo = new Guna.UI2.WinForms.Guna2Button();
            this.gbtYes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gpictTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTitle.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpictTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.gpictTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(462, 45);
            this.panelTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(60, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(213, 19);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "<< título da mensagem >>";
            // 
            // lbMsg
            // 
            this.lbMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.Black;
            this.lbMsg.Location = new System.Drawing.Point(12, 59);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(438, 98);
            this.lbMsg.TabIndex = 1;
            this.lbMsg.Text = "label1";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbtOk
            // 
            this.gbtOk.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtOk.BorderRadius = 5;
            this.gbtOk.BorderThickness = 2;
            this.gbtOk.CheckedState.Parent = this.gbtOk;
            this.gbtOk.CustomImages.Parent = this.gbtOk;
            this.gbtOk.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbtOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtOk.ForeColor = System.Drawing.Color.Black;
            this.gbtOk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.gbtOk.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbtOk.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.gbtOk.HoverState.Parent = this.gbtOk;
            this.gbtOk.Location = new System.Drawing.Point(252, 173);
            this.gbtOk.Name = "gbtOk";
            this.gbtOk.ShadowDecoration.Parent = this.gbtOk;
            this.gbtOk.Size = new System.Drawing.Size(96, 39);
            this.gbtOk.TabIndex = 2;
            this.gbtOk.Text = "Ok";
            this.gbtOk.Visible = false;
            this.gbtOk.Click += new System.EventHandler(this.gbtOk_Click);
            // 
            // gbtCancel
            // 
            this.gbtCancel.BorderRadius = 5;
            this.gbtCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbtCancel.BorderThickness = 1;
            this.gbtCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.gbtCancel.Checked = true;
            this.gbtCancel.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.gbtCancel.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.gbtCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.gbtCancel.CheckedState.ForeColor = System.Drawing.Color.White;
            this.gbtCancel.CheckedState.Parent = this.gbtCancel;
            this.gbtCancel.CustomBorderColor = System.Drawing.Color.White;
            this.gbtCancel.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.gbtCancel.CustomImages.Parent = this.gbtCancel;
            this.gbtCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.gbtCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtCancel.ForeColor = System.Drawing.Color.White;
            this.gbtCancel.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.gbtCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gbtCancel.HoverState.Parent = this.gbtCancel;
            this.gbtCancel.Location = new System.Drawing.Point(12, 173);
            this.gbtCancel.Name = "gbtCancel";
            this.gbtCancel.ShadowDecoration.Parent = this.gbtCancel;
            this.gbtCancel.Size = new System.Drawing.Size(96, 39);
            this.gbtCancel.TabIndex = 1;
            this.gbtCancel.Text = "Cancelar";
            this.gbtCancel.Visible = false;
            this.gbtCancel.Click += new System.EventHandler(this.gbtCancel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Panel1.Controls.Add(this.panelTitle);
            this.guna2Panel1.Controls.Add(this.gbtNo);
            this.guna2Panel1.Controls.Add(this.gbtCancel);
            this.guna2Panel1.Controls.Add(this.lbMsg);
            this.guna2Panel1.Controls.Add(this.gbtYes);
            this.guna2Panel1.Controls.Add(this.gbtOk);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(462, 224);
            this.guna2Panel1.TabIndex = 3;
            // 
            // gbtNo
            // 
            this.gbtNo.BorderRadius = 5;
            this.gbtNo.Checked = true;
            this.gbtNo.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.gbtNo.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.gbtNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.gbtNo.CheckedState.ForeColor = System.Drawing.Color.White;
            this.gbtNo.CheckedState.Parent = this.gbtNo;
            this.gbtNo.CustomBorderColor = System.Drawing.Color.Black;
            this.gbtNo.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.gbtNo.CustomImages.Parent = this.gbtNo;
            this.gbtNo.FillColor = System.Drawing.Color.Tan;
            this.gbtNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtNo.ForeColor = System.Drawing.Color.Black;
            this.gbtNo.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.gbtNo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gbtNo.HoverState.Parent = this.gbtNo;
            this.gbtNo.Location = new System.Drawing.Point(114, 173);
            this.gbtNo.Name = "gbtNo";
            this.gbtNo.ShadowDecoration.Parent = this.gbtNo;
            this.gbtNo.Size = new System.Drawing.Size(96, 39);
            this.gbtNo.TabIndex = 1;
            this.gbtNo.Text = "Não";
            this.gbtNo.Visible = false;
            this.gbtNo.Click += new System.EventHandler(this.gbtCancel_Click);
            // 
            // gbtYes
            // 
            this.gbtYes.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtYes.BorderRadius = 5;
            this.gbtYes.BorderThickness = 2;
            this.gbtYes.CheckedState.Parent = this.gbtYes;
            this.gbtYes.CustomImages.Parent = this.gbtYes;
            this.gbtYes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbtYes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtYes.ForeColor = System.Drawing.Color.Black;
            this.gbtYes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.gbtYes.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbtYes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.gbtYes.HoverState.Parent = this.gbtYes;
            this.gbtYes.Location = new System.Drawing.Point(354, 173);
            this.gbtYes.Name = "gbtYes";
            this.gbtYes.ShadowDecoration.Parent = this.gbtYes;
            this.gbtYes.Size = new System.Drawing.Size(96, 39);
            this.gbtYes.TabIndex = 2;
            this.gbtYes.Text = "Sim";
            this.gbtYes.Visible = false;
            this.gbtYes.Click += new System.EventHandler(this.gbtOk_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // gpictTitle
            // 
            this.gpictTitle.Image = global::_3DFarmManager.Properties.Resources.icons8_information_30_OUTLINE_WHITE;
            this.gpictTitle.Location = new System.Drawing.Point(12, 6);
            this.gpictTitle.Name = "gpictTitle";
            this.gpictTitle.ShadowDecoration.Parent = this.gpictTitle;
            this.gpictTitle.Size = new System.Drawing.Size(30, 30);
            this.gpictTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gpictTitle.TabIndex = 0;
            this.gpictTitle.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(462, 224);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpictTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbMsg;
        private Guna.UI2.WinForms.Guna2Button gbtOk;
        private Guna.UI2.WinForms.Guna2Button gbtCancel;
        private Guna.UI2.WinForms.Guna2PictureBox gpictTitle;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button gbtNo;
        private Guna.UI2.WinForms.Guna2Button gbtYes;
    }
}