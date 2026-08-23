using _3DFarmManager.Framework.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Framework.Models.Base
{
    public class CrudViewState
    {
        public bool CanAdd { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

        public bool CanSave { get; set; }

        public bool CanCancel { get; set; }

        public bool CanExit { get; set; }

        public bool CanRefresh { get; set; }

        public CrudButtonState Buttons { get; } = new CrudButtonState();
    }
}
