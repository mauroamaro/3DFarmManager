using _3DFarmManager.Framework.Models;

namespace _3DFarmManager.Framework.Interfaces
{
    /// <summary>
    /// Define as operações de cache das entidades.
    /// </summary>
    /// <typeparam name="TModel">Tipo da entidade.</typeparam>
    public interface ICrudCache<TModel>
        where TModel : EntityBase
    {
        /// <summary>
        /// Verifica se uma entidade está em cache.
        /// </summary>
        bool Contains(long id);

        /// <summary>
        /// Obtém uma entidade do cache.
        /// </summary>
        TModel Get(long id);

        /// <summary>
        /// Salva ou atualiza uma entidade no cache.
        /// </summary>
        void Save(TModel model);

        /// <summary>
        /// Remove uma entidade do cache.
        /// </summary>
        void Remove(long id);

        /// <summary>
        /// Limpa completamente o cache.
        /// </summary>
        void Clear();
    }
}
