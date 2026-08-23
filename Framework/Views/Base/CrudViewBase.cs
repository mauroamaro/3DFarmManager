using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Framework.Views.Base
{
    /// <summary>
    /// Classe base para todas as Views do Framework.
    /// Define apenas o contrato de interação com o Model.
    /// </summary>
    public abstract class CrudViewBase<TModel> : ICrudView<TModel>
        where TModel : EntityBase
    {
        public abstract TModel ReadModel();

        public abstract void FillModel(TModel model);

        public abstract void ClearView();

        public abstract void SetEditing(bool editing);
    }
}
