using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FoosballAppServices.Models;
using static Newtonsoft.Json.JsonConvert;

namespace FoosballAppServices
{
    public class FoosballServices
    {
        public async Task<List<LeaderBoardPlayer>> GetLeaderBoardPlayers()
        {
            var boards = await GetLeaderboards();
            var rankedPlayers = new List<LeaderBoardPlayer>();
            var leaderboard = boards.Single(b => b.SeasonName == "Season 3");
            var players = leaderboard.Entries.OrderByDescending(e => e.EloRating);
            int rank = 0;
            foreach (var p in players)
            {
                rank++;
                rankedPlayers.Add(new LeaderBoardPlayer()
                {
                    Name = p.UserName,
                    Rank = rank
                });
            }

            return rankedPlayers;
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
    }
}
