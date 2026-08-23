using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Models.Base;

namespace _3DFarmManager.Framework.Services
{
    public class CrudViewStateService
    {
        public CrudViewState GetState(
            CrudMode mode,
            bool hasRecords)
        {
            switch (mode)
            {
                case CrudMode.Read:

                    return new CrudViewState
                    {
                        CanAdd = true,
                        CanEdit = hasRecords,
                        CanDelete = hasRecords,
                        CanSave = false,
                        CanCancel = false,
                        CanExit = true,
                        CanRefresh = true
                    };

                case CrudMode.Create:

                case CrudMode.Edit:

                    return new CrudViewState
                    {
                        CanAdd = false,
                        CanEdit = false,
                        CanDelete = false,
                        CanSave = true,
                        CanCancel = true,
                        CanExit = false,
                        CanRefresh = false
                    };

                default:

                    return new CrudViewState
                    {
                        CanAdd = !hasRecords,
                        CanEdit = false,
                        CanDelete = false,
                        CanSave = false,
                        CanCancel = false,
                        CanExit = true,
                        CanRefresh = true
                    };
            }
        }
    }
}
