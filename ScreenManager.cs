using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DFarmManager
{
    public class ScreenManager
    {
        private readonly Control _container;
        private readonly Dictionary<string, Form> _cache = new Dictionary<string, Form>();

        public ScreenManager(Control container)
        {
            _container = container;
        }

        public void Show<T>(string key) where T : Form, new()
        {
            Form screen;

            if (!_cache.ContainsKey(key))
            {
                screen = new T();
                Configure(screen);
                _cache[key] = screen;
            }
            else
            {
                screen = _cache[key];
            }

            _container.Controls.Clear();
            _container.Controls.Add(screen);
            screen.Show();
            screen.BringToFront();
        }

        private void Configure(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
        }
    }
}
