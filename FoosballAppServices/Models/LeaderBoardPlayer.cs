using FoosballAppServices.ApiModels;

namespace FoosballAppServices.Models
{
    public class LeaderBoardPlayer
    {
        public int Rank { get; set; }
        public string Name => User != null ? User.Username : "Ukendt";
        public User User { get; set; }
    }
}