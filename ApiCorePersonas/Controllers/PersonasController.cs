using ApiCorePersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorePersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController()
        {
            this.personas = new List<Persona>
            {
                new Persona { IdPersona = 1, Nombre = "Sandra", Email = "sandra@g.es", Edad = 28 },
                new Persona { IdPersona = 2, Nombre = "Ferxo", Email = "ferxo@g.com", Edad = 23 },
                new Persona { IdPersona = 3, Nombre = "Sara", Email = "sara@g.de", Edad = 27 },
                new Persona { IdPersona = 4, Nombre = "David", Email = "david@g.os", Edad = 22 },
                new Persona { IdPersona = 5, Nombre = "Paco", Email = "paco@g.es", Edad = 46 },
            };
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> FindPersona(int id)
        {
            return this.personas.FirstOrDefault(x => x.IdPersona == id);
        }
    }
}
