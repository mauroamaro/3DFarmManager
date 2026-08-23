using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class FilamentSubCategoryModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public long CategoryId { get; set; }
    }
}
