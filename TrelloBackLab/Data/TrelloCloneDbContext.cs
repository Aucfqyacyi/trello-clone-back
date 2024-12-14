using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using TrelloBackLab.Infrastructure;
using TrelloBackLab.Models;

namespace TrelloBackLab.Data
{
    using Infrastructure;
    using Models;

    public class TrelloCloneDbContext :
        IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {

      public TrelloCloneDbContext(DbContextOptions<TrelloCloneDbContext> options) 
            : base(options)
      {
      }

      public DbSet<Board> Boards { get; set; }
      public DbSet<Card> Cards { get; set; }
      public DbSet<Column> Columns { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
          base.OnModelCreating(builder);

          builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      }
    }
}
