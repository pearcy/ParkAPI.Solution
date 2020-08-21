using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Http;
using ParkApi.Wrappers;


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


  [HttpGet]
   public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
   {
     var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
     var pagedData = await _db.Parks
       .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
       .Take(validFilter.PageSize)
       .ToListAsync();
     var totalRecords = await _db.Parks.CountAsync();
     return Ok(new PagedResponse<List<Park>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
   }

    [HttpGet("{id}")]
   public async Task<IActionResult> GetById(int id)
   {
     var park = await _db.Parks.Where(a => a.ParkId == id).FirstOrDefaultAsync();
     return Ok(new Response<Park>(park));
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