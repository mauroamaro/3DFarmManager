using Guna.UI2.WinForms;

namespace _3DFarmManager.Framework.Helpers
{
    public static class GTextBoxExtensions
    {
        public static decimal DecimalValue(
            this Guna2TextBox textBox)
        {
            return DecimalParser.Parse(textBox.Text);
        }
    }
}
