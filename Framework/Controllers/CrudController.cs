using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;
using _3DFarmManager.Framework.Models.Base;
using System;
using System.Threading.Tasks;

namespace _3DFarmManager.Framework.Controllers
{
    public class CrudController<TModel>
        where TModel : EntityBase
    {
        private readonly ICrudRepository<TModel> _repository;
        private readonly ICrudCache<TModel> _cache;
        private readonly CrudState _state;

        private TModel _currentModel;

        public CrudMode Mode => _state.Mode;

        //public long? CurrentId => _state.CurrentId;
        private long? _currentId;

        public long? CurrentId => _currentId;

        public bool IsDirty => _state.IsDirty;

        public TModel CurrentModel => _currentModel;

        public event EventHandler<long?> CurrentIdChanged;
        public event EventHandler<TModel> CurrentModelChanged;
        public event EventHandler<CrudMode> ModeChanged;

        public CrudController(
            ICrudRepository<TModel> repository,
            ICrudCache<TModel> cache)
        {
            _repository = repository
                ?? throw new ArgumentNullException(nameof(repository));

            _cache = cache
                ?? throw new ArgumentNullException(nameof(cache));

            _state = new CrudState();
        }

        #region Mode

        public void SetMode(CrudMode mode)
        {
            if (_state.Mode == mode)
                return;

            _state.SetMode(mode);

            OnModeChanged(mode);
        }

        protected virtual void OnModeChanged(CrudMode mode)
        {
            ModeChanged?.Invoke(this, mode);
        }

        public TModel Current
        {
            get
            {
                return CurrentModel;
            }
        }
        #endregion

        #region Current Record

        private void SetCurrentId(long? id)
        {
            if (_currentId == id)
                return;

            if (id.HasValue && id.Value <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            _currentId = id;

            OnCurrentIdChanged(id);
        }
        protected virtual void OnCurrentIdChanged(long? id)
        {
            CurrentIdChanged?.Invoke(this, id);
        }

        public void SetCurrent(TModel model)
        {
            _currentModel = model;

            SetCurrentId(model?.Id);

            ClearDirty();

            SetMode(
                model == null
                    ? CrudMode.Empty
                    : CrudMode.Read);

            OnCurrentModelChanged(model);
        }

        public void ClearCurrent()
        {
            _currentModel = null;

            _currentId = null;

            ClearDirty();

            SetMode(CrudMode.Empty);

            OnCurrentIdChanged(null);

            OnCurrentModelChanged(null);
        }
        public void Reset()
        {
            _currentModel = null;

            _currentId = null;

            ClearDirty();

            _state.SetMode(CrudMode.Empty);

            OnCurrentIdChanged(null);

            OnCurrentModelChanged(null);

            OnModeChanged(CrudMode.Empty);
        }
        public bool HasCurrent
        {
            get
            {
                return CurrentModel != null;
            }
        }

        public bool HasCurrentId
        {
            get
            {
                return CurrentId.HasValue;
            }
        }

        protected virtual void OnCurrentModelChanged(TModel model)
        {
            CurrentModelChanged?.Invoke(this, model);
        }

        #endregion

        #region Load

        public async Task<TModel> LoadAsync(long id)
        {
            TModel model;

            if (_cache.Contains(id))
            {
                model = _cache.Get(id);
            }
            else
            {
                model = await _repository.GetByIdAsync(id);

                if (model != null)
                    _cache.Save(model);
            }

            SetCurrent(model);

            ClearDirty();

            return CurrentModel;
        }

        #endregion

        #region Insert

        public async Task<CrudOperationResult> InsertAsync(TModel model)
        {
            PrepareAudit(model, CrudTypes.Insert);

            TModel entity = await _repository.InsertAsync(model);

            if (entity == null)
            {
                return CrudOperationResult.Fail(
                    "O repositório não retornou a entidade criada.");
            }

            Commit(entity);

            return CrudOperationResult.Ok(
                "Registro criado.",
                entity.Id);
        }

        private void PrepareAudit(TModel model, string crudType)
        {
            AuditableEntityBase audit = model as AuditableEntityBase;

            if (audit == null)
                return;

            audit.LogCrudType = crudType;
            audit.LogCrudDate = DateTime.Now;
            audit.LogCrudUserId = GlobalVar.AppUserID;
        }

        public static class CrudTypes
        {
            public const string Insert = "1";

            public const string Update = "2";

            public const string Delete = "3";
        }

        #endregion

        #region Update

        public async Task<CrudOperationResult> UpdateAsync(TModel model)
        {
            PrepareAudit(model, CrudTypes.Update);

            TModel entity = await _repository.UpdateAsync(model);

            if (entity == null)
            {
                return CrudOperationResult.Fail(
                    "O repositório não retornou a entidade atualizada.");
            }

            Commit(entity);

            return CrudOperationResult.Ok(
                "Registro atualizado.",
                entity.Id);
        }

        #endregion

        #region Delete

        public async Task<CrudOperationResult> DeleteAsync(long id, long userId)
        {
            TModel model = await _repository.GetByIdAsync(id);

            PrepareAudit(model, CrudTypes.Delete);

            await _repository.DeleteAsync(id, userId);

            Remove(id);

            return CrudOperationResult.Ok(
                "Registro excluído.");
        }

        private void Commit(TModel model)
        {
            _cache.Save(model);

            SetCurrent(model);

            ClearDirty();
        }

        private void Remove(long id)
        {
            _cache.Remove(id);

            if (CurrentId == id)
                ClearCurrent();

            ClearDirty();
        }

        #endregion

        #region Dirty State

        public void MarkDirty()
        {
            _state.MarkDirty();
        }

        public void ClearDirty()
        {
            _state.ClearDirty();
        }

        public Task RefreshAsync()
        {
            _cache.Clear();
            return Task.CompletedTask;
        }

        public void RefreshCache()
        {
            _cache.Clear();
        }

        #endregion
    }
}