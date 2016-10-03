using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Foosball9000App.View
{
    public partial class LeaderBoardView : ContentPage
    {
        public LeaderBoardView()
        {
            InitializeComponent();
            BindingContext = new LeaderBoardViewModel();
            Appearing +=OnAppearing;
        }

        private void OnAppearing(object sender, EventArgs eventArgs)
        {
            ((LeaderBoardViewModel)BindingContext).LoadDataAsync();
        }

        private void RefreshButton_Clicked(object sender, EventArgs e)
        {
            ((LeaderBoardViewModel)BindingContext).LoadDataAsync();
        }
    }
}
