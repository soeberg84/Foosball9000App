﻿using System;
using System.Collections.Generic;

namespace FoosballAppServices.ApiModels
{
    public class User
    {
        public Guid Id { get; set; }
        
        public string Email { get; set; }

        public string Username { get; set; }

        public string GravatarEmail { get; set; }

        public string Password { get; set; }

        public List<string> Roles { get; set; }
    }
}
