namespace _3DFarmManager.Framework.Domain
{
    /// <summary>
    /// Representa uma entidade persistida no banco de dados.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Identificador único da entidade.
        /// </summary>
        long Id { get; set; }
    }
}
