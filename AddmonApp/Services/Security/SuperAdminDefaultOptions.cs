﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddmonApp.Services.Security
{
    //special class to capture super admin options from appsettings.json
    public class SuperAdminDefaultOptions
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}