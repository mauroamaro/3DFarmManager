using System.Collections.Generic;

namespace _3DFarmManager.Framework.Crud
{
    public class CrudButtonState
    {
        private readonly Dictionary<CrudAction, bool> _states =
            new Dictionary<CrudAction, bool>();

        public bool this[CrudAction action]
        {
            get
            {
                bool value;

                if (_states.TryGetValue(action, out value))
                    return value;

                return false;
            }

            set
            {
                _states[action] = value;
            }
        }

        public void Clear()
        {
            _states.Clear();
        }
    }
}
