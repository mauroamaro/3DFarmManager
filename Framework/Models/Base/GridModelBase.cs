using _3DFarmManager.Framework.Domain;

namespace _3DFarmManager.Framework.Models
{
    /// <summary>
    /// Classe base para os modelos utilizados nos DataGridViews.
    /// </summary>
    public abstract class GridModelBase : IEntity
    {
        /// <summary>
        /// Identificador do registro.
        /// </summary>
        public long Id { get; set; }
    }
}
