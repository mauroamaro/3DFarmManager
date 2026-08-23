using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _3DFarmManager.Framework.Crud;

namespace _3DFarmManager.Framework.Controls
{
    [ToolboxItem(true)]
    public class GActionButton : Guna2Button
    {
        private bool _actionEnabled = true;

        private Color _EnabledHoverFillColor;
        private Color _EnabledHoverBorderColor;
        private Color _EnabledHoverForeColor;

        #region Enabled Colors

        [Category("3DFarm")]
        [Description("Ação CRUD representada pelo botão.")]
        public CrudAction CrudAction
        {
            get;
            set;
        } = CrudAction.None;

        [Category("3DFarm")]
        public Color EnabledFillColor { get; set; }

        [Category("3DFarm")]
        public Color EnabledForeColor { get; set; }

        [Category("3DFarm")]
        public Color EnabledBorderColor { get; set; }

        #endregion

        #region Disabled Colors

        [Category("3DFarm")]
        public Color DisabledFillColor { get; set; }

        [Category("3DFarm")]
        public Color DisabledForeColor { get; set; }

        [Category("3DFarm")]
        public Color DisabledBorderColor { get; set; }

        [Category("3DFarm")]
        public Color DisabledHoverFillColor { get; set; }

        [Category("3DFarm")]
        public Color DisabledHoverForeColor { get; set; }

        [Category("3DFarm")]
        public Color DisabledHoverBorderColor { get; set; }

        #endregion

        #region Cursor

        [Category("3DFarm")]
        public Cursor EnabledCursor { get; set; }

        [Category("3DFarm")]
        public Cursor DisabledCursor { get; set; }

        #endregion

        #region Disabled Image

        [Category("3DFarm")]
        public Image DisabledImage { get; set; }

        [Category("3DFarm")]
        public Image EnabledImage { get; set; }

        #endregion

        [Browsable(false)]
        public bool ActionEnabled
        {
            get => _actionEnabled;

            set
            {
                if (_actionEnabled == value)
                    return;

                _actionEnabled = value;

                ApplyVisualState();
            }
        }

        public GActionButton()
        {
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            EnabledFillColor = FillColor;
            EnabledForeColor = ForeColor;
            EnabledBorderColor = BorderColor;

            DisabledFillColor = Color.FromArgb(225, 225, 225);
            DisabledForeColor = Color.FromArgb(120, 120, 120);
            DisabledBorderColor = Color.FromArgb(180, 180, 180);

            //DisabledHoverFillColor = HoverState.FillColor;
            //DisabledHoverForeColor = HoverState.ForeColor;
            //DisabledHoverBorderColor = HoverState.BorderColor;

            DisabledHoverFillColor = Color.FromArgb(179, 183, 204);
            DisabledHoverForeColor = Color.FromArgb(0, 0, 0);
            DisabledHoverBorderColor = Color.FromArgb(172, 239, 216);

            EnabledCursor = Cursors.Hand;
            DisabledCursor = Cursors.No;

            DisabledImage = null;

            ApplyVisualState();
        }

        private void ApplyVisualState()
        {
            if (_actionEnabled)
            {
                FillColor = EnabledFillColor;
                ForeColor = EnabledForeColor;
                BorderColor = EnabledBorderColor;

                HoverState.FillColor = _EnabledHoverFillColor;
                HoverState.ForeColor = _EnabledHoverForeColor;
                HoverState.BorderColor = _EnabledHoverBorderColor;

                Cursor = EnabledCursor;
                Image = EnabledImage;
            }
            else
            {
                FillColor = DisabledFillColor;
                ForeColor = DisabledForeColor;
                BorderColor = DisabledBorderColor;

                HoverState.FillColor = DisabledHoverFillColor;
                HoverState.ForeColor = DisabledHoverForeColor;
                HoverState.BorderColor = DisabledHoverBorderColor;

                Cursor = DisabledCursor;
                Image = DisabledImage;

            }

            Refresh();
        }

        protected override void OnClick(EventArgs e)
        {
            if (!_actionEnabled)
                return;

            base.OnClick(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            //
            // Nunca permitiremos que o controle fique realmente
            // desabilitado. Mantemos sempre Enabled = true para
            // preservar totalmente a aparência.
            //
            if (!DesignMode && !Enabled)
                Enabled = true;

            base.OnEnabledChanged(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            EnabledFillColor = FillColor;
            EnabledForeColor = ForeColor;
            EnabledBorderColor = BorderColor;

            EnabledImage = Image;

            _EnabledHoverFillColor = HoverState.FillColor;
            _EnabledHoverBorderColor = HoverState.BorderColor;
            _EnabledHoverForeColor = HoverState.ForeColor;

            ApplyVisualState();
        }

        public void EnableAction()
        {
            ActionEnabled = true;
        }

        public void DisableAction()
        {
            ActionEnabled = false;
        }

        public void Toggle()
        {
            ActionEnabled = !ActionEnabled;
        }


    }
}
