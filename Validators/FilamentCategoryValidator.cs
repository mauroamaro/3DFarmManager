using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    internal class FilamentCategoryValidator
    {
        public static List<string> Validate(FilamentCategoryModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome da unidade obrigatório.");

            return errors;
        }
    }
}
