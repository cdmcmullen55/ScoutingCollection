using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ScoutingCollection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppCenter.Start("ios=b4e78342-6a5e-4eb5-8c9f-bb0084c9bc3b;" + "uwp=f066777d-a34d-4c46-b2ae-39e025a84f32;" +
                   "android=adfaa195-15a7-4d69-b1f9-46ada6342f5c;",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ScoutingCollection.MainPage();
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
