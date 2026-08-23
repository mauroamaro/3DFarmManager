using System.Web.UI.WebControls;

namespace _3DFarmManager.Framework.Helpers
{
    public static class TextBoxExtensions
    {
        public static decimal DecimalValue(
            this TextBox textBox)
        {
            return DecimalParser.Parse(textBox.Text);
        }
    }
}
