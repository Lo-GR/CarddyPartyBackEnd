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
        

        new Card {CardId = 1, Answer = "Card One", PlayerId = 1},
        new Card {CardId = 2, Answer = "Card Two", PlayerId = 2},
        new Card { CardId = 3, Answer = "Card Three", PlayerId = 1 },
        new Card { CardId = 4, Answer = "Card Four", PlayerId = 2 },
        new Card { CardId = 5, Answer = "Card Five", PlayerId = 1 },
        new Card { CardId = 6, Answer = "Card Six", PlayerId = 2 },
        new Card { CardId = 7, Answer = "Card Seven", PlayerId = 1 },
        new Card { CardId = 8, Answer = "Card Eight", PlayerId = 2 },
        new Card { CardId = 9, Answer = "Card Nine", PlayerId = 1 },
        new Card { CardId = 10, Answer = "Card Ten", PlayerId = 2 }
      );
    }
  }
}