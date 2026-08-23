using _3DFarmManager.Framework.Adapters;
using _3DFarmManager.Framework.Controllers;
using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Models.Base;
using _3DFarmManager.Framework.Navigation;
using _3DFarmManager.Framework.Services;
using _3DFarmManager.Framework.Helpers;
using _3DFarmManager.Models;
using _3DFarmManager.Repositories;
using _3DFarmManager.Services;
using _3DFarmManager.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager.UserControls
{
    public partial class UC_ExpensesFixed : UserControl
    {
        #region Infrastructure

        private ExpensesFixedRepository _repository;

        private ExpensesFixedCacheService _cache;

        private CrudController<ExpensesFixedModel> _controller;

        private DataGridViewAdapter<ExpensesFixedGridModel> _gridAdapter;

        private CrudNavigator<ExpensesFixedGridModel> _navigator;

        #endregion

        #region State

        private readonly Color _readOnlyTrueFillColor = Color.FromArgb(45, 48, 66);
        private readonly Color _readOnlyTrueBorderColor = Color.FromArgb(69, 72, 89);
        private readonly Color _readOnlyTrueForeColor = Color.FromArgb(219, 219, 219);
        private readonly Color _readOnlyTruePlaceHolderForeColor = Color.FromArgb(220, 220, 220);

        private readonly Color _editFillColor = Color.FromArgb(57, 68, 85);
        private readonly Color _editBorderColor = Color.FromArgb(91, 109, 135);
        private readonly Color _editForeColor = Color.FromArgb(255, 255, 255);
        private readonly Color _editPlaceHolderForeColor = Color.FromArgb(242, 221, 184);

        private readonly Color _disabledFillColor = Color.FromArgb(85, 88, 104);
        private readonly Color _disabledBorderColor = Color.FromArgb(69, 72, 89);
        private readonly Color _disabledForeColor = Color.FromArgb(219, 219, 219);
        private readonly Color _disabledPlaceHolderForeColor = Color.FromArgb(219, 219, 219);

        private readonly Color _enabledFillColor = Color.FromArgb(57, 68, 85);
        private readonly Color _enabledBorderColor = Color.FromArgb(91, 109, 135);
        private readonly Color _enabledForeColor = Color.FromArgb(255, 255, 255);
        private readonly Color _enabledPlaceHolderForeColor = Color.FromArgb(242, 221, 184);

        private readonly CrudViewStateService _viewStateService = new CrudViewStateService();

        //private DataGridViewRow _totalRow;

        #endregion

        #region Constructor
        public UC_ExpensesFixed()
        {
            InitializeComponent();

            InitializeFramework();

            //InitializeAppearance();

            InitializeGrid();

            WireEvents();

            _ = InitializeAsync();

            gtbExpenseValue.KeyPress += gtbExpenseValue_KeyPress;
            gtbExpenseValue.TextChanged += gtbExpenseValue_TextChanged;
            gtbExpenseValue.Leave += gtbExpenseValue_Leave;
        }

        #endregion

        #region Initialization

        private void InitializeFramework()
        {
            _repository = new ExpensesFixedRepository(GlobalVar.AppConnString);

            _cache = new ExpensesFixedCacheService();

            _controller = new CrudController<ExpensesFixedModel>(_repository, _cache);

            _gridAdapter = new DataGridViewAdapter<ExpensesFixedGridModel>(gDataGrid);

            _navigator = new CrudNavigator<ExpensesFixedGridModel>(_gridAdapter);
        }

        private void InitializeGrid()
        {
            ConfigureExpensesFixedGrid();
        }

        private void WireEvents()
        {
            _navigator.CurrentRecordChanged +=
                Navigator_CurrentRecordChanged;

            gDataGrid.SelectionChanged +=
                gDataGrid_SelectionChanged;
        }

        private async Task InitializeAsync()
        {
            await ReloadGridAsync();
        }

        private void RefreshViewState()
        {
            CrudViewState state =
                _viewStateService.GetState(
                    _controller.Mode,
                    _navigator.HasItems);

            ApplyViewState(state);
        }
        private void ApplyViewState(CrudViewState state)
        {
            gbtAdd.Enabled = state.CanAdd;
            gbtEdit.Enabled = state.CanEdit;
            gbtDelete.Enabled = state.CanDelete;
            gbtSave.Enabled = state.CanSave;
            gbtCancel.Enabled = state.CanCancel;
        }

        #endregion

        #region View

        private ExpensesFixedModel ReadModel()
        {
            ExpensesFixedModel model = _controller.Current ?? new ExpensesFixedModel();

            model.Name = gtbExpenseName.Text.Trim();
            model.Description = gtbDescription.Text.Trim();
            model.ExpenseValue = gtbExpenseValue.DecimalValue();

            return model;
        }

        private void FillModel(ExpensesFixedModel model)
        {
            if (model == null)
            {
                ClearView();
                return;
            }

            gtbId.Text = model.Id.ToString();
            gtbExpenseName.Text = model.Name;
            gtbDescription.Text = model.Description;
            gtbExpenseValue.Text = model.ExpenseValue.ToString("N2");
            gchipRecLog.Text = BuildAuditText(model);
        }

        private void ClearView()
        {
            gtbId.Clear();
            gtbExpenseName.Clear();
            gtbDescription.Clear();
            gtbExpenseValue.Text = "0,00";
            gchipRecLog.Text = string.Empty;
        }

        private static string BuildAuditText(ExpensesFixedModel model)
        {
            if (model == null)
                return String.Empty;

            return $"{model.LogCrudTypeDescription} | {model.LogCrudDate:dd/MM/yyyy HH:mm:ss} | {model.LogUserName}";
        }

        #endregion

        #region Grid

        private void ConfigureExpensesFixedGrid()
        {
            var dgv = gDataGrid;

            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Set the column header border style to single
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersHeight = 45;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID #",
                DataPropertyName = "Id",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "name",
                HeaderText = "Despesa",
                DataPropertyName = "Name",
                Width = 400
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "expensevalue",
                HeaderText = "Valor (R$/Mês)",
                DataPropertyName = "ExpenseValue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

        }

        private async Task ReloadGridAsync(long? selectedId = null)
        {
            _controller.RefreshCache();

            IList<ExpensesFixedGridModel> items =
                await _repository.GetGridDataAsync();

            _gridAdapter.Load(items);

            if (selectedId.HasValue)
            {
                if (!_navigator.NavigateTo(selectedId.Value))
                {
                    if (items.Count == 0)
                    {
                        _controller.SetMode(CrudMode.Empty);

                        ClearView();

                        SetActionMode(CrudMode.Empty);

                        RefreshViewState();

                        return;
                    }
                    _navigator.NavigateFirst();

                    ChangeMode(CrudMode.Read);
                }
            }
            else
            {
                if (items.Count == 0)
                {
                    ClearView();

                    ChangeMode(CrudMode.Empty);

                    return;
                }
                _navigator.NavigateFirst();

                ChangeMode(CrudMode.Read);
            }

        }

        private void ChangeMode(CrudMode mode)
        {
            _controller.SetMode(mode);

            SetActionMode(mode);

            RefreshViewState();
        }


        /*
        private void UpdateTotalRow()
        {
            // 1. Disable user row addition line to keep the total row at the very bottom
            gDataGrid.AllowUserToAddRows = false;

            decimal totalAmount = 0;

            // 2. Loop through rows, skipping the total row itself
            foreach (DataGridViewRow row in gDataGrid.Rows)
            {
                if (row == totalRow) continue; // Skip the total row

                if (row.Cells["ExpenseValue"].Value != null)
                {
                    decimal.TryParse(row.Cells["ExpenseValue"].Value.ToString(), out decimal val);
                    totalAmount += val;
                }
            }

            // 3. Create the total row if it doesn't exist yet
            if (totalRow == null)
            {
                int index = gDataGrid.Rows.Add();
                totalRow = gDataGrid.Rows[index];

                // Tag it and style it
                totalRow.Tag = "TotalRow";
                totalRow.ReadOnly = true;
                totalRow.DefaultCellStyle.Font = new Font(gDataGrid.Font, FontStyle.Bold);
                totalRow.DefaultCellStyle.BackColor = Color.LightGray;
                totalRow.Cells["ItemName"].Value = "Total:";
            }

            // 4. Update the actual calculated value
            totalRow.Cells["ExpenseValue"].Value = totalAmount;
        }
        */

        #endregion

        private async void Navigator_CurrentRecordChanged(object sender, long? id)
        {
            if (!id.HasValue)
            {
                ClearView();

                return;
            }

            await LoadCurrentAsync(id.Value);
        }

        private async Task LoadCurrentAsync(long id)
        {
            ExpensesFixedModel model = await _controller.LoadAsync(id);

            if (model == null)
            {
                ClearView();
                return;
            }

            FillModel(model);
        }

        #region CRUD

        private void BeginCreate()
        {
            _controller.SetMode(CrudMode.Create);

            ClearView();

            SetActionMode(CrudMode.Create);

            RefreshViewState();
        }

        private void BeginEdit()
        {
            if (!_controller.HasCurrent)
                return;

            _controller.SetMode(CrudMode.Edit);

            SetActionMode(CrudMode.Edit);

            RefreshViewState();
        }

        private async Task SaveAsync()
        {
            ExpensesFixedModel model = ReadModel();

            List<string> errors = ExpensesFixedValidator.Validate(model);

            if (errors.Any())
            {
                new MsgBoxValidator(errors)
                    .ShowDialog();

                return;
            }

            CrudOperationResult result;

            switch (_controller.Mode)
            {
                case CrudMode.Create:

                    result =
                        await _controller.InsertAsync(model);

                    break;

                case CrudMode.Edit:

                    result =
                        await _controller.UpdateAsync(model);

                    break;

                default:

                    return;
            }

            if (!result.Success)
            {
                DialogService.Error(result.Message);

                return;
            }

            await ReloadGridAsync(result.Id);

            ChangeMode(CrudMode.Read);
        }

        private async Task DeleteAsync()
        {
            if (!_controller.HasCurrentId)
                return;

            CrudOperationResult result =
                await _controller.DeleteAsync(
                    _controller.CurrentId.Value,
                    GlobalVar.AppUserID);

            if (!result.Success)
            {
                DialogService.Error(result.Message);

                return;
            }

            await ReloadGridAsync();
        }

        private async Task CancelAsync()
        {
            if (!_controller.HasCurrentId)
            {
                ClearView();

                SetActionMode(CrudMode.Empty);

                return;
            }

            await LoadCurrentAsync(_controller.CurrentId.Value);

            ChangeMode(CrudMode.Read);
        }

        #endregion

        // Change the event handler to async Task to fix CS4033

        #region UI

        private void ConfigureButtons(CrudMode mode)
        {
            bool editing =
                mode == CrudMode.Create ||
                mode == CrudMode.Edit;

            gbtAdd.Enabled = !editing;
            gbtEdit.Enabled = !editing && _controller.HasCurrent;
            gbtDelete.Enabled = !editing && _controller.HasCurrent;
            gbtSave.Enabled = editing;
            gbtCancel.Enabled = editing;
        }

        private void ConfigureEditors(CrudMode mode)
        {
            bool editing =
                mode == CrudMode.Create ||
                mode == CrudMode.Edit;

            bool readOnly =
                mode == CrudMode.Read ||
                mode == CrudMode.Empty;

            // ID e ExpenseTotal sempre somente leitura
            gtbId.ReadOnly = true;
            gtbExpenseTotal.ReadOnly = true;

            gtbExpenseName.ReadOnly = readOnly;
            gtbDescription.ReadOnly = readOnly;
            gtbExpenseValue.ReadOnly = readOnly;
        }

        private void ConfigureFocus(CrudMode mode)
        {
            if (mode == CrudMode.Create || mode == CrudMode.Edit)
            {
                gtbExpenseName.Focus();
            }
            else
            {
                gDataGrid.Focus();
            }
        }

        private void SetActionMode(CrudMode mode)
        {
            //ConfigureButtons(mode);

            ConfigureEditors(mode);

            ConfigureFocus(mode);

            SetFieldColors(mode);
        }
        
        private void SetFieldColors(CrudMode mode)
        {
            switch (mode) 
            {
                case CrudMode.Read:
                    gtbId.FillColor = _readOnlyTrueFillColor;
                    gtbId.BorderColor = _readOnlyTrueBorderColor;
                    gtbId.ForeColor = _readOnlyTrueForeColor;
                    gtbId.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbExpenseName.FillColor = _readOnlyTrueFillColor;
                    gtbExpenseName.BorderColor = _readOnlyTrueBorderColor;
                    gtbExpenseName.ForeColor = _readOnlyTrueForeColor;
                    gtbExpenseName.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbDescription.FillColor = _readOnlyTrueFillColor;
                    gtbDescription.BorderColor = _readOnlyTrueBorderColor;
                    gtbDescription.ForeColor = _readOnlyTrueForeColor;
                    gtbDescription.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbExpenseValue.FillColor = _readOnlyTrueFillColor;
                    gtbExpenseValue.BorderColor = _readOnlyTrueBorderColor;
                    gtbExpenseValue.ForeColor = _readOnlyTrueForeColor;
                    gtbExpenseValue.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbExpenseTotal.FillColor = _readOnlyTrueFillColor;
                    gtbExpenseTotal.BorderColor = _readOnlyTrueBorderColor;
                    gtbExpenseTotal.ForeColor = _readOnlyTrueForeColor;
                    gtbExpenseTotal.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    break;
                case CrudMode.Edit:
                    gtbId.FillColor = _readOnlyTrueFillColor;
                    gtbId.BorderColor = _readOnlyTrueBorderColor;
                    gtbId.ForeColor = _readOnlyTrueForeColor;
                    gtbId.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbExpenseName.FillColor = _editFillColor;
                    gtbExpenseName.BorderColor = _editBorderColor;
                    gtbExpenseName.ForeColor = _editForeColor;
                    gtbExpenseName.PlaceholderForeColor = _editPlaceHolderForeColor;
                    gtbDescription.FillColor = _editFillColor;
                    gtbDescription.BorderColor = _editBorderColor;
                    gtbDescription.ForeColor = _editForeColor;
                    gtbDescription.PlaceholderForeColor = _editPlaceHolderForeColor;
                    gtbExpenseValue.FillColor = _editFillColor;
                    gtbExpenseValue.BorderColor = _editBorderColor;
                    gtbExpenseValue.ForeColor = _editForeColor;
                    gtbExpenseValue.PlaceholderForeColor = _editPlaceHolderForeColor;
                    gtbExpenseTotal.FillColor = _readOnlyTrueFillColor;
                    gtbExpenseTotal.BorderColor = _readOnlyTrueBorderColor;
                    gtbExpenseTotal.ForeColor = _readOnlyTrueForeColor;
                    gtbExpenseTotal.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    break;
            }
        }

        #endregion

        #region Navigation

        #endregion

        #region Events

        private void gDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        }

        private void gDataGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
        }

        private void gDataGrid_Sorted(object sender, EventArgs e)
        {
        }
        private void gtbExpenseValue_Click(object sender, EventArgs e)
        {
            gtbExpenseValue.SelectAll();
        }
        private void gtbExpenseValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            // Permite controle (Backspace etc)
            if (char.IsControl(e.KeyChar))
                return;

            // Permite números
            if (char.IsDigit(e.KeyChar))
                return;

            // Permite apenas uma vírgula
            if (e.KeyChar == ',')
            {
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }

                return;
            }

        }
        private void gtbExpenseValue_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (decimal.TryParse(
                txt.Text,
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out decimal value))
            {
                txt.Text = value.ToString("N2");
            }
            else
            {
                txt.Text = "0,00";
            }

        }
        private void gtbExpenseValue_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            string texto = txt.Text;

            // Remove caracteres que não sejam números ou vírgula
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^0-9,]", "");

            // Permite somente uma vírgula
            int primeiraVirgula = texto.IndexOf(',');

            if (primeiraVirgula >= 0)
            {
                texto = texto.Substring(0, primeiraVirgula + 1) +
                        texto.Substring(primeiraVirgula + 1).Replace(",", "");

                // Limita para 2 casas decimais
                string parteInteira = texto.Substring(0, primeiraVirgula);
                string parteDecimal = texto.Substring(primeiraVirgula + 1);

                if (parteDecimal.Length > 2)
                {
                    parteDecimal = parteDecimal.Substring(0, 2);
                }

                texto = parteInteira + "," + parteDecimal;
            }

            // Atualiza somente se houve alteração
            if (txt.Text != texto)
            {
                txt.Text = texto;
                txt.SelectionStart = txt.Text.Length;
            }

        }

        private async void gbtSave_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private async void gbtCancel_Click(object sender, EventArgs e)
        {
            await CancelAsync();
        }

        private void gbtAdd_Click(object sender, EventArgs e)
        {
            BeginCreate();
        }

        private void gbtEdit_Click(object sender, EventArgs e)
        {
            BeginEdit();
        }

        private async void gbtDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                await DeleteAsync();
            }
        }

        private void gchipRecLog_Click(object sender, EventArgs e)
        {
        }

        private void gDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _navigator.NotifyCurrent();
        }

        private bool ConfirmDelete()
        {
            return DialogService.Confirm("Deseja realmente excluir este registro?");
        }

        #endregion

        private void gDataGrid_SizeChanged(object sender, EventArgs e)
        {

        }

        private void gDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (_controller.Mode != CrudMode.Read)
                return;

            _navigator.NotifyCurrent();
        }

        private async void gbtRefresh_Click(object sender, EventArgs e)
        {
            await ReloadGridAsync(_controller.CurrentId);

            ChangeMode(CrudMode.Read);
        }
    }
}
