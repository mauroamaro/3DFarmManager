using _3DFarmManager.Framework.Models;
using System.Threading.Tasks;

namespace _3DFarmManager.Framework.Interfaces
{
    /// <summary>
    /// Define as operações de persistência de uma entidade.
    /// </summary>
    /// <typeparam name="TModel">Tipo da entidade.</typeparam>
    public interface ICrudRepository<TModel>
        where TModel : EntityBase
    {
        /// <summary>
        /// Obtém uma entidade pelo seu identificador.
        /// </summary>
        Task<TModel> GetByIdAsync(long id);

        /// <summary>
        /// Insere uma nova entidade.
        /// </summary>
        Task<TModel> InsertAsync(TModel model);

        /// <summary>
        /// Atualiza uma entidade existente.
        /// </summary>
        Task<TModel> UpdateAsync(TModel model);

        /// <summary>
        /// Remove uma entidade.
        /// </summary>
        Task DeleteAsync(long id, long userId);
    }
}
