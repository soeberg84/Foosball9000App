using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Foosball9000App.View;
namespace Foosball9000App
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MainPageView()
            {
                BindingContext = new MainPageViewModel()
            };
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
