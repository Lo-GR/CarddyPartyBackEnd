using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CarddyPartyBackEnd.Models
{
  public class Select
  {
    public int SelectId { get; set; }
    public int Player1Card {get; set;}
    public int Player2Card {get; set;}
    public int Player3Card {get; set;}
    public int Player4Card {get; set;}

  }
  
}