using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    public class FilamentTypeValidator
    {

        public static List<string> Validate(FilamentTypeModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome da cor obrigatório.");
            
                return errors;

        }

    }
}
