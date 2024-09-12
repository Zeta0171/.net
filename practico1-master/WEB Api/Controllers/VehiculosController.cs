using Microsoft.AspNetCore.Mvc;
using Business_layer.IBLs;
using Shared;
using DAL.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly IBL_Vehiculo bl;

        public VehiculosController(IBL_Vehiculo _bl)
        {
            bl = _bl;
        }

        // GET: api/<VehiculosController>
        [HttpGet]
        public IEnumerable<Vehiculos> Get()
        {
            return bl.GetVehiculos();
        }

        // GET api/<VehiculosController>/5
        [HttpGet("{id}")]
        public Vehiculos Get(int id)
        {
            return bl.GetVehiculo(id);
        }

        // POST api/<VehiculosController>
        [HttpPost]
        public Vehiculos Post([FromBody] Vehiculos vehiculo)
        {
            return bl.AddVehiculo(vehiculo);
        }

        // PUT api/<VehiculosController>/5
        [HttpPut("{id}")]
        public Vehiculos Put(int id, [FromBody] Vehiculos vehiculo)
        {
            return bl.UpdateVehiculo(vehiculo);
        }

        // DELETE api/<VehiculosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bl.DeleteVehiculo(id);
        }
    }
}
