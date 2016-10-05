using System.Collections.ObjectModel;
using System.Linq;
using FoosballAppServices;
using FoosballAppServices.ApiModels;
using FoosballAppServices.Models;

namespace Foosball9000App.View
{
    public class LeaderBoardViewModel : BaseViewModel
    {
        private FoosballServices service = null;

        public LeaderBoardViewModel()
        {
            IsBusy = true;
            service = new FoosballServices();
            Players = new ObservableCollection<LeaderBoardPlayer>();
        }

        public ObservableCollection<LeaderBoardPlayer> Players
        {
            get { return _players; }
            set { _players = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<LeaderBoardPlayer> _players;
        public async void LoadDataAsync()
        {
            var players = await service.GetLeaderBoardPlayers();
           Players = new ObservableCollection<LeaderBoardPlayer>(players);
            IsBusy = false;


        }
    }
}