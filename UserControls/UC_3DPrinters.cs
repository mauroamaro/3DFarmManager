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
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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

namespace _3DFarmManager
{
    public partial class UC_3DPrinters : UserControl
    {
        #region Infrastructure

        private _3DPrinterRepository _printerRepository;

        private BrandRepository _brandRepository;

        private _3DPrinterCacheService _cache;

        private CrudController<_3DPrinterModel> _controller;

        private DataGridViewAdapter<_3DPrinterGridModel> _gridAdapter;

        private CrudNavigator<_3DPrinterGridModel> _navigator;

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

        public UC_3DPrinters()
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
            _printerRepository = new _3DPrinterRepository(GlobalVar.AppConnString);
            
            _brandRepository = new BrandRepository(GlobalVar.AppConnString);

            _cache = new _3DPrinterCacheService();

            _controller = new CrudController<_3DPrinterModel>(_printerRepository, _cache);

            _gridAdapter = new DataGridViewAdapter<_3DPrinterGridModel>(gDataGridView);

            _navigator = new CrudNavigator<_3DPrinterGridModel>(_gridAdapter);

            _buttonManager = new CrudButtonManager(this);
        }
        
        private void InitializeGrid()
        {
            ConfigurePrinterGrid();
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
            await LoadLookupsAsync();

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

        private void UC_3DPrinters_Load(object sender, EventArgs e)
        {
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_initialized)
                return;

            _initialized = true;

            await InitializeAsync();
        }

        #region View

        private _3DPrinterModel ReadModel()
        {
            _3DPrinterModel model = _controller.Current ?? new _3DPrinterModel();

            model.Name = gtbPrinterName.Text.Trim();
            model.BrandId = Convert.ToInt64(gcbBrand.SelectedValue);
            model.PurchaseDate = gdtPurchase.Value;
            model.StartOperationDate = gdtStartDate.Value;
            model.PurchasePrice = gtbPurchaseCost.DecimalValue();
            model.MaintenanceCost = gtbMaintenanceCost.DecimalValue();
            model.UsefullLife = gtbUsefullLife.DecimalValue();
            model.ElectricityConsumption = gtbElectricityConsumption.DecimalValue();
            model.Depreciation = gtbDepreciation.DecimalValue();

            return model;
        }

        private void FillModel(_3DPrinterModel model)
        {

            CultureInfo culturaBR = new CultureInfo("pt-BR");

            if (model == null)
            {
                ClearView();
                return;
            }

            gtbId.Text = model.Id.ToString();
            gtbPrinterName.Text = model.Name;
            gcbBrand.SelectedValue = model.BrandId;
            gdtPurchase.Value = model.PurchaseDate ?? DateTime.Now;
            gdtStartDate.Value = model.StartOperationDate ?? DateTime.Now;

            gtbPurchaseCost.Text = FormatDecimal(model.PurchasePrice);

            gtbMaintenanceCost.Text = FormatDecimal(model.MaintenanceCost);
            gtbUsefullLife.Text = model.UsefullLife.ToString("N0");
            gtbElectricityConsumption.Text = FormatDecimal(model.ElectricityConsumption);
            gtbDepreciation.Text = FormatDecimal(model.Depreciation);
            gchipRecLog.Text = BuildAuditText(model);

            // Debugging output to check values
            /*
            System.Diagnostics.Debug.WriteLine($"PurchasePrice(Model): {model.PurchasePrice}");
            System.Diagnostics.Debug.WriteLine($"PurchasePrice(Text): {gtbPurchaseCost.Text}");
            System.Diagnostics.Debug.WriteLine($"Maintenance(Model): {model.MaintenanceCost}");
            System.Diagnostics.Debug.WriteLine($"Maintenance(Text): {gtbMaintenanceCost.Text}");
            System.Diagnostics.Debug.WriteLine($"UsefulLife(Model): {model.UsefullLife}");
            System.Diagnostics.Debug.WriteLine($"UsefulLife(Text): {gtbUsefullLife.Text}");
            */

        }

        private void ClearView()
        {
            gtbId.Clear();
            gtbPrinterName.Clear();
            gcbBrand.SelectedIndex = -1;
            //gdtPurchase.Value = DateTime.Now;
            //gdtStartDate.Value = DateTime.Now;
            gtbPurchaseDate.Clear();
            gtbStartDate.Clear();
            gtbPurchaseCost.Text = "0,00";
            gtbMaintenanceCost.Text = "0,00";
            gtbUsefullLife.Text = "0";
            gtbElectricityConsumption.Text = "0,00";
            gtbDepreciation.Text = "0,00";
            gtbAnnualCost.Text = "0,00";
            gchipRecLog.Text = string.Empty;
        }

        private static string BuildAuditText(_3DPrinterModel model)
        {
            if (model == null)
                return String.Empty;

            return $"{model.LogCrudTypeDescription} | {model.LogCrudDate:dd/MM/yyyy HH:mm:ss} | {model.LogUserName}";
        }

        #endregion

        #region Grid

        private void ConfigurePrinterGrid()
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
                Name = "dtpurchase",
                HeaderText = "Data da Compra",
                DataPropertyName = "PurchaseDate",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "purchaseprice",
                HeaderText = "Preço Compra",
                DataPropertyName = "PurchasePrice",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "dtstartoperation",
                HeaderText = "Data Inicio Operação",
                DataPropertyName = "StartOperationDate",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }

            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "usefulllife",
                HeaderText = "Vida Útil (h)",
                DataPropertyName = "UsefullLife",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maintenancecost",
                HeaderText = "Custo Manutenção/Mês",
                DataPropertyName = "MaintenanceCost",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "electricityconsumption",
                HeaderText = "Consumo (kWh)",
                DataPropertyName = "ElectricityConsumption",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "depreciationvalue",
                HeaderText = "Depreciação (R$/h)",
                DataPropertyName = "DepreciationValue",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }

            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "annualmaintenancecost",
                HeaderText = "Custo Manutenção (12 meses)",
                DataPropertyName = "AnnualMaintenanceCost",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },

            });

            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.ForeColor = Color.Tan;

            dgv.Columns["annualmaintenancecost"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private async Task LoadLookupsAsync()
        {
            await LoadBrandAsync();
        }

        private async Task ReloadGridAsync(long? selectedId = null)
        {

            _controller.RefreshCache();

            IList<_3DPrinterGridModel> items = await _printerRepository.GetGridDataAsync();

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
            _3DPrinterModel model = await _controller.LoadAsync(id);

            if (model == null)
            {
                ClearView();
                return;
            }

            FillModel(model);

            ConfigureDateControls(_controller.Mode);
        }

        private async Task LoadBrandAsync()
        {
            var brands =
                await _brandRepository.GetBrandsAsync();

            gcbBrand.DataSource = brands;

            gcbBrand.DisplayMember = "Name";

            gcbBrand.ValueMember = "Id";
        }

        #region CRUD

        private void BeginCreate()
        {
            _controller.SetMode(CrudMode.Create);

            ClearView();

            gdtPurchase.Value = DateTime.Now;
            gdtStartDate.Value = DateTime.Now;

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
            _3DPrinterModel model = ReadModel();

            List<string> errors = _3DPrinterValidator.Validate(model);

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
            gtbAnnualCost.ReadOnly = true;

            // TextBox
            gtbPrinterName.ReadOnly = readOnly;

            if (editing)
            {
                // ComboBox
                gcbBrand.Tag = "EDIT";
            } else
            {
                // ComboBox
                gcbBrand.Tag = "READ";
            }

            /*
            // ComboBox
            gcbBrand.Enabled = editing;
            */
            // DateTimePicker
            gdtPurchase.Enabled = editing;
            gdtStartDate.Enabled = editing;

            gtbPurchaseDate.ReadOnly = readOnly;
            gtbStartDate.ReadOnly = readOnly;

            // Campos numéricos
            gtbPurchaseCost.ReadOnly = readOnly;
            gtbMaintenanceCost.ReadOnly = readOnly;
            gtbUsefullLife.ReadOnly = readOnly;
            gtbElectricityConsumption.ReadOnly = readOnly;
            gtbDepreciation.ReadOnly = readOnly;
        }

        private void ConfigureDateControls(CrudMode mode)
        {
            bool editing =
                mode == CrudMode.Create ||
                mode == CrudMode.Edit;

            // Purchase Date
            gdtPurchase.Visible = editing;
            gtbPurchaseDate.Visible = !editing;

            if (!editing && mode != CrudMode.Empty)
                gtbPurchaseDate.Text = gdtPurchase.Value.ToString("dd/MM/yyyy");

            // Start Date
            gdtStartDate.Visible = editing;
            gtbStartDate.Visible = !editing;

            if (!editing && mode != CrudMode.Empty)
                gtbStartDate.Text = gdtStartDate.Value.ToString("dd/MM/yyyy");
        }

        private void ConfigureFocus(CrudMode mode)
        {
            if (mode == CrudMode.Create || mode == CrudMode.Edit)
            {
                gtbPrinterName.Focus();
            }
            else
            {
                gDataGridView.Focus();
            }
        }

        private void SetActionMode(CrudMode mode)
        {
            ConfigureEditors(mode);

            ConfigureDateControls(mode);

            ConfigureFocus(mode);

            SetFieldColors(mode);
        }

        private void SetFieldColors(CrudMode mode)
        {
            switch (mode)
            {
                case CrudMode.Read:

                    gtbAnnualCost.ForeColor = Color.Black;

                    gtbId.FillColor = _readOnlyTrueFillColor;
                    gtbId.BorderColor = _readOnlyTrueBorderColor;
                    gtbId.ForeColor = _readOnlyTrueForeColor;
                    gtbId.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbPrinterName.FillColor = _readOnlyTrueFillColor;
                    gtbPrinterName.BorderColor = _readOnlyTrueBorderColor;
                    gtbPrinterName.ForeColor = _readOnlyTrueForeColor;
                    gtbPrinterName.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gcbBrand.FillColor = _disabledFillColor;
                    gcbBrand.BorderColor = _disabledBorderColor;
                    gcbBrand.ForeColor = _disabledForeColor;
                    //gcbBrand.PlaceholderForeColor = _disabledTruePlaceHolderForeColor;

                    gdtPurchase.FillColor = _disabledFillColor;
                    gdtPurchase.BorderColor = _disabledBorderColor;
                    gdtPurchase.ForeColor = _disabledForeColor;
                    //gdtPurchase.PlaceholderForeColor = _disabledTruePlaceHolderForeColor;

                    gdtStartDate.FillColor = _disabledFillColor;
                    gdtStartDate.BorderColor = _disabledBorderColor;
                    gdtStartDate.ForeColor = _disabledForeColor;
                    //gdtStartDate.PlaceholderForeColor = _disabledTruePlaceHolderForeColor;

                    gtbPurchaseDate.FillColor = _readOnlyTrueFillColor;
                    gtbPurchaseDate.BorderColor = _readOnlyTrueBorderColor;
                    gtbPurchaseDate.ForeColor = _readOnlyTrueForeColor;
                    gtbPurchaseDate.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbStartDate.FillColor = _readOnlyTrueFillColor;
                    gtbStartDate.BorderColor = _readOnlyTrueBorderColor;
                    gtbStartDate.ForeColor = _readOnlyTrueForeColor;
                    gtbStartDate.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbPurchaseCost.FillColor = _readOnlyTrueFillColor;
                    gtbPurchaseCost.BorderColor = _readOnlyTrueBorderColor;
                    gtbPurchaseCost.ForeColor = _readOnlyTrueForeColor;
                    gtbPurchaseCost.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbMaintenanceCost.FillColor = _readOnlyTrueFillColor;
                    gtbMaintenanceCost.BorderColor = _readOnlyTrueBorderColor;
                    gtbMaintenanceCost.ForeColor = _readOnlyTrueForeColor;
                    gtbMaintenanceCost.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbUsefullLife.FillColor = _readOnlyTrueFillColor;
                    gtbUsefullLife.BorderColor = _readOnlyTrueBorderColor;
                    gtbUsefullLife.ForeColor = _readOnlyTrueForeColor;
                    gtbUsefullLife.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbElectricityConsumption.FillColor = _readOnlyTrueFillColor;
                    gtbElectricityConsumption.BorderColor = _readOnlyTrueBorderColor;
                    gtbElectricityConsumption.ForeColor = _readOnlyTrueForeColor;
                    gtbElectricityConsumption.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbDepreciation.FillColor = _readOnlyTrueFillColor;
                    gtbDepreciation.BorderColor = _readOnlyTrueBorderColor;
                    gtbDepreciation.ForeColor = _readOnlyTrueForeColor;
                    gtbDepreciation.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    break;
                case CrudMode.Edit:

                    gtbAnnualCost.ForeColor = Color.Black;

                    gtbId.FillColor = _readOnlyTrueFillColor;
                    gtbId.BorderColor = _readOnlyTrueBorderColor;
                    gtbId.ForeColor = _readOnlyTrueForeColor;
                    gtbId.PlaceholderForeColor = _readOnlyTruePlaceHolderForeColor;

                    gtbPrinterName.FillColor = _editFillColor;
                    gtbPrinterName.BorderColor = _editBorderColor;
                    gtbPrinterName.ForeColor = _editForeColor;
                    gtbPrinterName.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gcbBrand.FillColor = _enabledFillColor;
                    gcbBrand.BorderColor = _enabledBorderColor;
                    gcbBrand.ForeColor = _enabledForeColor;
                    //gcbBrand.PlaceholderForeColor = _enabledPlaceHolderForeColor;

                    gdtPurchase.FillColor = _enabledFillColor;
                    gdtPurchase.BorderColor = _enabledBorderColor;
                    gdtPurchase.ForeColor = _enabledForeColor;
                    //gdtPurchase.PlaceholderForeColor = _enabledPlaceHolderForeColor;

                    gdtStartDate.FillColor = _enabledFillColor;
                    gdtStartDate.BorderColor = _enabledBorderColor;
                    gdtStartDate.ForeColor = _enabledForeColor;
                    //gdtStartDate.PlaceholderForeColor = _enabledPlaceHolderForeColor;

                    gtbPurchaseDate.FillColor = _editFillColor;
                    gtbPurchaseDate.BorderColor = _editBorderColor;
                    gtbPurchaseDate.ForeColor = _editForeColor;
                    gtbPurchaseDate.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbStartDate.FillColor = _editFillColor;
                    gtbStartDate.BorderColor = _editBorderColor;
                    gtbStartDate.ForeColor = _editForeColor;
                    gtbStartDate.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbPurchaseCost.FillColor = _editFillColor;
                    gtbPurchaseCost.BorderColor = _editBorderColor;
                    gtbPurchaseCost.ForeColor = _editForeColor;
                    gtbPurchaseCost.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbMaintenanceCost.FillColor = _editFillColor;
                    gtbMaintenanceCost.BorderColor = _editBorderColor;
                    gtbMaintenanceCost.ForeColor = _editForeColor;
                    gtbMaintenanceCost.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbUsefullLife.FillColor = _editFillColor;
                    gtbUsefullLife.BorderColor = _editBorderColor;
                    gtbUsefullLife.ForeColor = _editForeColor;
                    gtbUsefullLife.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbElectricityConsumption.FillColor = _editFillColor;
                    gtbElectricityConsumption.BorderColor = _editBorderColor;
                    gtbElectricityConsumption.ForeColor = _editForeColor;
                    gtbElectricityConsumption.PlaceholderForeColor = _editPlaceHolderForeColor;

                    gtbDepreciation.FillColor = _editFillColor;
                    gtbDepreciation.BorderColor = _editBorderColor;
                    gtbDepreciation.ForeColor = _editForeColor;
                    gtbDepreciation.PlaceholderForeColor = _editPlaceHolderForeColor;

                    break;
            }
        }

        #endregion

        private string FormatDecimal(decimal valor)
        {
            return valor.ToString("N2", new CultureInfo("pt-BR"));
        }

        #region Events

        private void gDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _navigator.NotifyCurrent();
        }

        private void gtbPurchaseCost_Click(object sender, EventArgs e)
        {
            gtbPurchaseCost.SelectAll();
        }

        private void gtbPurchaseCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gtbPurchaseCost_Leave(object sender, EventArgs e)
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

        private void gtbPurchaseCost_TextChanged(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            string texto = txt.Text;

            // Remove caracteres que não sejam números ou vírgula
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^0-9,.]", "");

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

        private void gtbMaintenanceCost_Click(object sender, EventArgs e)
        {
            gtbMaintenanceCost.SelectAll();
        }

        private void gtbMaintenanceCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gtbMaintenanceCost_Leave(object sender, EventArgs e)
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

        private void gtbElectricityConsumption_Click(object sender, EventArgs e)
        {
            gtbElectricityConsumption.SelectAll();
        }

        private void gtbElectricityConsumption_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gtbElectricityConsumption_Leave(object sender, EventArgs e)
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

        private void gtbDepreciation_Click(object sender, EventArgs e)
        {
            gtbDepreciation.SelectAll();
        }

        private void gtbDepreciation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gtbDepreciation_Leave(object sender, EventArgs e)
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

        private void gtbUsefullLife_Click(object sender, EventArgs e)
        {
            gtbUsefullLife.SelectAll();
        }

        private void gtbUsefullLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            // Permite controle (Backspace etc)
            if (char.IsControl(e.KeyChar))
                return;

            // Permite números
            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;

        }

        private void gtbUsefullLife_Leave(object sender, EventArgs e)
        {

        }

        private void gtbUsefullLife_TextChanged(object sender, EventArgs e)
        {
            //para não permitir a inserção de caracteres não numéricos, mesmo que seja colado
            
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (System.Text.RegularExpressions.Regex.IsMatch(txt.Text, @"[^0-9.]"))
            {
                txt.Text = System.Text.RegularExpressions.Regex.Replace(txt.Text, @"[^0-9]", "");
                txt.SelectionStart = txt.Text.Length;
            }
            
        }

        private void gtbDepreciation_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void gtbDepreciation_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            string texto = txt.Text;

            // Remove caracteres que não sejam números ou vírgula
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^0-9,.]", "");

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

        private void gtbMaintenanceCost_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            string texto = txt.Text;

            // Remove caracteres que não sejam números ou vírgula
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^0-9,.]", "");

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

        private void gtbElectricityConsumption_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            string texto = txt.Text;

            // Remove caracteres que não sejam números ou vírgula
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^0-9,.]", "");

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

        private bool ConfirmDelete()
        {
            return DialogService.Confirm("Deseja realmente excluir este registro?");
        }

        private bool ConfirmCancel()
        {
            return DialogService.Confirm("Deseja realmente cancelar as alterações?");
        }

        private async void gbtCancel_Click(object sender, EventArgs e)
        {
            if (ConfirmCancel())
            {
                await CancelAsync();
            }
        }
        private void panelData_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gbtExit_Click(object sender, EventArgs e)
        {
        }

        private void gtbPrinterName_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void gcbBrand_Enter(object sender, EventArgs e)
        {
            if (gcbBrand.Tag != null && gcbBrand.Tag.ToString() == "READ")
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gdtPurchase_Enter(object sender, EventArgs e)
        {
        }

        private void gdtStartDate_Enter(object sender, EventArgs e)
        {
        }

        private void gdtPurchase_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void gdtPurchase_Click(object sender, EventArgs e)
        {
        }

        private void gdtPurchase_MouseEnter(object sender, EventArgs e)
        {
        }

        private void gdtPurchase_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void gDataGridView_SelectionChanged(object sender, EventArgs e)
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

        private void wtbPurchaseCost_Click(object sender, EventArgs e)
        {
        }

        private void wtbPurchaseCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

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

        private void wtbPurchaseCost_Leave(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

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

        private void wtbPurchaseCost_TextChanged(object sender, EventArgs e)
        {
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

        private void gDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

