using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Framework.Interfaces
{
    /// <summary>
    /// Representa uma View utilizada pelo Framework de CRUD.
    /// </summary>
    public interface ICrudView<TModel>
        where TModel : EntityBase
    {
        /// <summary>
        /// Lê os dados da interface e monta um Model.
        /// </summary>
        TModel ReadModel();

        /// <summary>
        /// Preenche a interface utilizando um Model.
        /// </summary>
        void FillModel(TModel model);

        /// <summary>
        /// Limpa todos os controles.
        /// </summary>
        void ClearView();

        /// <summary>
        /// Habilita ou desabilita a edição.
        /// </summary>
        void SetEditing(bool editing);
    }
}
