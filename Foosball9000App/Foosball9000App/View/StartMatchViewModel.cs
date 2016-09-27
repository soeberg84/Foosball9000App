using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Foosball9000App.View
{
    public class StartMatchViewModel : BaseViewModel
    {
        private ObservableCollection<Player> _players;

        public StartMatchViewModel()
        {
            
        }

        public ObservableCollection<Player> Players
        {
            get { return _players; }
            set { _players = value; RaisePropertyChanged("Players"); }
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