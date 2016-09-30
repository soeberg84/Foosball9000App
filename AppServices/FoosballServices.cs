using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AppServices.Models;

using static Newtonsoft.Json.JsonConvert;

namespace AppServices
{
    public class FoosballServices
    {
        public async Task<List<LeaderboardView>> GetLeaderboard()
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
