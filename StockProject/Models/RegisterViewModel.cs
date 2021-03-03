﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockProject.Models
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordRpt { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
