using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Foosball9000App.View
{
    public partial class StartMatchView : ContentPage
    {
        public StartMatchView()
        {
            InitializeComponent();
            BindingContext = new StartMatchViewModel();
        }

        private void StartMatchView_OnAppearing(object sender, EventArgs e)
        {
            ((StartMatchViewModel) BindingContext).LoadDataAsync();
        }
    }
}
