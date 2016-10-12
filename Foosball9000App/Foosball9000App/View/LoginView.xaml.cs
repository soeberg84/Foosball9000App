using System;
using Foosball9000App.Viewmodels;
using Xamarin.Forms;

namespace Foosball9000App.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
        
    }
}
