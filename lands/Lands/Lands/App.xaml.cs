﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lands
{
    using Views;

    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new NavigationPage(new LoginPage()));
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
