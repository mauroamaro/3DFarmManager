using _3DFarmManager.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Models
{
    public class _3DPrinterGridModel : GridModelBase
    {
        public string Name { get; set; }
        public string BrandName { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime? StartOperationDate { get; set; }
        public decimal UsefullLife { get; set; }
        public decimal MaintenanceCost { get; set; }
        public decimal AnnualMaintenanceCost { get; set; }
        public decimal ElectricityConsumption { get; set; }
        public decimal DepreciationValue { get; set; }
    }
}
