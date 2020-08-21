using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParkApiContext _db;

    public ParksController(ParkApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string parkname, string state, string type)
    {
      var query = _db.Parks.AsQueryable();

      if (parkname != null)
      {
        query = query.Where(entry => entry.ParkName == parkname);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }


      return query.ToList();

    }

    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }


    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
    return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

  }
}