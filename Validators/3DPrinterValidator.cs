using _3DFarmManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager.Validators
{
    public class _3DPrinterValidator
    {
        public static List<string> Validate(_3DPrinterModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome da impressora obrigatório.");

            if (model.BrandId <= 0)
                errors.Add("-> Marca da impressora obrigatória.");

            if (model.StartOperationDate < model.PurchaseDate)
                errors.Add(
                "-> Início de operação não pode ser menor que compra.");
            if (model.MaintenanceCost <= 0)
            {
                errors.Add("-> O custo estimado de manutenção mensal é obrigatório.");
                //gtbMaintenanceCost.Focus();
            }

            if (model.ElectricityConsumption <= 0)
            {
                errors.Add("-> O consumo elétrico deve ser informado.");
                //gtbElectricityConsumption.Focus();
            }

            if(model.Depreciation <= 0)
            {
                errors.Add("-> A depreciação deve ser informada.");
                //gtbDepreciation.Focus();
            }

            return errors;
        }
    }
}
