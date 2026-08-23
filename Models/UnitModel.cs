using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class UnitModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
