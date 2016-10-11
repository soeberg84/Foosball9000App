using System.ComponentModel;
using System.Runtime.CompilerServices;
using Foosball9000App.Viewmodels;

namespace Foosball9000App.View
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            LeaderBoardViewModel = new LeaderBoardViewModel();
            StartMatchViewModel = new StartMatchViewModel();
            LoginViewModel = new LoginViewModel();
        }
        public LeaderBoardViewModel LeaderBoardViewModel { get; set; }
        public StartMatchViewModel StartMatchViewModel { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
    }

    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
