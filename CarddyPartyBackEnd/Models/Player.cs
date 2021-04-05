using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CarddyPartyBackEnd.Models
{
  public class Player
  {
    public int PlayerID { get; set; }
    [Required]
    public string Name { get; set; }
    public int Points { get; set; }
    public virtual ICollection<Card> Cards { get; set; }

    public Player()
    {
      this.Cards = new HashSet<Card>();
    }
  }
}


  // public class Place
  // {
  //   public int PlaceId { get; set; }
  //   public string Country { get; set; }
  //   public string City { get; set; }

  //   public virtual ICollection<Review> Reviews { get; set; }
  //   public Place()
  //   {
  //     this.Reviews = new HashSet<Review>();
  //   }