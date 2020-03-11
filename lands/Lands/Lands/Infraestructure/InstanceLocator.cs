using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infraestructure
{
    using ViewModels;

    class InstanceLocator
    {
        #region Properties
        public MainViewModels Main
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public InstanceLocator()
        {
            this.Main = new MainViewModels();
        }
        #endregion
    }
}
