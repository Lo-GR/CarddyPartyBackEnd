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
        new Card {CardId = 1, Answer = "Card One"},
        new Card {CardId = 2, Answer = "Card Two"},
        new Card { CardId = 3, Answer = "Card Three" },
        new Card { CardId = 4, Answer = "Card Four" },
        new Card { CardId = 5, Answer = "Card Five" },
        new Card { CardId = 6, Answer = "Card Six" },
        new Card { CardId = 7, Answer = "Card Seven" },
        new Card { CardId = 8, Answer = "Card Eight" },
        new Card { CardId = 9, Answer = "Card Nine" },
        new Card { CardId = 10, Answer = "Card Ten" }
      );
    }
  }
}