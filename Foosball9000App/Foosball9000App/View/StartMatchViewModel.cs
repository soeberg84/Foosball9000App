using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FoosballAppServices;

namespace Foosball9000App.View
{
    public class StartMatchViewModel : BaseViewModel
    {
        private FoosballServices service = null;

        private ObservableCollection<Player> _players;

        public StartMatchViewModel()
        {
            service = new FoosballServices();
        }

        public ObservableCollection<Player> Players
        {
            get { return _players; }
            set { _players = value; RaisePropertyChanged(); }
        }

        public void LoadDataAsync()
        {
            Players = new ObservableCollection<Player>()
            {
                new Player() {Name = "Player 1"},
                new Player() {Name = "Player 2"},
                new Player() {Name = "Player 3"},
            };
        }
    }

    public class Player
    {
        public string Name { get; set; }
    }
}