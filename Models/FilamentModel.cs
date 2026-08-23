using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class FilamentModel : AuditableEntityBase
    {

        public string Name { get; set; }
        public long BrandId { get; set; }
        public long CategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public long ColorId { get; set; }
        public long UnitId { get; set; }
        public long PresetId { get; set; }
        public long FilamentTypeId { get; set; }
        public decimal FilamentCost { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal RecommNozzleTemp { get; set; }
        public decimal RecommPlateTemp { get; set; }
        public decimal RecommFlowRate { get; set; }

    }
}
