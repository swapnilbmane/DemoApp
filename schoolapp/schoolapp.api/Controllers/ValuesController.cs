using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using schoolapp.api.models;

namespace schoolapp.api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext context)
        {
            _context = context;

            if (_context.Students.Count() == 0)
            {
                _context.Students.Add(new Student { FirstName = "Item1" });
                _context.SaveChanges();
            }
        }       

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
