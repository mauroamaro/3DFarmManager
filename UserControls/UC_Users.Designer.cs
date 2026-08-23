namespace _3DFarmManager
{
    partial class UC_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelDataGrid.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.Wheat;
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(951, 221);
            this.panelDataGrid.TabIndex = 0;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActions.Location = new System.Drawing.Point(0, 221);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(134, 378);
            this.panelActions.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(134, 221);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(817, 378);
            this.panelData.TabIndex = 2;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LightGray;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(134, 542);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(817, 57);
            this.panelInfo.TabIndex = 3;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelDataGrid);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(951, 599);
            this.panelDataGrid.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelInfo;
    }
}
