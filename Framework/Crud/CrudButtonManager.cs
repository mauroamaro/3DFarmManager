using _3DFarmManager.Framework.Controls;
using _3DFarmManager.Framework.Models.Base;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3DFarmManager.Framework.Crud
{
    public class CrudButtonManager
    {
        private readonly Dictionary<CrudAction, GActionButton> _buttons =
            new Dictionary<CrudAction, GActionButton>();

        public CrudButtonManager(Control container)
        {
            RegisterButtons(container);
        }

        public CrudButtonManager(params GActionButton[] buttons)
        {
            foreach (var button in buttons)
                Register(button);
        }

        private void RegisterButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                GActionButton button = control as GActionButton;

                if (button != null)
                    Register(button);

                if (control.HasChildren)
                    RegisterButtons(control);
            }
        }

        private void Register(GActionButton button)
        {
            if (button.CrudAction == CrudAction.None)
                return;

            _buttons[button.CrudAction] = button;
        }

        /// <summary>
        /// Aplica o estado dos botões.
        /// </summary>
        public void Apply(CrudViewState state)
        {
            Set(CrudAction.Insert, state.CanAdd);
            Set(CrudAction.Edit, state.CanEdit);
            Set(CrudAction.Delete, state.CanDelete);
            Set(CrudAction.Save, state.CanSave);
            Set(CrudAction.Cancel, state.CanCancel);

            // Caso exista botão Refresh:
            Set(CrudAction.Refresh, state.CanRefresh);
        }

        private void Set(CrudAction action, bool enabled)
        {
            GActionButton button;

            if (_buttons.TryGetValue(action, out button))
                button.ActionEnabled = enabled;
        }

        public void EnableAll()
        {
            foreach (GActionButton button in _buttons.Values)
                button.ActionEnabled = true;
        }

        public void DisableAll()
        {
            foreach (GActionButton button in _buttons.Values)
                button.ActionEnabled = false;
        }

        public GActionButton GetButton(CrudAction action)
        {
            GActionButton button;

            if (_buttons.TryGetValue(action, out button))
                return button;

            return null;
        }

        public bool Contains(CrudAction action)
        {
            return _buttons.ContainsKey(action);
        }

        public void RefreshButtons()
        {
            foreach (GActionButton button in _buttons.Values)
                button.Refresh();
        }
    }
}
