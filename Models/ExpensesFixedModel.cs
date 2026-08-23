using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Models
{
    public class ExpensesFixedModel : AuditableEntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ExpenseValue { get; set; }
    }
}
