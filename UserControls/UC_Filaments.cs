using _3DFarmManager.Framework.Adapters;
using _3DFarmManager.Framework.Controllers;
using _3DFarmManager.Framework.Controls;
using _3DFarmManager.Framework.Core;
using _3DFarmManager.Framework.Crud;
using _3DFarmManager.Framework.Helpers;
using _3DFarmManager.Framework.Models.Base;
using _3DFarmManager.Framework.Navigation;
using _3DFarmManager.Framework.Services;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using _3DFarmManager.Repositories;
using _3DFarmManager.Services;
using _3DFarmManager.Validators;
using _3DFarmManager.Views;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _3DFarmManager.UserControls
{
    public partial class UC_Filaments : UserControl
    {

        #region Infrastructure

            private FilamentRepository _repository;

            private BrandRepository _brandRepository;

            private FilamentTypeRepository _typeRepository;

            private FilamentCategoryRepository _categoryRepository;

            private FilamentSubCategoryRepository _subCategoryRepository;

            private ColorRepository _colorRepository;

            private UnitRepository _unitRepository;

            private FilamentPresetRepository _presetRepository;

            private FilamentCacheService _cache;

            private CrudController<FilamentModel> _controller;

            private DataGridViewAdapter<FilamentGridModel> _gridAdapter;

            private CrudNavigator<FilamentGridModel> _navigator;

            private CrudButtonManager _buttonManager;

            //private IList<FilamentSubCategoryModel> _allSubCategories;

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
            private bool _loading;

        #endregion

        #region Constructor

        public UC_Filaments()
        {
            InitializeComponent();

            InitializeFramework();

            InitializeGrid();

            WireEvents();

            //_ = InitializeAsync();

        }

        #endregion

        #region Initialization

        private void InitializeFramework()
        {
            _repository = new FilamentRepository(GlobalVar.AppConnString);

            _brandRepository = new BrandRepository(GlobalVar.AppConnString);

            _typeRepository = new FilamentTypeRepository(GlobalVar.AppConnString);

            _categoryRepository = new FilamentCategoryRepository(GlobalVar.AppConnString);

            _subCategoryRepository = new FilamentSubCategoryRepository(GlobalVar.AppConnString);

            _colorRepository = new ColorRepository(GlobalVar.AppConnString);

            _unitRepository = new UnitRepository(GlobalVar.AppConnString);

            _presetRepository = new FilamentPresetRepository(GlobalVar.AppConnString);

            _cache = new FilamentCacheService();

            _controller = new CrudController<FilamentModel>(_repository, _cache);

            _gridAdapter = new DataGridViewAdapter<FilamentGridModel>(gDataGridView);

            _navigator = new CrudNavigator<FilamentGridModel>(_gridAdapter);

            _buttonManager = new CrudButtonManager(this);
        }

        private void InitializeGrid()
        {
            ConfigureGrid();
        }

        private void WireEvents()
        {
            _navigator.CurrentRecordChanged +=
                Navigator_CurrentRecordChanged;

            gDataGridView.SelectionChanged +=
                gDataGridView_SelectionChanged;

            gcbPreset.SelectedIndexChanged +=
                gcbPreset_SelectedIndexChanged;
        }

        private async Task InitializeAsync()
        {
            _loading = true;

            try
            {
                await LoadLookupsAsync();

                await ReloadGridAsync();
            }
            finally
            {
                _loading = false;
            }
        }

        private void RefreshViewState()
        {
            CrudViewState state =
                _viewStateService.GetState(
                    _controller.Mode,
                    _navigator.HasItems);

            ApplyViewState(state);

            //_buttonManager.Apply(state);

            ConfigureAuxiliaryButtons(_controller.Mode);
        }
        private void ApplyViewState(CrudViewState state)
        {
            formMain formFather = this.ParentForm as formMain;

            if (formFather != null)

                formFather.gbtExit.Enabled = state.CanExit;

            _buttonManager.Apply(state);
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_initialized)
                return;

            _initialized = true;

            await InitializeAsync();
        }

        #endregion

        #region View

        private FilamentModel ReadModel()
        {
            FilamentModel model = _controller.Current ?? new FilamentModel();

            model.Name = gtbName.Text.Trim();
            model.BrandId = Convert.ToInt64(gcbBrand.SelectedValue);
            model.CategoryId = Convert.ToInt64(gcbCategory.SelectedValue);
            model.SubCategoryId = Convert.ToInt64(gcbSubCategory.SelectedValue);
            model.ColorId = Convert.ToInt64(gcbColor.SelectedValue);
            model.UnitId = Convert.ToInt64(gcbUnit.SelectedValue);
            model.PresetId = Convert.ToInt64(gcbPreset.SelectedValue);
            model.FilamentTypeId = Convert.ToInt64(gcbType.SelectedValue);

            model.FilamentCost = gtbPurchaseCost.DecimalValue();
            model.StockQuantity = gtbStock.DecimalValue();

            model.RecommNozzleTemp = gtbRecommNozzleTemp.DecimalValue();
            model.RecommPlateTemp = gtbRecommPlateTemp.DecimalValue();
            model.RecommFlowRate = gtbRecommFlowRate.DecimalValue();

            return model;
        }

        private void FillModel(FilamentModel model)
        {

            CultureInfo culturaBR = new CultureInfo("pt-BR");

            if (model == null)
            {
                ClearView();
                return;
            }

            _loading = true;

            try
            {
                gtbName.Text = model.Name;

                gcbBrand.SelectedValue = model.BrandId;

                gcbCategory.SelectedValue = model.CategoryId;

                gcbSubCategory.SelectedValue = model.SubCategoryId;

                gcbColor.SelectedValue = model.ColorId;

                gcbUnit.SelectedValue = model.UnitId;

                gcbType.SelectedValue = model.FilamentTypeId;

                gcbPreset.SelectedValue = model.PresetId;

                LoadPresetValues();

                gtbPurchaseCost.Text = FormatDecimal(model.FilamentCost);

                gtbStock.Text = FormatDecimal(model.StockQuantity);

                gtbRecommNozzleTemp.Text = model.RecommNozzleTemp.ToString("N0");

                gtbRecommPlateTemp.Text = model.RecommPlateTemp.ToString("N0");

                gtbRecommFlowRate.Text = FormatDecimal(model.RecommFlowRate);

                gchipRecLog.Text = BuildAuditText(model);
            }
            finally
            {
                _loading = false;
            }
        }

        private void LoadPresetValues()
        {
            FilamentPresetModel preset = gcbPreset.SelectedItem as FilamentPresetModel;

            if (preset == null)
            {
                gtbProfileNozzleTemp.Clear();
                gtbProfilePlateTemp.Clear();
                gtbProfileFlowRate.Clear();
                return;
            }

            gtbProfileNozzleTemp.Text = preset.NozzleTemp.ToString("N0");

            gtbProfilePlateTemp.Text = preset.PlateTemp.ToString("N0");

            gtbProfileFlowRate.Text = preset.FlowRate.ToString("N2");
        }

        private string FormatDecimal(decimal valor)
        {
            return valor.ToString("N2", new CultureInfo("pt-BR"));
        }

        private void ClearView()
        {
            gtbName.Clear();
            gcbBrand.SelectedIndex = -1;
            gcbCategory.SelectedIndex = -1;
            gcbSubCategory.SelectedIndex = -1;
            gcbColor.SelectedIndex = -1;
            gcbUnit.SelectedIndex = -1;
            gcbPreset.SelectedIndex = -1;
            gcbType.SelectedIndex = -1;

            gtbPurchaseCost.Text = "0,00";
            gtbStock.Text = "0,00";

            gtbRecommNozzleTemp.Text = "0";
            gtbRecommPlateTemp.Text = "0";  
            gtbRecommFlowRate.Text = "0,00";

            gtbProfileNozzleTemp.Clear();
            gtbProfilePlateTemp.Clear();
            gtbProfileFlowRate.Clear();

            gchipRecLog.Text = string.Empty;
        }

        private static string BuildAuditText(FilamentModel model)
        {
            if (model == null)
                return String.Empty;

            return $"{model.LogCrudTypeDescription} | {model.LogCrudDate:dd/MM/yyyy HH:mm:ss} | {model.LogUserName}";
        }

        #endregion

        #region Grid Configuration

        private void ConfigureGrid()
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
                Name = "brandname",
                HeaderText = "Marca/Fabricante",
                DataPropertyName = "BrandName",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filamenttypename",
                HeaderText = "Tipo",
                DataPropertyName = "FilamentTypeName",
                Width = 70
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colorname",
                HeaderText = "Cor",
                DataPropertyName = "ColorName",
                Width = 100
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unitshortname",
                HeaderText = "Unidade",
                DataPropertyName = "UnitShortName",
                Width = 70
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "filamentcost",
                HeaderText = "Custo",
                DataPropertyName = "FilamentCost",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "stockquantity",
                HeaderText = "Estoque",
                DataPropertyName = "StockQuantity",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "categoryname",
                HeaderText = "Categoria",
                DataPropertyName = "CategoryName",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "subcategoryname",
                HeaderText = "Subcategoria",
                DataPropertyName = "SubCategoryName",
                Width = 250
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "presetname",
                HeaderText = "Preset",
                DataPropertyName = "PresetName",
                Width = 150
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "recommnozzletemp",
                HeaderText = "Temp. Bico",
                DataPropertyName = "RecommNozzleTemp",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "recommplatetemp",
                HeaderText = "Temp. Mesa",
                DataPropertyName = "RecommPlateTemp",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "recommflowrate",
                HeaderText = "Taxa Fluxo",
                DataPropertyName = "RecommFlowRate",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private async Task LoadLookupsAsync()
        {
            await LoadBrandAsync();
            await LoadFilamentTypeAsync();
            await LoadColorAsync();
            await LoadUnitAsync();
            await LoadFilamentCategoryAsync();
            await LoadFilamentSubCategoryAsync();
            await LoadFilamentPresetAsync();
        }

        private async Task ReloadGridAsync(long? selectedId = null)
        {

            _controller.RefreshCache();

            IList<FilamentGridModel> items = await _repository.GetGridDataAsync();

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

        #endregion

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
            FilamentModel model = await _controller.LoadAsync(id);

            if (model == null)
            {
                ClearView();
                return;
            }

            FillModel(model);
        }

        private async Task LoadBrandAsync()
        {
            var brands = await _brandRepository.GetBrandsAsync();

            gcbBrand.DataSource = brands;

            gcbBrand.DisplayMember = "Name";

            gcbBrand.ValueMember = "Id";
        }

        private async Task LoadFilamentTypeAsync()
        {
            var types = await _typeRepository.GetFilamentTypesAsync();

            gcbType.DataSource = types;

            gcbType.DisplayMember = "Name";
            gcbType.ValueMember = "Id";
        }

        private async Task LoadColorAsync()
        {
            var colors = await _colorRepository.GetColorsAsync();

            gcbColor.DataSource = colors;
            gcbColor.DisplayMember = "Name";
            gcbColor.ValueMember = "Id";
        }
        private async Task LoadUnitAsync()
        {
            var units = await _unitRepository.GetUnitsAsync();

            gcbUnit.DataSource = units;
            gcbUnit.DisplayMember = "ShortName";
            gcbUnit.ValueMember = "Id";
        }
        private async Task LoadFilamentCategoryAsync()
        {
            var categories = await _categoryRepository.GetFilamentCategoriesAsync();

            gcbCategory.DataSource = categories;
            gcbCategory.DisplayMember = "Name";
            gcbCategory.ValueMember = "Id";
        }

        private async Task LoadFilamentSubCategoryAsync()
        {
            var subCategories = await _subCategoryRepository.GetFilamentSubCategoriesAsync();

            gcbSubCategory.DataSource = subCategories;
            gcbSubCategory.DisplayMember = "Name";
            gcbSubCategory.ValueMember = "Id";
        }

        private async Task LoadFilamentPresetAsync()
        {
            var presets = await _presetRepository.GetFilamentPresetsAsync();

            gcbPreset.DataSource = presets;
            gcbPreset.DisplayMember = "Name";
            gcbPreset.ValueMember = "Id";
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
            FilamentModel model = ReadModel();

            List<string> errors = FilamentValidator.Validate(model);

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

            gtbProfileNozzleTemp.ReadOnly = true;
            gtbProfilePlateTemp.ReadOnly = true;
            gtbProfileFlowRate.ReadOnly = true;

            // TextBox
            gtbName.ReadOnly = readOnly;

            if (editing)
            {
                // ComboBox
                gcbBrand.Tag = "EDIT";
                gcbCategory.Tag = "EDIT";
                gcbColor.Tag = "EDIT";
                gcbUnit.Tag = "EDIT";
                gcbType.Tag = "EDIT";
                gcbSubCategory.Tag = "EDIT";
                gcbPreset.Tag = "EDIT";
            }
            else
            {
                // ComboBox
                gcbBrand.Tag = "READ";
                gcbCategory.Tag = "READ";
                gcbColor.Tag = "READ";
                gcbUnit.Tag = "READ";
                gcbType.Tag = "READ";
                gcbSubCategory.Tag = "READ";
                gcbPreset.Tag = "READ";
            }

            // Campos numéricos
            gtbStock.ReadOnly = readOnly;
            gtbPurchaseCost.ReadOnly = readOnly;
            gtbRecommFlowRate.ReadOnly = readOnly;
            gtbRecommNozzleTemp.ReadOnly = readOnly;
            gtbRecommPlateTemp.ReadOnly = readOnly;

        }

        private void ConfigureFocus(CrudMode mode)
        {
            if (mode == CrudMode.Create || mode == CrudMode.Edit)
            {
                gtbName.Focus();
            }
            else
            {
                gDataGridView.Focus();
            }
        }

        private void ConfigureAuxiliaryButtons(CrudMode mode)
        {
            bool enabled =
                mode != CrudMode.Create &&
                mode != CrudMode.Edit;

            gActionBtTypes.ActionEnabled = enabled;
            gActionBtColors.ActionEnabled = enabled;
            gActionBtUnits.ActionEnabled = enabled;
            gActionBtCategory.ActionEnabled = enabled;
            gActionBtSubCategory.ActionEnabled = enabled;
            gActionBtPresets.ActionEnabled = enabled;
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

                    gtbProfileFlowRate.ForeColor = Color.Black;
                    gtbProfileNozzleTemp.ForeColor = Color.Black;
                    gtbProfilePlateTemp.ForeColor = Color.Black;

                    gtbName.FillColor = _readOnlyTrueFillColor;
                    gtbName.BorderColor = _readOnlyTrueBorderColor;
                    gtbName.ForeColor = _readOnlyTrueForeColor;
                    gtbName.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gcbBrand.FillColor = _disabledFillColor;
                    gcbBrand.BorderColor = _disabledBorderColor;
                    gcbBrand.ForeColor = _disabledForeColor;

                    gcbCategory.FillColor = _disabledFillColor;
                    gcbCategory.BorderColor = _disabledBorderColor;
                    gcbCategory.ForeColor = _disabledForeColor;

                    gcbColor.FillColor = _disabledFillColor;
                    gcbColor.BorderColor = _disabledBorderColor;
                    gcbColor.ForeColor = _disabledForeColor;

                    gcbUnit.FillColor = _disabledFillColor;
                    gcbUnit.BorderColor = _disabledBorderColor;
                    gcbUnit.ForeColor = _disabledForeColor;

                    gcbType.FillColor = _disabledFillColor;
                    gcbType.BorderColor = _disabledBorderColor;
                    gcbType.ForeColor = _disabledForeColor;

                    gcbPreset.FillColor = _disabledFillColor;
                    gcbPreset.BorderColor = _disabledBorderColor;
                    gcbPreset.ForeColor = _disabledForeColor;

                    gcbSubCategory.FillColor = _disabledFillColor;
                    gcbSubCategory.BorderColor = _disabledBorderColor;
                    gcbSubCategory.ForeColor = _disabledForeColor;

                    gtbStock.FillColor = _readOnlyTrueFillColor;
                    gtbStock.BorderColor = _readOnlyTrueBorderColor;
                    gtbStock.ForeColor = _readOnlyTrueForeColor;
                    gtbStock.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbPurchaseCost.FillColor = _readOnlyTrueFillColor;
                    gtbPurchaseCost.BorderColor = _readOnlyTrueBorderColor;
                    gtbPurchaseCost.ForeColor = _readOnlyTrueForeColor;
                    gtbPurchaseCost.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbRecommFlowRate.FillColor = _readOnlyTrueFillColor;
                    gtbRecommFlowRate.BorderColor = _readOnlyTrueBorderColor;
                    gtbRecommFlowRate.ForeColor = _readOnlyTrueForeColor;
                    gtbRecommFlowRate.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbRecommNozzleTemp.FillColor = _readOnlyTrueFillColor;
                    gtbRecommNozzleTemp.BorderColor = _readOnlyTrueBorderColor;
                    gtbRecommNozzleTemp.ForeColor = _readOnlyTrueForeColor;
                    gtbRecommNozzleTemp.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbRecommPlateTemp.FillColor = _readOnlyTrueFillColor;
                    gtbRecommPlateTemp.BorderColor = _readOnlyTrueBorderColor;
                    gtbRecommPlateTemp.ForeColor = _readOnlyTrueForeColor;
                    gtbRecommPlateTemp.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    break;
                case CrudMode.Edit:

                    gtbProfileFlowRate.ForeColor = Color.Black;
                    gtbProfileNozzleTemp.ForeColor = Color.Black;
                    gtbProfilePlateTemp.ForeColor = Color.Black;

                    gtbName.FillColor = _editFillColor;
                    gtbName.BorderColor = _editBorderColor;
                    gtbName.ForeColor = _editForeColor;
                    gtbName.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gcbBrand.FillColor = _enabledFillColor;
                    gcbBrand.BorderColor = _enabledBorderColor;
                    gcbBrand.ForeColor = _enabledForeColor;

                    gcbCategory.FillColor = _enabledFillColor;
                    gcbCategory.BorderColor = _enabledBorderColor;
                    gcbCategory.ForeColor = _enabledForeColor;

                    gcbColor.FillColor = _enabledFillColor; ;
                    gcbColor.BorderColor = _enabledBorderColor;
                    gcbColor.ForeColor = _enabledForeColor;

                    gcbUnit.FillColor = _enabledFillColor; ;
                    gcbUnit.BorderColor = _enabledBorderColor;
                    gcbUnit.ForeColor = _enabledForeColor;

                    gcbType.FillColor = _enabledFillColor; ;
                    gcbType.BorderColor = _enabledBorderColor;
                    gcbType.ForeColor = _enabledForeColor;

                    gcbPreset.FillColor = _enabledFillColor; ;
                    gcbPreset.BorderColor = _enabledBorderColor;
                    gcbPreset.ForeColor = _enabledForeColor;

                    gcbSubCategory.FillColor = _enabledFillColor; ;
                    gcbSubCategory.BorderColor = _enabledBorderColor;
                    gcbSubCategory.ForeColor = _enabledForeColor;

                    gtbStock.FillColor = _editFillColor;
                    gtbStock.BorderColor = _editBorderColor;
                    gtbStock.ForeColor = _editForeColor;
                    gtbStock.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbPurchaseCost.FillColor = _editFillColor;
                    gtbPurchaseCost.BorderColor = _editBorderColor;
                    gtbPurchaseCost.ForeColor = _editForeColor;
                    gtbPurchaseCost.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbRecommFlowRate.FillColor = _editFillColor;
                    gtbRecommFlowRate.BorderColor = _editBorderColor;
                    gtbRecommFlowRate.ForeColor = _editForeColor;
                    gtbRecommFlowRate.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbRecommNozzleTemp.FillColor = _editFillColor;
                    gtbRecommNozzleTemp.BorderColor = _editBorderColor;
                    gtbRecommNozzleTemp.ForeColor = _editForeColor;
                    gtbRecommNozzleTemp.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbRecommPlateTemp.FillColor = _editFillColor;
                    gtbRecommPlateTemp.BorderColor = _editBorderColor;
                    gtbRecommPlateTemp.ForeColor = _editForeColor;
                    gtbRecommPlateTemp.PlaceholderForeColor = _editPlaceHolderForeColor;

                    break;
            }
        }

        #endregion

        private bool ConfirmDelete()
        {
            return DialogService.Confirm("Deseja realmente excluir este registro?");
        }

        private bool ConfirmCancel()
        {
            return DialogService.Confirm("Deseja realmente cancelar as alterações?");
        }

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
            if (ConfirmCancel())
            {
                await CancelAsync();
            }
        }

        private async void gActionBtRefresh_Click(object sender, EventArgs e)
        {
            await ReloadGridAsync(_controller.CurrentId);

            ChangeMode(CrudMode.Read);
        }

        private void gcbBrand_Enter(object sender, EventArgs e)
        {
            if (gcbBrand.Tag != null && gcbBrand.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbType_Enter(object sender, EventArgs e)
        {
            if (gcbType.Tag != null && gcbType.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbColor_Enter(object sender, EventArgs e)
        {
            if (gcbColor.Tag != null && gcbColor.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbUnit_Enter(object sender, EventArgs e)
        {
            if (gcbUnit.Tag != null && gcbUnit.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbCategory_Enter(object sender, EventArgs e)
        {
            if (gcbCategory.Tag != null && gcbCategory.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbSubCategory_Enter(object sender, EventArgs e)
        {
            if (gcbSubCategory.Tag != null && gcbSubCategory.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbPreset_Enter(object sender, EventArgs e)
        {
            if (gcbPreset.Tag != null && gcbPreset.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gcbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (_loading)
                return;

            if (gcbCategory.SelectedValue == null)
                return;

            if (gcbCategory.SelectedValue is DataRowView)
                return;

            if (!long.TryParse(
                gcbCategory.SelectedValue.ToString(),
                out long categoryId))
            {
                return;
            }

            if (_allSubCategories == null)
                return;

            long? currentSubCategoryId = null;

            if (gcbSubCategory.SelectedValue != null &&
                long.TryParse(
                    gcbSubCategory.SelectedValue.ToString(),
                    out long subCategoryId))
            {
                currentSubCategoryId = subCategoryId;
            }

            var filteredSubCategories =
                _allSubCategories
                    .Where(x => x.CategoryId == categoryId)
                    .ToList();

            gcbSubCategory.DataSource = null;
            gcbSubCategory.DisplayMember = "Name";
            gcbSubCategory.ValueMember = "Id";
            gcbSubCategory.DataSource = filteredSubCategories;

            if (currentSubCategoryId.HasValue &&
                filteredSubCategories.Any(
                    x => x.Id == currentSubCategoryId.Value))
            {
                gcbSubCategory.SelectedValue =
                    currentSubCategoryId.Value;
            }
            else
            {
                gcbSubCategory.SelectedIndex = -1;
            }
        */
        }

        private void gcbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_loading)
                return;

            LoadPresetValues();
        }

        private void gActionButton9_Click(object sender, EventArgs e)
        {

        }

        private void gActionButton11_Click(object sender, EventArgs e)
        {

        }

        private void gActionButton7_Click(object sender, EventArgs e)
        {
            gActionBtColors.Checked = true;
            formColors frm = new formColors();
            frm.ShowDialog();
            gActionBtColors.Checked = false;
        }

        private void gActionBtTypes_Click(object sender, EventArgs e)
        {
            gActionBtTypes.Checked = true;
            formFilamentTypes frm = new formFilamentTypes();
            frm.ShowDialog();
            gActionBtTypes.Checked = false;
        }
    }

}

