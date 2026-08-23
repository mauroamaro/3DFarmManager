using System.Collections.Generic;

namespace _3DFarmManager.Framework.Interfaces
{
    public interface ICrudValidator<TModel>
    {
        List<string> Validate(TModel model);
    }
}
