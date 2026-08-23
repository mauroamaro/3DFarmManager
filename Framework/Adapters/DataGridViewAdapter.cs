using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Framework.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3DFarmManager.Framework.Adapters
{
    /// <summary>
    /// Adapter responsável por encapsular as operações de navegação
    /// e sincronização entre o CrudNavigator e o DataGridView.
    /// </summary>
    /// <typeparam name="TGridModel"></typeparam>
    public class DataGridViewAdapter<TGridModel> :
        IGridViewAdapter<TGridModel>
        where TGridModel : GridModelBase
    {
        private readonly DataGridView _grid;

        public DataGridViewAdapter(DataGridView grid)
        {
            _grid = grid;
        }

        #region Properties

        public int Count
        {
            get
            {
                return _grid.Rows.Count;
            }
        }

        public int Position
        {
            get
            {
                if (_grid.CurrentRow == null)
                    return -1;

                return _grid.CurrentRow.Index;
            }
            set
            {
                if (_grid.Rows.Count == 0)
                    return;

                if (value < 0)
                    value = 0;

                if (value >= _grid.Rows.Count)
                    value = _grid.Rows.Count - 1;

                _grid.ClearSelection();

                DataGridViewRow row = _grid.Rows[value];

                row.Selected = true;

                if (row.Cells.Count > 0)
                    _grid.CurrentCell = row.Cells[0];

                if (value >= 0)
                    _grid.FirstDisplayedScrollingRowIndex = value;
            }
        }

        public TGridModel CurrentItem
        {
            get
            {
                if (_grid.CurrentRow?.DataBoundItem is TGridModel item)
                    return item;

                return null;
            }
        }

        public long? CurrentId
        {
            get
            {
                return CurrentItem?.Id;
            }
        }

        #endregion

        #region Public Methods

        public void Load(IList<TGridModel> items)
        {
            _grid.SuspendLayout();

            try
            {
                _grid.DataSource = null;
                _grid.DataSource = items;

                if (_grid.Rows.Count > 0)
                {
                    Position = 0;
                }
            }
            finally
            {
                _grid.ResumeLayout();
            }
        }

        public void RefreshBindings()
        {
            _grid.Refresh();

            SynchronizeSelection();
        }

        public void Clear()
        {
            _grid.DataSource = null;
            _grid.ClearSelection();
        }

        public int FindIndex(long id)
        {
            for (int i = 0; i < _grid.Rows.Count; i++)
            {
                if (_grid.Rows[i].DataBoundItem is TGridModel item)
                {
                    if (item.Id == id)
                        return i;
                }
            }

            return -1;
        }

        #endregion

        #region Private Methods

        private void SynchronizeSelection()
        {
            if (_grid.Rows.Count == 0)
                return;

            int position = Position;

            if (position < 0)
                return;

            if (position >= _grid.Rows.Count)
                return;

            _grid.ClearSelection();

            DataGridViewRow row = _grid.Rows[position];

            row.Selected = true;

            if (row.Cells.Count > 0)
                _grid.CurrentCell = row.Cells[0];

            _grid.FirstDisplayedScrollingRowIndex = position;
        }

        #endregion
    }
}