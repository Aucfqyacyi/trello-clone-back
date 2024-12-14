using System;
using Microsoft.AspNetCore.Identity;

namespace TrelloBackLab.Infrastructure
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
    }
}