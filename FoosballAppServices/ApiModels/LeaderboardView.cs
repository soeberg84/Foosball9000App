﻿using System;
using System.Collections.Generic;

namespace FoosballAppServices.ApiModels
{
    public class LeaderboardView
    {
        public LeaderboardView()
        {
            Id = Guid.NewGuid();
            Entries = new List<LeaderboardViewEntry>();
            Timestamp = DateTime.UtcNow;
        }
        
        public Guid Id { get; set; }
        public List<LeaderboardViewEntry> Entries { get; set; }
        public string SeasonName { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}