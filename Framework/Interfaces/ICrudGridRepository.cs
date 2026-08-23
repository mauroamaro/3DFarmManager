using _3DFarmManager.Framework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _3DFarmManager.Framework.Interfaces
{
    /// <summary>
    /// Define as operações de leitura utilizadas pelo DataGridView.
    /// </summary>
    /// <typeparam name="TGridModel">Tipo utilizado na listagem.</typeparam>
    public interface ICrudGridRepository<TGridModel>
        where TGridModel : GridModelBase
    {
        /// <summary>
        /// Carrega os registros do Grid.
        /// </summary>
        Task<IList<TGridModel>> GetGridDataAsync();
    }
}
