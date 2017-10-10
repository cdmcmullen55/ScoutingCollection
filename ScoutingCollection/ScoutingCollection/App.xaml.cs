using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ScoutingCollection
{
    public partial class App : Application
    {
        MainViewModel mainViewModel;

        public App()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            MainPage = new ScoutingCollection.MainPage(mainViewModel);
        }

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
    }
}
