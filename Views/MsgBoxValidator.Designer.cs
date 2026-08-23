namespace _3DFarmManager
{
    partial class MsgBoxValidator
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
            this.gpanelMsgBoxValidator = new Guna.UI2.WinForms.Guna2Panel();
            this.panelErrors = new System.Windows.Forms.Panel();
            this.lboxErrors = new System.Windows.Forms.ListBox();
            this.gbtBack = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gpanelMsgBoxValidator.SuspendLayout();
            this.panelErrors.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpanelMsgBoxValidator
            // 
            this.gpanelMsgBoxValidator.BackColor = System.Drawing.Color.Silver;
            this.gpanelMsgBoxValidator.BorderColor = System.Drawing.Color.MediumPurple;
            this.gpanelMsgBoxValidator.BorderThickness = 1;
            this.gpanelMsgBoxValidator.Controls.Add(this.panelErrors);
            this.gpanelMsgBoxValidator.Controls.Add(this.gbtBack);
            this.gpanelMsgBoxValidator.Controls.Add(this.panelTitle);
            this.gpanelMsgBoxValidator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpanelMsgBoxValidator.Location = new System.Drawing.Point(0, 0);
            this.gpanelMsgBoxValidator.Name = "gpanelMsgBoxValidator";
            this.gpanelMsgBoxValidator.ShadowDecoration.Parent = this.gpanelMsgBoxValidator;
            this.gpanelMsgBoxValidator.Size = new System.Drawing.Size(714, 412);
            this.gpanelMsgBoxValidator.TabIndex = 0;
            // 
            // panelErrors
            // 
            this.panelErrors.Controls.Add(this.lboxErrors);
            this.panelErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelErrors.Location = new System.Drawing.Point(0, 36);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(714, 306);
            this.panelErrors.TabIndex = 5;
            // 
            // lboxErrors
            // 
            this.lboxErrors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lboxErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxErrors.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxErrors.FormattingEnabled = true;
            this.lboxErrors.ItemHeight = 19;
            this.lboxErrors.Location = new System.Drawing.Point(0, 0);
            this.lboxErrors.Name = "lboxErrors";
            this.lboxErrors.Size = new System.Drawing.Size(714, 306);
            this.lboxErrors.TabIndex = 4;
            this.lboxErrors.SelectedIndexChanged += new System.EventHandler(this.lboxErrors_SelectedIndexChanged);
            // 
            // gbtBack
            // 
            this.gbtBack.BorderRadius = 5;
            this.gbtBack.CheckedState.Parent = this.gbtBack;
            this.gbtBack.CustomImages.Parent = this.gbtBack;
            this.gbtBack.FillColor = System.Drawing.Color.Teal;
            this.gbtBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtBack.ForeColor = System.Drawing.Color.White;
            this.gbtBack.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.gbtBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.gbtBack.HoverState.Parent = this.gbtBack;
            this.gbtBack.Location = new System.Drawing.Point(309, 357);
            this.gbtBack.Name = "gbtBack";
            this.gbtBack.ShadowDecoration.Parent = this.gbtBack;
            this.gbtBack.Size = new System.Drawing.Size(96, 39);
            this.gbtBack.TabIndex = 3;
            this.gbtBack.Text = "Voltar";
            this.gbtBack.Click += new System.EventHandler(this.gbtBack_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DimGray;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(714, 36);
            this.panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATENÇÃO: Corrija as seguintes inconsistências";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelTitle;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this;
            // 
            // MsgBoxValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(714, 412);
            this.Controls.Add(this.gpanelMsgBoxValidator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBoxValidator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBoxValidator";
            this.gpanelMsgBoxValidator.ResumeLayout(false);
            this.panelErrors.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gpanelMsgBoxValidator;
        private System.Windows.Forms.Panel panelTitle;
        private Guna.UI2.WinForms.Guna2Button gbtBack;
        private System.Windows.Forms.Panel panelErrors;
        private System.Windows.Forms.ListBox lboxErrors;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}