﻿using System;

namespace FoosballAppServices.ApiModels
{
    public class Season
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
