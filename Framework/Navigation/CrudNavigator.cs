using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;
using System;

///Crud Navigator V1.0.0

namespace _3DFarmManager.Framework.Navigation
{
    /// <summary>
    /// Responsável pela navegação entre os registros exibidos no Grid.
    /// Não possui qualquer conhecimento sobre Repository, Controller,
    /// Cache ou WinForms.
    /// </summary>
    public class CrudNavigator<TGridModel>
        where TGridModel : GridModelBase
    {
        private readonly IGridViewAdapter<TGridModel> _adapter;

        #region Events

        public event EventHandler<long?> CurrentRecordChanged;

        #endregion

        #region Constructor

        public CrudNavigator(
            IGridViewAdapter<TGridModel> adapter)
        {
            _adapter = adapter ??
                throw new ArgumentNullException(nameof(adapter));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Quantidade de registros carregados.
        /// </summary>
        public int Count
        {
            get
            {
                return _adapter.Count;
            }
        }

        /// <summary>
        /// Indica se existem registros.
        /// </summary>
        public bool HasItems
        {
            get
            {
                return Count > 0;
            }
        }

        /// <summary>
        /// Posição atual.
        /// </summary>
        public int Position
        {
            get
            {
                return _adapter.Position;
            }
        }

        /// <summary>
        /// Registro atualmente selecionado.
        /// </summary>
        public TGridModel CurrentItem
        {
            get
            {
                return _adapter.CurrentItem;
            }
        }

        /// <summary>
        /// Id do registro atualmente selecionado.
        /// </summary>
        public long? CurrentId
        {
            get
            {
                return _adapter.CurrentId;
            }
        }

        #endregion

        #region Navigation

        public bool NavigateFirst()
        {
            if (!HasItems)
                return false;

            _adapter.Position = 0;

            RaiseCurrentRecordChanged();

            return true;
        }

        public bool NavigateLast()
        {
            if (!HasItems)
                return false;

            _adapter.Position = Count - 1;

            RaiseCurrentRecordChanged();

            return true;
        }

        public bool NavigateNext()
        {
            if (!HasItems)
                return false;

            if (_adapter.Position >= Count - 1)
                return false;

            _adapter.Position++;

            RaiseCurrentRecordChanged();

            return true;
        }

        public bool NavigatePrevious()
        {
            if (!HasItems)
                return false;

            if (_adapter.Position <= 0)
                return false;

            _adapter.Position--;

            RaiseCurrentRecordChanged();

            return true;
        }

        public bool NavigateTo(long id)
        {
            int index = _adapter.FindIndex(id);

            if (index < 0)
                return false;

            _adapter.Position = index;

            RaiseCurrentRecordChanged();

            return true;
        }

        #endregion

        #region Notifications

        /// <summary>
        /// Dispara novamente o evento do registro atual.
        /// Muito útil após um Refresh do Grid.
        /// </summary>
        public void NotifyCurrent()
        {
            RaiseCurrentRecordChanged();
        }

        protected virtual void RaiseCurrentRecordChanged()
        {
            CurrentRecordChanged?.Invoke(
                this,
                CurrentId);
        }

        #endregion

        #region Grid

        /// <summary>
        /// Remove todos os registros do Grid.
        /// </summary>
        public void Clear()
        {
            _adapter.Clear();

            RaiseCurrentRecordChanged();
        }

        #endregion
    }
}
