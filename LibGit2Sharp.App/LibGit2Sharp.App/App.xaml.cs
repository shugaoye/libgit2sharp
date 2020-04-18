using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LibGit2Sharp.App.Services;
using LibGit2Sharp.App.Views;

namespace LibGit2Sharp.App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
