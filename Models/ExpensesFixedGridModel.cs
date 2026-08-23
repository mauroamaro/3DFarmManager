using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Models
{
    public class ExpensesFixedGridModel : GridModelBase
    {
        public string Name { get; set; }
        public decimal ExpenseValue { get; set; }
    }
}
