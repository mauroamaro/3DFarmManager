using _3DFarmManager.Model;
using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    public class ExpensesFixedValidator
    {
        public static List<string> Validate(ExpensesFixedModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Denominação da despesa obrigatório.");

            return errors;
        }

    }
}
