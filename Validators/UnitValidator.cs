using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    internal class UnitValidator
    {
        public static List<string> Validate(UnitModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome da unidade obrigatório.");

            if (string.IsNullOrWhiteSpace(model.ShortName))
                errors.Add("-> Sigla da unidade obrigatória.");

            return errors;

        }
    }
}
