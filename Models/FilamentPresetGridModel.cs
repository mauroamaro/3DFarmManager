using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class FilamentPresetGridModel : GridModelBase
    {
        public string Name { get; set; }
        public int NozzleTemp { get; set; }
        public int PlateTemp { get; set; }
        public decimal FlowRate { get; set; }
    }
}
