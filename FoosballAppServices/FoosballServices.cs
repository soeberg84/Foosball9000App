using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FoosballAppServices.ApiModels;
using FoosballAppServices.Models;
using static Newtonsoft.Json.JsonConvert;

namespace FoosballAppServices
{
    public class FoosballServices
    {
        public async Task<List<LeaderBoardPlayer>> GetLeaderBoardPlayers()
        {
            var boards = await GetLeaderboards();
            await LoadUsers();
            var rankedPlayers = new List<LeaderBoardPlayer>();
            var leaderboard = boards.Single(b => b.SeasonName == "Season 3");
            var players = leaderboard.Entries.OrderByDescending(e => e.EloRating);
           
            int rank = 0;
            foreach (var p in players)
            {
                rank++;
                rankedPlayers.Add(new LeaderBoardPlayer()
                {
                    User = GetUserFromEmail(p.UserName),
                    Rank = rank
                });
            }

            return rankedPlayers;
        }

        private User GetUserFromEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
       
        private async Task<List<LeaderboardView>> GetLeaderboards()
        {
            using (var client = new HttpClient())
            {
                var leaderboardUrl = "http://foosball9000api.sovs.net/api/leaderboard/index";

                var url = string.Format(leaderboardUrl);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return DeserializeObject<List<LeaderboardView>>(json);
            }
        }

        private List<User> _users = null; // chache in SQLite
        private async Task LoadUsers()
        {
            using (var client = new HttpClient())
            {
                var leaderboardUrl = "http://foosball9000api.sovs.net/api/Player/GetUsers";

                var url = string.Format(leaderboardUrl);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return;

                _users = DeserializeObject<List<User>>(json);
            }
        }
    }
}
