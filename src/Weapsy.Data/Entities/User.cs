﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Weapsy.Domain.Users;

namespace Weapsy.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string Surname { get; set; }
        public UserStatus Status { get; set; }
    }
}
