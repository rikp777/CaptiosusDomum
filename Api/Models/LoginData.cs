﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LoginData
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginData(string username, string password, string pincode)
        {
            this.username = username;
            this.password = password;
        }
    }
}
