using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Model
{
    public class BrandModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
