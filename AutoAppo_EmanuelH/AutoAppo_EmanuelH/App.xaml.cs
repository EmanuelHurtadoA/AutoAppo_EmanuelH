using AutoAppo_EmanuelH.Services;
using AutoAppo_EmanuelH.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoAppo_EmanuelH
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AppoLoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
