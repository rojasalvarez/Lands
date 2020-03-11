

namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {

        #region Atributos        
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private string email;
        #endregion

        #region Propiedades
        public string Email
        {
            get { return this.email;}
            set { SetValue(ref this.email, value);}
        }

        public string Password
        {
            get{return this.password;}
            set{SetValue(ref this.password, value);}
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemenbered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            this.IsRemenbered = true;
            this.isEnabled = true;

            this.Email = "rojasalvarez@gmail.com";
            this.Password = "1234";
        }
        #endregion

        #region Commands
        public ICommand IngresarCommand
        {
            get
            {
                return new RelayCommand(Ingresar);
            }
        }

        private async void Ingresar()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingrese el Email",
                    "Acceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingrese el Password",
                    "Acceptar");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "rojasalvarez@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Password Incorrecto",
                    "Acceptar");

                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                    "OK",
                    "Datos Correctos",
                    "Acceptar");
        }
        #endregion
    }
}
