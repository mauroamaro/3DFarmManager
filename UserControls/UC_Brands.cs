using _3DFarmManager.Framework.Adapters;
using _3DFarmManager.Framework.Controllers;
using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Crud;
using _3DFarmManager.Framework.Models.Base;
using _3DFarmManager.Framework.Navigation;
using _3DFarmManager.Framework.Services;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using _3DFarmManager.Repositories;
using _3DFarmManager.Services;
using _3DFarmManager.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public partial class UC_Brands : UserControl
    {
        #region Infrastructure

        private BrandRepository _repository;

        private BrandCacheService _cache;

        private CrudController<BrandModel> _controller;

        private DataGridViewAdapter<BrandGridModel> _gridAdapter;

        private CrudNavigator<BrandGridModel> _navigator;

        private CrudButtonManager _buttonManager;

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

        private bool _initialized;

        #endregion

        #region Constructor

        public UC_Brands()
        {
            InitializeComponent();

            InitializeFramework();

            InitializeGrid();

            WireEvents();

            _ = InitializeAsync();
        }

        #endregion

        #region Initialization

        private void InitializeFramework()
        {
            _repository = new BrandRepository(GlobalVar.AppConnString);

            _cache = new BrandCacheService();

            _controller = new CrudController<BrandModel>(_repository, _cache);

            _gridAdapter = new DataGridViewAdapter<BrandGridModel>(gDataGridView);

            _navigator = new CrudNavigator<BrandGridModel>(_gridAdapter);

            _buttonManager = new CrudButtonManager(this);
        }

        private void InitializeGrid()
        {
            ConfigureBrandGrid();
        }

        private void WireEvents()
        {
            _navigator.CurrentRecordChanged +=
                Navigator_CurrentRecordChanged;

            gDataGridView.SelectionChanged +=
                gDataGridView_SelectionChanged;
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

            _buttonManager.Apply(state);
        }
        private void ApplyViewState(CrudViewState state)
        {
            formMain formFather = this.ParentForm as formMain;

            if (formFather != null)

                formFather.gbtExit.Enabled = state.CanExit;

            _buttonManager.Apply(state);
        }
        #endregion

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_initialized)
                return;

            _initialized = true;

            await InitializeAsync();
        }

        #region View

        private BrandModel ReadModel()
        {
            BrandModel model = _controller.Current ?? new BrandModel();

            model.Name = gtbBrandName.Text.Trim();
            model.Url = gtbBrandUrl.Text.Trim();

            return model;
        }

        private void FillModel(BrandModel model)
        {
            if (model == null)
            {
                ClearView();
                return;
            }

            gtbId.Text = model.Id.ToString();
            gtbBrandName.Text = model.Name;
            gtbBrandUrl.Text = model.Url;
            gchipRecLog.Text = BuildAuditText(model);

        }

        private void ClearView()
        {
            gtbId.Clear();
            gtbBrandName.Clear();
            gtbBrandUrl.Clear();
            gchipRecLog.Text = string.Empty;
        }

        private static string BuildAuditText(BrandModel model)
        {
            if (model == null)
                return String.Empty;

            return $"{model.LogCrudTypeDescription} | {model.LogCrudDate:dd/MM/yyyy HH:mm:ss} | {model.LogUserName}";
        }

        #endregion


        private void ConfigureBrandGrid()
        {

            //var dgv = sDataGridView.GridView;
            var dgv = gDataGridView;

            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AllowUserToResizeColumns = true;

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
                HeaderText = "Nome",
                DataPropertyName = "Name",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "url",
                HeaderText = "URL",
                DataPropertyName = "Url",
                Width = 250
            });

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

        }

        private async Task ReloadGridAsync(long? selectedId = null)
        {
            _controller.RefreshCache();

            IList<BrandGridModel> items = await _repository.GetGridDataAsync();

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
            BrandModel model = await _controller.LoadAsync(id);

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
            BrandModel model = ReadModel();

            List<string> errors = BrandValidator.Validate(model);

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

                ChangeMode(CrudMode.Empty);

                return;
            }

            await LoadCurrentAsync(_controller.CurrentId.Value);

            ChangeMode(CrudMode.Read);
        }

        #endregion

        #region UI

        private void ConfigureEditors(CrudMode mode)
        {
            bool editing =
                mode == CrudMode.Create ||
                mode == CrudMode.Edit;

            bool readOnly =
                mode == CrudMode.Read ||
                mode == CrudMode.Empty;

            // ID sempre somente leitura
            gtbId.ReadOnly = true;

            gtbBrandName.ReadOnly = readOnly;
            gtbBrandUrl.ReadOnly = readOnly;
        }

        private void ConfigureFocus(CrudMode mode)
        {
            if (mode == CrudMode.Create || mode == CrudMode.Edit)
            {
                gtbBrandName.Focus();
            }
            else
            {
                gDataGridView.Focus();
            }
        }

        private void SetActionMode(CrudMode mode)
        {
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
                    gtbBrandName.FillColor = _readOnlyTrueFillColor;
                    gtbBrandName.BorderColor = _readOnlyTrueBorderColor;
                    gtbBrandName.ForeColor = _readOnlyTrueForeColor;
                    gtbBrandName.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbBrandUrl.FillColor = _readOnlyTrueFillColor;
                    gtbBrandUrl.BorderColor = _readOnlyTrueBorderColor;
                    gtbBrandUrl.ForeColor = _readOnlyTrueForeColor;
                    gtbBrandUrl.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    break;
                case CrudMode.Edit:
                    gtbId.FillColor = _readOnlyTrueFillColor;
                    gtbId.BorderColor = _readOnlyTrueBorderColor;
                    gtbId.ForeColor = _readOnlyTrueForeColor;
                    gtbId.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;
                    gtbBrandName.FillColor = _editFillColor;
                    gtbBrandName.BorderColor = _editBorderColor;
                    gtbBrandName.ForeColor = _editForeColor;
                    gtbBrandName.PlaceholderForeColor = _editPlaceHolderForeColor;
                    gtbBrandUrl.FillColor = _editFillColor;
                    gtbBrandUrl.BorderColor = _editBorderColor;
                    gtbBrandUrl.ForeColor = _editForeColor;
                    gtbBrandUrl.PlaceholderForeColor = _editPlaceHolderForeColor;

                    break;
            }
        }

        #endregion

        #region Events

        private void panelData_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gbtAdd_Click(object sender, EventArgs e)
        {
        }

        private void gbtEdit_Click(object sender, EventArgs e)
        {
        }

        private void gbtDelete_Click(object sender, EventArgs e)
        {
        }

        private void gbtSave_Click(object sender, EventArgs e)
        {
        }

        private void gbtCancel_Click(object sender, EventArgs e)
        {
        }
        private void gbtExit_Click(object sender, EventArgs e)
        {
        }

        private void gDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _navigator.NotifyCurrent();
        }

        private bool ConfirmDelete()
        {
            return DialogService.Confirm("Deseja realmente excluir este registro?");
        }

        private async void gbtRefresh_Click(object sender, EventArgs e)
        {
            await ReloadGridAsync(_controller.CurrentId);

            ChangeMode(CrudMode.Read);
        }

        #endregion

        private void gDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_controller.Mode != CrudMode.Read)
                return;

            _navigator.NotifyCurrent();
        }

        private void gActionBtAdd_Click(object sender, EventArgs e)
        {
            BeginCreate();
        }

        private void gActionBtEdit_Click(object sender, EventArgs e)
        {
            BeginEdit();
        }

        private async void gActionBtDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                await DeleteAsync();
            }
        }

        private async void gActionBtSave_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private async void gActionBtCancel_Click(object sender, EventArgs e)
        {
            await CancelAsync();
        }

        private async void gActionBtRefresh_Click(object sender, EventArgs e)
        {
            await ReloadGridAsync(_controller.CurrentId);

            ChangeMode(CrudMode.Read);
        }
    }
}
