using _3DFarmManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{

    public partial class formMain : Form
    {

        // Import CreateRoundRectRgn from gdi32.dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse (controls horizontal radius)
            int nHeightEllipse // height of ellipse (controls vertical radius)
        );

        //private readonly ScreenManager screenManager;
        private NavigationService _navigation;

        //UC_DashBoard ucDash = new UC_DashBoard();
        //UC_User ucUser = new UC_User();
        //UC_3DPrinter uc3DPrinter = new UC_3DPrinter();
        //UC_Setup ucSetup = new UC_Setup();
        //UC_Filaments ucFilaments = new UC_Filaments();
        //UC_License ucLicense = new UC_License();

        public formMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 50;

            // Apply a 30-pixel corner radius to the window region
            int radius = 30;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));

            _navigation = new NavigationService(MainContentPanel);

            // Tela inicial
            //_navigation.Navigate<UC_DashBoard>("dashboard");
            //_navigation.Navigate<UC_Home>("home");
        }
        public void ContentPanel_AddUserControl(UserControl uc)
        {
            // 1. Limpa qualquer controle que já esteja no painel
            if (MainContentPanel.Controls.Count > 0)
                MainContentPanel.Controls.Clear();

            // 2. Faz o UserControl preencher todo o espaço do painel
            uc.Dock = DockStyle.Fill;

            // 3. Adiciona ao painel e traz para a frente (garante visibilidade)
            MainContentPanel.Controls.Add(uc);
            uc.BringToFront();

            // Exemplo de uso:
            // screenManager.Show<formDashBoard>("dashboard");
            // ContentPanel_AddUserControl(ucDash);
        }

        private void gbtDashboard_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_DashBoard>("dashboard");
        }

        private void gbtUsers_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_Users>("users");
        }

        private void gbtPrinters_Click(object sender, EventArgs e)
        {
            _navigation.Navigate<UC_3DPrinters>("printers");
        }

        private void gbtConfig_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtFilament_Click(object sender, EventArgs e)
        {
            _navigation.Navigate<UC_Filaments>("filaments");
        }

        private void gbtLicense_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtSuppliers_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtBrands_Click(object sender, EventArgs e)
        {
            _navigation.Navigate<UC_Brands>("brands");
        }

        private void gbtPurchaseOrders_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtProducts_Click(object sender, EventArgs e)
        {
            _navigation.Navigate<UC_ProductsGroup>("productsgroup");
        }

        private void gbtProduction_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }
        private void gbtSaleOrders_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtPresets_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtECommerce_Click(object sender, EventArgs e)
        {
            //_navigation.Navigate<UC_UnderContruction>("underconstruction");
        }

        private void gbtExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtExpenses_Click(object sender, EventArgs e)
        {
            _navigation.Navigate<UC_Expenses>("expenses");
        }
    }
}
