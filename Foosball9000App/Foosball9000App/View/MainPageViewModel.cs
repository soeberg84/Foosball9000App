using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Foosball9000App.View
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            LeaderBoardViewModel = new LeaderBoardViewModel();
            StartMatchViewModel = new StartMatchViewModel();
        }
        public LeaderBoardViewModel LeaderBoardViewModel { get; set; }
        public StartMatchViewModel StartMatchViewModel { get; set; }
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
