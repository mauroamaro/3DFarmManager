using _3DFarmManager.Framework.Adapters;
using _3DFarmManager.Framework.Controllers;
using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;
using _3DFarmManager.Framework.Navigation;
using _3DFarmManager.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DFarmManager.Framework.Views.Base
{
    public abstract class CrudUserControlBase
        <
            TModel,
            TGridModel,
            TRepository
        > : CrudViewBase<TModel>

        where TModel : AuditableEntityBase, new()

        where TGridModel : GridModelBase

        where TRepository :
        ICrudRepository<TModel>,
        ICrudGridRepository<TGridModel>
        
        {
        #region Infrastructure

        protected readonly TRepository Repository;

        protected readonly CrudController<TModel> Controller;

        protected readonly CrudNavigator<TGridModel> Navigator;

        protected readonly DataGridViewAdapter<TGridModel> GridAdapter;

        protected readonly ICrudCache<TModel> Cache;

        #endregion
   
        protected CrudUserControlBase(
        TRepository repository,
        ICrudCache<TModel> cache,
        DataGridViewAdapter<TGridModel> gridAdapter)
        {
            Repository = repository;

            Cache = cache;

            GridAdapter = gridAdapter;

            Controller =
                new CrudController<TModel>(
                    repository,
                    cache);

            Navigator =
                new CrudNavigator<TGridModel>(
                    gridAdapter);

            InitializeFramework();
        }

        private void InitializeFramework()
        {
            Navigator.CurrentRecordChanged +=
                Navigator_CurrentRecordChanged;
        }

        public virtual void BeginCreate()
        {
            Controller.SetMode(CrudMode.Create);

            ClearView();

            SetEditing(true);

            OnModeChanged();
        }

        public virtual void BeginEdit()
        {
            if (!Controller.HasCurrent)
                return;

            Controller.SetMode(CrudMode.Edit);

            SetEditing(true);

            OnModeChanged();
        }

        public virtual async Task SaveAsync()
        {
            TModel model =
                ReadModel();

            IList<string> errors =
                Validate(model);

            if (errors.Any())
            {
                ShowValidation(errors);

                return;
            }

            CrudOperationResult result;

            switch (Controller.Mode)
            {
                case CrudMode.Create:

                    result =
                        await Controller.InsertAsync(model);

                    break;

                case CrudMode.Edit:

                    result =
                        await Controller.UpdateAsync(model);

                    break;

                default:

                    return;
            }

            await ReloadGridAsync(result.Id);

            OnAfterSave(result);
        }

        public virtual async Task DeleteAsync()
        {
            if (!Controller.HasCurrentId)
                return;

            CrudOperationResult result =
                await Controller.DeleteAsync(
                    Controller.CurrentId.Value,
                    GlobalVar.AppUserID);

            await ReloadGridAsync();

            OnAfterDelete(result);
        }

        public virtual async Task CancelAsync()
        {
            if (!Controller.HasCurrentId)
            {
                ClearView();

                return;
            }

            await LoadCurrentAsync(
                Controller.CurrentId.Value);
        }

        protected virtual async Task ReloadGridAsync(long? selectedId = null)
        {
            IList<TGridModel> list =
                await Repository.GetGridDataAsync();

            GridAdapter.Load(list);

            if (selectedId.HasValue)
            {
                if (!Navigator.NavigateTo(selectedId.Value))
                {
                    Navigator.NavigateFirst();
                }
            }
            else
            {
                Navigator.NavigateFirst();
            }
        }

        private async void Navigator_CurrentRecordChanged(
            object sender,
            long? id)
        {
            if (!id.HasValue)
            {
                ClearView();
                return;
            }

            await LoadCurrentAsync(id.Value);
        }

        protected virtual async Task LoadCurrentAsync(long id)
        {
            TModel model =
                await Controller.LoadAsync(id);

            FillModel(model);

            OnCurrentChanged(model);
        }

        protected abstract IList<string>
            Validate(TModel model);

        protected abstract void
            ShowValidation(IList<string> errors);

        protected virtual void
            OnAfterSave(CrudOperationResult result)
            {
            }

        protected virtual void
            OnAfterDelete(CrudOperationResult result)
            {
            }

        protected virtual void
            OnCurrentChanged(TModel model)
            {
            }

        protected virtual void
            OnModeChanged()
            {
            }

        protected async Task RefreshViewAsync()
        {
            if (Controller.Mode == CrudMode.Create ||
                Controller.Mode == CrudMode.Edit)
            {
                if (!DialogService.Confirm(
                    "Existem alterações não salvas.\n\nDeseja continuar?"))
                {
                    return;
                }
            }

            long? id = Controller.CurrentId;

            await Controller.RefreshAsync();

            await ReloadGridAsync(id);
        }

    }

}
