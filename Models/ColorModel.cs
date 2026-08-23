using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class ColorModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public string ColorHexCode { get; set; }
        public string ColorRgbCode { get; set; }
    }
}
