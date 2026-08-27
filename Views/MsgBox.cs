using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public partial class MsgBox : Form
    {
        private Color _danger = Color.FromArgb(198, 0, 0); // Red color for danger
        private Color _warning = Color.FromArgb(219, 116, 116); // Yellow color for warning
        private Color _success = Color.FromArgb(31, 127, 32); // Green color for success
        private Color _info = Color.FromArgb(43, 104, 150); // Blue color for info

        public MsgBox(string message, string type, string options, string title="")
        {
            InitializeComponent();

            switch (type.ToLower())
            {
                case "danger":
                    panelTitle.BackColor = _danger; // Set the title panel color to danger
                    lbTitle.Text = string.IsNullOrEmpty(title) ? "ATENÇÃO" : title;
                    gpictTitle.Image = Properties.Resources.icons8_radioactive_30_OUTLINE_WHITE;
                    break;
                case "warning":
                    panelTitle.BackColor = _warning; // Set the title panel color to warning
                    lbTitle.Text = string.IsNullOrEmpty(title) ? "AVISO" : title;
                    gpictTitle.Image = Properties.Resources.icons8_alert_30_OUTLINE_WHITE;
                    break;
                case "success":
                    panelTitle.BackColor = _success; // Set the title panel color to success
                    lbTitle.Text = string.IsNullOrEmpty(title) ? "OPERAÇÃO REALIZADA" : title;
                    gpictTitle.Image = Properties.Resources.icons8_success_30_OUTLINE_WHITE;
                    break;
                case "info":
                    panelTitle.BackColor = _info; // Set the title panel color to info
                    lbTitle.Text = string.IsNullOrEmpty(title) ? "INFORMAÇÃO" : title;
                    gpictTitle.Image = Properties.Resources.icons8_information_30_OUTLINE_WHITE;
                    break;
                default:
                    panelTitle.BackColor = _info; // Set the title panel color to info
                    lbTitle.Text = string.IsNullOrEmpty(title) ? "INFORMAÇÃO" : title;
                    gpictTitle.Image = Properties.Resources.icons8_information_30_OUTLINE_WHITE;
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
                    gbtYes.Location = new Point(354, 173); // Position the OK button to the left
                    gbtNo.Location = new Point(12, 173); // Position the Cancel button to the right
                    gbtNo.Visible = true; // Show the Cancel button
                    gbtYes.Visible = true; // Show the OK button
                    break;
                default:
                    gbtOk.Location = new Point(354, 173); // Position the OK button to the left
                    gbtCancel.Location = new Point(12, 173); // Position the OK button to the left
                    gbtCancel.Visible = true; // Show the Cancel button
                    gbtOk.Visible = true; // Show the OK button
                    break;
            }

            lbMsg.Text = message;
        }
        public string clicked;

        private void MsgBox_Load(object sender, EventArgs e)
        {
            gbtCancel.Focus();
            gbtNo.Focus();
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
