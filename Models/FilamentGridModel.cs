using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class FilamentGridModel : GridModelBase
    {
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ColorName { get; set; }
        public string UnitShortName { get; set; }
        public string PresetName { get; set; }
        public string FilamentTypeName { get; set; }
        public decimal FilamentCost { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal RecommNozzleTemp { get; set; }
        public decimal RecommPlateTemp { get; set; }
        public decimal RecommFlowRate { get; set; }

    }
}
