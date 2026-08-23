using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public class NavigationService
    {
        private readonly Control _container;
        private readonly Dictionary<string, UserControl> _cache = new Dictionary<string, UserControl>();

        public NavigationService(Control container)
        {
            _container = container;
        }

        public void Navigate<T>(string key) where T : UserControl, new()
        {
            _container.SuspendLayout();
            _container.Controls.Clear();

            if (!_cache.ContainsKey(key))
            {
                var control = new T
                {
                    Dock = DockStyle.Fill
                };

                _cache[key] = control;
            }

            _container.Controls.Add(_cache[key]);
            _container.ResumeLayout();
        }
    }
}
