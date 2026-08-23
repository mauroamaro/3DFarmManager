using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    public class FilamentValidator
    {
        public static List<string> Validate(FilamentModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome do filamento obrigatório.");

            if (model.BrandId <= 0)
                errors.Add("-> Marca do filamento obrigatória.");

            if (model.FilamentTypeId <= 0)
                errors.Add("-> Tipo do filamento obrigatório.");

            if (model.ColorId <= 0)
                errors.Add("-> Cor do filamento obrigatória.");

            if (model.UnitId <= 0)
                errors.Add("-> Unidade do filamento obrigatória.");

            if (model.CategoryId <= 0)
                errors.Add("-> Categoria do filamento obrigatória.");

            return errors;
        }

    }
}
