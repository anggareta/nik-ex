using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  //[Route("api/[controller]")]
  [Route("api")]
  public class ValuesController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "ayus", "anggareta" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    [HttpGet("user")]
    public string Get(int id)
    {
      return "Ayus";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}