using _3DFarmManager.Framework.Adapters;
using _3DFarmManager.Framework.Controllers;
using _3DFarmManager.Framework.Navigation;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using _3DFarmManager.Repositories;
using _3DFarmManager.Services;
using _3DFarmManager.UserControls;
using _3DFarmManager.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager.UserControls
{
    public partial class UC_ExpensesFixed : UserControl
    {
        private readonly ExpensesFixedRepository _repository;

        private readonly ExpensesFixedCache _cache;

        private readonly CrudController<ExpensesFixedModel> _controller;

        private readonly DataGridViewAdapter<ExpensesFixedGridModel> _gridAdapter;

        private readonly CrudNavigator<ExpensesFixedGridModel> _navigator;

        private CancellationTokenSource _loadCts;

        private readonly BindingSource _bs = new BindingSource();

        private List<ExpensesFixedGridModel> _gridData = new List<ExpensesFixedGridModel>();

        private Color _readOnlyTrueFillColor = Color.FromArgb(45, 48, 66); 
        private Color _readOnlyTrueBorderColor = Color.FromArgb(69, 72, 89);
        private Color _readOnlyTrueForeColor = Color.FromArgb(169,169, 169); 
        private Color _readOnlyTruePlaceHolderForeColor = Color.FromArgb(220, 220, 220);

        private Color _editFillColor = Color.FromArgb(57, 68, 85); 
        private Color _editBorderColor = Color.FromArgb(91, 109, 135);
        private Color _editForeColor = Color.FromArgb(255, 255, 255);
        private Color _editPlaceHolderForeColor = Color.FromArgb(242, 221, 184);

        string action = "";

        private DataGridViewRow totalRow = null;

        public UC_ExpensesFixed()
        {
            InitializeComponent();

            gtbExpenseValue.KeyPress += gtbExpenseValue_KeyPress;
            gtbExpenseValue.TextChanged += gtbExpenseValue_TextChanged;
            gtbExpenseValue.Leave += gtbExpenseValue_Leave;

            _repository =
                new ExpensesFixedRepository(GlobalVar.AppConnString);

            _cache =
                new ExpensesFixedCache();

            _controller =
                new CrudController<ExpensesFixedModel>(
                    _repository,
                    _cache);

            _gridAdapter =
                new DataGridViewAdapter<ExpensesFixedGridModel>(
                    dgvExpensesFixed,
                    bsExpensesFixed);

            _navigator =
                new CrudNavigator<ExpensesFixedGridModel>(
                    _gridAdapter);

            _navigator.CurrentRecordChanged += Navigator_CurrentRecordChanged;

            ConfigureExpensesFixedGrid();

            // Change constructor to call async initialization
            _ = InitializeAsync();
        }

        private async void Navigator_CurrentRecordChanged(object sender,long? id)
        {
        }

        private async Task InitializeAsync()
        {
            await RefreshScreenAsync();   // Copilot 05.07.2026
        }
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

        private async Task ReloadGridAsync()
        {
            IList<ExpensesFixedGridModel> list =
                await _repository.GetGridDataAsync();

            _gridAdapter.Load(list);

            _navigator.NotifyCurrent();
        }

        private async void Navigator_CurrentRecordChanged(object sender, long? id)
        {
            if (!id.HasValue)
            {
                ClearForm();

                return;
            }

            ExpensesFixedModel model =
                await _controller.LoadAsync(id.Value);

            FillControls(model);
        }

        private async Task LoadDataGridAsync()
        {
            try
            {

                _gridData = await _expensesfixedRepository.GetGridDataAsync();

                _bs.DataSource = _gridData;

                gDataGrid.DataSource = _bs;

            }
            catch (Exception ex)
            {
                MsgBox msgBox = new MsgBox(ex.Message, "danger", "Ok");
                msgBox.ShowDialog();
            }
        }

        private void SelectGridRowById(long id)
        {
            foreach (DataGridViewRow row
                in gDataGrid.Rows)
            {
                if (Convert.ToInt64(row.Cells["id"].Value) == id)
                {
                    row.Selected = true;

                    gDataGrid.CurrentCell = row.Cells[0];

                    break;
                }
            }
        }

        private async Task SaveNewAsync()
        {
            var model = GetFormData();

            model.LogCrudDate = DateTime.Now;

            model.LogCrudUserId = GlobalVar.AppUserID;

            long id =
                await _expensesfixedRepository.InsertAsync(model);

            //
            var newModel = await _expensesfixedRepository.GetByIdAsync(id);

            _cache.Add(newModel);

            _bs.ResetBindings(false);

            MsgBox msgBox = new MsgBox("Registro criado com sucesso!", "success", "Ok");
            msgBox.ShowDialog();

            await RefreshScreenAsync(id);
        }
        private async Task UpdateAsync()
        {
            var model = GetFormData();

            model.Id = Convert.ToInt64(gtbId.Text);

            model.LogCrudDate = DateTime.Now;

            model.LogCrudUserId = GlobalVar.AppUserID;

            await _expensesfixedRepository.UpdateAsync(model);

            var updatedModel =
                await _expensesfixedRepository.GetByIdAsync(model.Id);

            _cache.Update(updatedModel);

            MsgBox msgBox = new MsgBox("Registro atualizado!", "success", "Ok");
            msgBox.ShowDialog();

            await RefreshScreenAsync(model.Id);
        }
        private async Task DeleteAsync()
        {
            long id =
                Convert.ToInt64(gtbId.Text);

            await _expensesfixedRepository.DeleteAsync(
                id,
                GlobalVar.AppUserID);

            _cache.Remove(id);

            MsgBox msgBox = new MsgBox("Registro removido !", "success", "Ok");
            msgBox.ShowDialog();

            //await LoadDataGridAsync();

            await RefreshScreenAsync();
        }
        private ExpensesFixedModel GetFormData()
        {
            return new ExpensesFixedModel
            {
                Name = gtbExpenseName.Text,

                Description = gtbDescription.Text,

                ExpenseValue =
                    decimal.TryParse(
                        gtbExpenseValue.Text,
                        NumberStyles.Any,
                        CultureInfo.CurrentCulture,
                        out decimal purchase)
                        ? purchase
                        : 0,
            };
        }
        
        private async Task LoadExpensesFixedAsync(long id)
        {
            _loadCts?.Cancel();

            _loadCts = new CancellationTokenSource();

            try
            {
                var token = _loadCts.Token;

                ExpensesFixedModel model;

                if (_cache.Exists(id))
                {
                    model = _cache.Get(id);
                }
                else
                {
                    model =
                        await _expensesfixedRepository
                        .GetByIdAsync(id);

                    token.ThrowIfCancellationRequested();


                    if (model == null)
                        return;

                    _cache.Add(model);
                }

                token.ThrowIfCancellationRequested();

                FillControls(model);
            }
            catch (OperationCanceledException)
            {
                // ignora seleção antiga
            }
            catch (Exception ex)
            {

                MsgBox msgBox = new MsgBox(ex.Message, "danger", "Ok");
                msgBox.ShowDialog();

                // MessageBox.Show(ex.Message);
            }
        }
        private void FillControls(ExpensesFixedModel model)
        {
            CultureInfo culturaBR = new CultureInfo("pt-BR");

            gtbId.Text = model.Id.ToString();

            gtbExpenseName.Text = model.Name;

            gtbDescription.Text = model.Description;

            gtbExpenseValue.Text =
                FormatDecimal(model.ExpenseValue);

            string logType = "";
            if (model.LogCrudType == "1")
            {
                logType = "Inclusão";
            }
            else if (model.LogCrudType == "2")
            {
                logType = "Alteração";
            }
            else if (model.LogCrudType == "3")
            {
                logType = "Exclusão";
            }

            gchipRecLog.Text = model.LogCrudDate?.ToString("dd/MM/yyyy HH:mm:ss") + " | " +
            logType + " | " + model.LogUserName;
        }
        private string FormatDecimal(decimal valor)
        {
            return valor.ToString("N2", new CultureInfo("pt-BR"));
        }
        private void ClearForm()
        {
            gtbId.Text = "";
            gtbExpenseName.Text = "";
            gtbDescription.Text = "";
            gtbExpenseValue.Text = "0,00";
            gtbExpenseTotal.Text = "0,00";
            gchipRecLog.Text = "";
        }
        private async Task SaveAsync()
        {
            List<string> errors = new List<string>();

            try
            {

                Cursor = Cursors.WaitCursor;

                ExpensesFixedModel model = GetFormData();

                // ==========================
                // INICIO VALIDAÇÃO DOS DADOS
                // ==========================

                errors = ExpensesFixedValidator.Validate(model);

                if (errors.Any())
                {

                    MsgBoxValidator msgBoxValidator = new MsgBoxValidator(errors);

                    msgBoxValidator.ShowDialog();

                    return;
                }

                // ==========================
                // FIM VALIDAÇÃO DOS DADOS
                // ==========================

                model.LogCrudDate = DateTime.Now;

                model.LogCrudUserId = GlobalVar.AppUserID;

                switch (action)
                {
                    case "create":
                        await SaveNewAsync();
                        break;
                    case "edit":
                        await UpdateAsync();
                        break;
                    case "delete":
                        await DeleteAsync();
                        break;
                    default:

                        MsgBox msgBox = new MsgBox("Nenhuma ação de CRUD selecionada !", "warning", "Ok");
                        msgBox.ShowDialog();
                        //MessageBox.Show("No action selected.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MsgBox msgBox = new MsgBox(ex.Message, "danger", "Ok");
                msgBox.ShowDialog();
            }
            finally
            {
                Cursor = Cursors.Default;

                if (errors.Any())
                {
                    if (gDataGrid == null || gDataGrid.CurrentCell == null || gDataGrid.CurrentCell.RowIndex < 0)
                    {
                        SetActionMode("empty");
                    } else
                    {
                        SetActionMode("read");
                    }
                }
                else
                {
                    if (gDataGrid == null || gDataGrid.CurrentCell == null || gDataGrid.CurrentCell.RowIndex < 0)
                    {
                        SetActionMode("empty");
                    }
                    else
                    {
                        SetActionMode("read");
                    }
                }

            }
        }

        // Change the event handler to async Task to fix CS4033

        private async void CancelOperation()
        {

            if (!TryGetCurrentId(out long id))
            {
                SetActionMode("empty");
                return;
            }

            await RefreshScreenAsync(Convert.ToInt64(gtbId.Text));

            action = "read";

            SetActionMode("read");
        }

        private void SetActionMode(string action)
        {
            switch (action)
            {
                case "empty":
                    // configura estado dos botões
                    gbtAdd.Enabled = true;
                    gbtEdit.Enabled = false;
                    gbtDelete.Enabled = false;
                    gbtCancel.Enabled = false;
                    gbtSave.Enabled = false;
                    // configura estado dos campos
                    gtbId.Enabled = false;
                    gtbExpenseName.Enabled = false;
                    gtbDescription.Enabled = false;
                    gtbExpenseValue.Enabled = false;
                    gtbExpenseTotal.Enabled = false;

                    gchipRecLog.Text = "<< nenhum registro encontrado >>";

                    gbtAdd.Focus();

                    SetFieldColors("read");

                    break;
                case "read":
                    // configura estado dos botões
                    gbtAdd.Enabled = true;
                    gbtEdit.Enabled = true;
                    gbtDelete.Enabled = true;
                    gbtCancel.Enabled = false;
                    gbtSave.Enabled = false;
                    // configura estado dos campos
                    gtbId.Enabled = true;
                    gtbExpenseName.Enabled = true;
                    gtbDescription.Enabled = true;
                    gtbExpenseValue.Enabled = true;
                    gtbExpenseTotal.Enabled = true;

                    gtbId.ReadOnly = true;
                    gtbExpenseName.ReadOnly = true;
                    gtbDescription.ReadOnly = true;
                    gtbExpenseValue.ReadOnly = true;
                    gtbExpenseTotal.ReadOnly = true;

                    gDataGrid.Focus();

                    SetFieldColors("read");

                    break;
                case "add":
                    // configura estado dos botões
                    gbtAdd.Enabled = false;
                    gbtEdit.Enabled = false;
                    gbtDelete.Enabled = false;
                    gbtCancel.Enabled = true;
                    gbtSave.Enabled = true;
                    // configura estado dos campos
                    gtbId.Enabled = false;
                    gtbExpenseName.Enabled = true;
                    gtbDescription.Enabled = true;
                    gtbExpenseValue.Enabled = true;
                    gtbExpenseTotal.Enabled = true;

                    gtbExpenseName.ReadOnly = false;
                    gtbDescription.ReadOnly = false;
                    gtbExpenseValue.ReadOnly = false;
                    gtbExpenseTotal.ReadOnly = true;

                    gtbExpenseName.Focus();

                    SetFieldColors("edit");

                    break;
                case "edit":
                    // configura estado dos botões
                    gbtAdd.Enabled = false;
                    gbtEdit.Enabled = false;
                    gbtDelete.Enabled = false;
                    gbtCancel.Enabled = true;
                    gbtSave.Enabled = true;
                    // configura estado dos campos
                    gtbId.Enabled = true;
                    gtbExpenseName.Enabled = true;
                    gtbDescription.Enabled = true;
                    gtbExpenseValue.Enabled = true;
                    gtbExpenseTotal.Enabled = true;

                    gtbId.ReadOnly = true;
                    gtbExpenseName.ReadOnly = false;
                    gtbDescription.ReadOnly = false;
                    gtbExpenseValue.ReadOnly = false;
                    gtbExpenseTotal.ReadOnly = true;

                    gtbExpenseName.Focus();

                    SetFieldColors("edit");

                    break;
                case "delete":
                    // configura estado dos botões
                    gbtAdd.Enabled = false;
                    gbtEdit.Enabled = false;
                    gbtDelete.Enabled = false;
                    gbtCancel.Enabled = false;
                    gbtSave.Enabled = false;
                    // configura estado dos campos
                    gtbId.Enabled = false;
                    gtbExpenseName.Enabled = false;
                    gtbDescription.Enabled = false;
                    gtbExpenseValue.Enabled = false;
                    gtbExpenseTotal.Enabled = false;

                    SetFieldColors("read");

                    break;
            }
        }
        private void SetFieldColors(string action)
        {
            switch (action) 
            {
                case "read":
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
                case "edit":
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

        private void gDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Don't trigger if the change happened in the total row itself or during initialization
            if (totalRow != null && e.RowIndex == totalRow.Index) return;

            // Only recalculate if the edited column is the "Amount" column
            if (gDataGrid.Columns[e.ColumnIndex].Name == "ExpenseValue")
            {
                UpdateTotalRow();
            }
        }

        private void gDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gDataGrid.IsCurrentCellDirty)
            {
                gDataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void gDataGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // If either row being compared is the total row, force it to the bottom
            if (gDataGrid.Rows[e.RowIndex1] == totalRow)
            {
                e.SortResult = 1; // Put row 1 lower
                e.Handled = true;
            }
            else if (gDataGrid.Rows[e.RowIndex2] == totalRow)
            {
                e.SortResult = -1; // Put row 2 lower
                e.Handled = true;
            }
        }

        private void gDataGrid_Sorted(object sender, EventArgs e)
        {
            if (totalRow != null)
            {
                // 1. Remove the total row from its post-sort position
                gDataGrid.Rows.Remove(totalRow);

                // 2. Add it back to the absolute bottom of the grid
                gDataGrid.Rows.Add(totalRow);
            }
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

        private void gbtCancel_Click(object sender, EventArgs e)
        {
            MsgBox msgBox = new MsgBox("Tem certeza que quer cancelar a operação ?", "warning", "YesNo");
            msgBox.ShowDialog();

            if (msgBox.clicked == "Yes")
            {
                CancelOperation();

                if (!TryGetCurrentId(out long id))
                {
                    SetActionMode("empty");
                    return;
                }

                SetActionMode("read");
            }
        }

        private void gbtAdd_Click(object sender, EventArgs e)
        {
            action = "create";
            ClearForm();
            SetActionMode("add");
        }

        private void gbtEdit_Click(object sender, EventArgs e)
        {
            action = "edit";
            SetActionMode("edit");
        }

        private async void gbtDelete_Click(object sender, EventArgs e)
        {
            action = "delete";

            SetActionMode("delete");

            MsgBox msgBox = new MsgBox("Tem certeza que quer Excluir o registro ?", "danger", "YesNo");
            msgBox.ShowDialog();

            if (msgBox.clicked == "Yes")
            {
                await DeleteAsync();
            }
            
            await RefreshScreenAsync();

            if (!TryGetCurrentId(out long id))
            {
                SetActionMode("empty");
                return;
            }

            action = "read";
            SetActionMode("read");
        }

        private void gchipRecLog_Click(object sender, EventArgs e)
        {

        }

        private async void gDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!TryGetCurrentId(out long id))
            {
                SetActionMode("empty");
                return;
            }

            await LoadExpensesFixedAsync(id);

        }
        private async Task RefreshScreenAsync(long? selectId = null)
        {
            await LoadDataGridAsync();

            if (gDataGrid.Rows.Count == 0)
            {
                ClearForm();
                SetActionMode("empty");
                return;
            }

            if (selectId.HasValue)
            {
                SelectGridRowById(selectId.Value);
            }

            if (gDataGrid.CurrentRow != null)
            {
                long id = Convert.ToInt64(
                    gDataGrid.CurrentRow.Cells["id"].Value);

                await LoadExpensesFixedAsync(id);
            }

            SetActionMode("read");
        }
        private bool TryGetCurrentId(out long id)
        {
            id = 0;

            if (gDataGrid.CurrentRow == null)
                return false;

            object value = gDataGrid.CurrentRow.Cells["id"].Value;

            if (value == null)
                return false;

            return long.TryParse(value.ToString(), out id);
        }

    }
}
