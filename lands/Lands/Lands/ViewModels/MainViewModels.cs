using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    public class MainViewModels
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Contructores
        public MainViewModels()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
