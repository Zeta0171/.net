using Business_layer.IBLs;
using Microsoft.AspNetCore.Mvc;
using Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly IBL_Personas bl;

        public PersonasController(IBL_Personas _bl)
        {
            bl = _bl;
        }

        // GET: PersonasController
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return bl.GetPersonas();
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public Persona Get(int id)
        {
            return bl.GetPersona(id);
        }

        // POST api/<PersonasController>
        [HttpPost]
        public Persona Post([FromBody] Persona persona)
        {
            return bl.AddPersona(persona);
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public Persona Put([FromBody] Persona persona)
        {
            return bl.UpdatePersona(persona);
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bl.DeletePersona(id);   
        }
    }
}
