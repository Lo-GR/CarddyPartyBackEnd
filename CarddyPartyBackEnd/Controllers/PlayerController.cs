using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarddyPartyBackEnd.Models;
using System.Reflection;

namespace CarddyPartyBackEnd.Controllers
{
  public class PlayersController : ControllerBase
  {
    private readonly CarddyPartyBackEndContext _db;
    public PlayersController(CarddyPartyBackEndContext db)
    {
      _db = db;
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Player>> GetPlayer(int id)
    {
        var player = await _db.Players.FindAsync(id);
        if (player == null)
        {
            return NotFound();
        }
        return player;
    }
    [HttpPost]
    public async Task<ActionResult<Player>> Post(Player player)
    {
      _db.Players.Add(player);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPlayer), new { id = player.PlayerId }, player);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayer(int id)
    {
      var player = await _db.Players.FindAsync(id);
      if (player == null)
      {
        return NotFound();
      }
      _db.Players.Remove(player);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}