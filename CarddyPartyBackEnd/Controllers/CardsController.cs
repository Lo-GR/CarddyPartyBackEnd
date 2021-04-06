using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarddyPartyBackEnd.Models;

namespace CarddyPartyBackEnd
{
  [Route("api/[controller]")]
  [ApiController]
  public class CardsController : ControllerBase
  {
    private readonly CarddyPartyBackEndContext _db;

    public CardsController(CarddyPartyBackEndContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Card>>> Get()
    {
      var query = _db.Cards.AsQueryable();
      return await query.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Card>> GetCard(int id)
    {
        var card = await _db.Cards.FindAsync(id);
        if (card == null)
        {
            return NotFound();
        }
        return card;
    }
    [HttpPost]
    public async Task<ActionResult<Card>> Post(Card card)
    {
      _db.Cards.Add(card);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCard), new { id = card.CardId }, card);
    }
  }
}