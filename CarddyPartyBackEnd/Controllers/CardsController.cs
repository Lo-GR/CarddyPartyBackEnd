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
  }
}