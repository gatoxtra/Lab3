using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using demoLab3.Services;
using demoLab3.Views;

namespace demoLab3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
