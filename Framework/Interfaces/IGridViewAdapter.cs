using _3DFarmManager.Framework.Models;
using System.Collections.Generic;

namespace _3DFarmManager.Framework.Interfaces
{
    public interface IGridViewAdapter<TGridModel>
        where TGridModel : GridModelBase
    {
        int Count { get; }

        int Position { get; set; }

        TGridModel CurrentItem { get; }

        long? CurrentId { get; }

        void Load(IList<TGridModel> items);

        void RefreshBindings();

        void Clear();

        int FindIndex(long id);

    }
}
