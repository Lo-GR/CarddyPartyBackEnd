using Microsoft.EntityFrameworkCore;

namespace CarddyPartyBackEnd.Models
{
  public class CarddyPartyBackEndContext : DbContext
  {
    public CarddyPartyBackEndContext(DbContextOptions options)
      : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
    public DbSet<Player> Players { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Prompt> Prompts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Card>().HasData(
        new Card { CardId = 1, Answer = "Card One", PlayerID = 1 },
        new Card { CardId = 2, Answer = "Card Two", PlayerID = 2 },
        new Card { CardId = 3, Answer = "Card Three", PlayerID = 1 },
        new Card { CardId = 4, Answer = "Card Four", PlayerID = 2 },
        new Card { CardId = 5, Answer = "Card Five", PlayerID = 1 },
        new Card { CardId = 6, Answer = "Card Six", PlayerID = 2 },
        new Card { CardId = 7, Answer = "Card Seven", PlayerID = 1 },
        new Card { CardId = 8, Answer = "Card Eight", PlayerID = 2 },
        new Card { CardId = 9, Answer = "Card Nine", PlayerID = 1 },
        new Card { CardId = 10, Answer = "Card Ten", PlayerID = 2 }
      );

      builder.Entity<Player>().HasData(
        new Player { PlayerID = 1, Name = "P1", Points = 0 },
        new Player { PlayerID = 2, Name = "P2", Points = 0 },
        new Player { PlayerID = 3, Name = "P3", Points = 0 },
        new Player { PlayerID = 4, Name = "P4", Points = 0 }
      );

      builder.Entity<Prompt>().HasData(
        new Prompt { PromptId = 1, Description = "This is example 1" },
        new Prompt { PromptId = 2, Description = "This is example 2" },
        new Prompt { PromptId = 3, Description = "This is example 3" },
        new Prompt { PromptId = 4, Description = "This is example 4" },
        new Prompt { PromptId = 5, Description = "This is example 5" }
      );
    }
  }
}