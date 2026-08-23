
namespace _3DFarmManager.Framework.Core
{
    public class CrudContext<TModel>
        where TModel : class
    {
        public CrudState State { get; }

        public TModel CurrentModel { get; set; }

        public CrudContext()
        {
            State = new CrudState();
        }
    }
}
