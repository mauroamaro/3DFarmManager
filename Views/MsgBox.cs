using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public partial class MsgBox : Form
    {
        private Color _danger = Color.FromArgb(246, 99, 88); // Red color for danger
        private Color _warning = Color.FromArgb(255, 169, 43); // Yellow color for warning
        private Color _success = Color.FromArgb(46, 184, 134); // Green color for success
        private Color _info = Color.FromArgb(70, 167, 245); // Blue color for info

        public MsgBox(string message, string type, string options)
        {
            InitializeComponent();

            switch (type.ToLower())
            {
                case "danger":
                    panelTitle.BackColor = _danger; // Set the title panel color to danger
                    lbTitle.Text = "ATENÇÃO";
                    gpictTitle.Image = Properties.Resources.icons8_radioactive_64;
                    break;
                case "warning":
                    panelTitle.BackColor = _warning; // Set the title panel color to warning
                    lbTitle.Text = "AVISO";
                    gpictTitle.Image = Properties.Resources.icons8_alert_64;
                    break;
                case "success":
                    panelTitle.BackColor = _success; // Set the title panel color to success
                    lbTitle.Text = "OPERAÇÃO REALIZADA";
                    gpictTitle.Image = Properties.Resources.icons8_success_64;
                    break;
                case "info":
                    panelTitle.BackColor = _info; // Set the title panel color to info
                    lbTitle.Text = "INFORMAÇÃO";
                    gpictTitle.Image = Properties.Resources.icons8_information_64;
                    break;
                default:
                    panelTitle.BackColor = _info; // Set the title panel color to info
                    lbTitle.Text = "INFORMAÇÃO";
                    gpictTitle.Image = Properties.Resources.icons8_information_64;
                    break;
            }

            switch (options)
            {
                case "ok":
                    gbtOk.Location = new Point((this.ClientSize.Width - gbtOk.Width) / 2, gbtOk.Location.Y); // Center the OK button
                    gbtCancel.Visible = false; // Hide the Cancel button
                    break;
                case "cancel":
                    gbtCancel.Location = new Point((this.ClientSize.Width - gbtCancel.Width) / 2, gbtCancel.Location.Y); // Center the Cancel button
                    gbtOk.Visible = false; // Hide the OK button
                    break;
                case "YesNo":
                    gbtYes.Location = new Point(12, 141); // Position the OK button to the left
                    gbtNo.Location = new Point(303, 141); // Position the Cancel button to the right
                    gbtNo.Visible = true; // Show the Cancel button
                    gbtYes.Visible = true; // Show the OK button
                    break;
                default:
                    gbtOk.Location = new Point(12,141); // Position the OK button to the left
                    gbtCancel.Location = new Point(303, 141); // Position the OK button to the left
                    gbtCancel.Visible = true; // Show the Cancel button
                    gbtOk.Visible = true; // Show the OK button
                    break;
            }

            lbMsg.Text = message;
        }
        public string clicked;

        private void MsgBox_Load(object sender, EventArgs e)
        {

        }

        private void gbtOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void gbtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
