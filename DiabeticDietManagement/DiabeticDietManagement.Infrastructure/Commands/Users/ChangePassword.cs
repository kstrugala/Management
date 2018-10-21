﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiabeticDietManagement.Infrastructure.Commands.Users
{
    public class ChangePassword : ICommand
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
