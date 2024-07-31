using Examen1P_Chico.Comunes;
using Examen1P_Chico.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examen1P_Chico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolistaController : ControllerBase
    {
        // GET: api/<FutbolistaController>
        [HttpGet]
        public List<Futbolista> Get()
        {
            return ConexionBD.GetFutbolistas();
        }

        // GET api/<FutbolistaController>/5
        [HttpGet("{cedula}")]
        public Futbolista Get(string cedula)
        {
            return ConexionBD.GetFutbolista(cedula);
        }

        // POST api/<FutbolistaController>
        [HttpPost]
        public void Post([FromBody] Futbolista objJugador)
        {
            ConexionBD.PostFutbolista(objJugador);
        }

        // PUT api/<FutbolistaController>/5
        [HttpPut("{cedula}")]
        public void Put(string cedula, [FromBody] Futbolista objJugador)
        {
            ConexionBD.PutFutbolista(cedula, objJugador);
        }

        // DELETE api/<FutbolistaController>/5
        [HttpDelete("{cedula}")]
        public void Delete(string cedula)
        {
            ConexionBD.DeleteFutbolista(cedula);
        }
    }
}
