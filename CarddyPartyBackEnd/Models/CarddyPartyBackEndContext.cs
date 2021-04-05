using Microsoft.EntityFrameworkCore;

namespace CarddyPartyBackEnd.Models
{
  public class CarddyPartyBackEndContext : DbContext
  {
    public CarddyPartyBackEndContext (DbContextOptions options)
      : base(options)
      {
      }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}