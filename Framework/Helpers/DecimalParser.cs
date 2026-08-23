using System.Globalization;

namespace _3DFarmManager.Framework.Helpers
{
    public static class DecimalParser
    {
        public static decimal Parse(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0m;

            return decimal.TryParse(
                text,
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out decimal value)
                    ? value
                    : 0m;
        }

        public static decimal Parse(string text, decimal defaultValue)
        {
            if (string.IsNullOrWhiteSpace(text))
                return defaultValue;

            return decimal.TryParse(
                text,
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out decimal value)
                    ? value
                    : defaultValue;
        }
    }
}
