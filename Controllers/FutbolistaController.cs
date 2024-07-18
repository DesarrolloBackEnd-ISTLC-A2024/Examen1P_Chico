﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examen1P_Chico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolistaController : ControllerBase
    {
        // GET: api/<FutbolistaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FutbolistaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FutbolistaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FutbolistaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FutbolistaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}