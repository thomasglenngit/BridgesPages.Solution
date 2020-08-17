using Architecture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Architecture.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BridgesController : ControllerBase
  {
    private ArchitectureContext _db;

    public BridgesController(ArchitectureContext db)
    {
      _db = db;
    }

    // GET api/Bridges
    [HttpGet]
    public ActionResult<IEnumerable<Bridge>> Get()
    {
      var query = _db.Bridges.AsQueryable();

      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Bridge> Get(int id)
    {
        return _db.Bridges.FirstOrDefault(entry => entry.BridgeId == id);
    }

    // PUT api/Bridges/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Bridge bridge)
    {
        bridge.BridgeId = id;
        _db.Entry(bridge).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // POST api/Bridges
    [HttpPost]
    public void Post([FromBody] Bridge bridge)
    {
      _db.Bridges.Add(bridge);
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var bridgeToDelete = _db.Bridges.FirstOrDefault(entry => entry.BridgeId == id);
      _db.Bridges.Remove(bridgeToDelete);
      _db.SaveChanges();
    }
  }
}