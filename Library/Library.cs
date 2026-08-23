using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Library
{
    public class Library
    {

        public bool IsNumeric(int keyCode)
        {
            // Digits 0-9 (main keyboard and numpad)
            return (keyCode >= 48 && keyCode <= 57) || (keyCode >= 96 && keyCode <= 105);
        }

    }
}
