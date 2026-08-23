using _3DFarmManager.Framework.Domain;

namespace _3DFarmManager.Framework.Models
{
    /// <summary>
    /// Classe base para todas as entidades persistidas.
    /// </summary>
    public abstract class EntityBase : IEntity
    {
        /// <summary>
        /// Identificador da entidade.
        /// </summary>
        public long Id { get; set; }
    }
}
