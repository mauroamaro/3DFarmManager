using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class FilamentPresetModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public int NozzleTemp { get; set; }
        public int PlateTemp { get; set; }
        public decimal FlowRate { get; set; }
    }
}
