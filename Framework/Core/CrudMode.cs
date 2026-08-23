namespace _3DFarmManager.Framework.Core
{
    /// <summary>
    /// Representa o estado atual da tela de um CRUD.
    /// </summary>
    public enum CrudMode
    {
        /// <summary>
        /// Não existe registro selecionado.
        /// </summary>
        Empty = 0,

        /// <summary>
        /// Registro carregado apenas para consulta.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Inclusão de um novo registro.
        /// </summary>
        Create = 2,

        /// <summary>
        /// Edição de um registro existente.
        /// </summary>
        Edit = 3
    }
}
