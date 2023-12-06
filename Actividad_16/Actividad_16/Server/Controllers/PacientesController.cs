using Microsoft.AspNetCore.Mvc;
using Actividad_16.Client.Pages;
using Actividad_16.Shared;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Actividad_16.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Pacientes> Get()
        {
            List<Pacientes> list = new List<Pacientes>()
            {
                new Pacientes() { nombre = "Juan Pérez", direccion = "Calle 10 #20-30", correo = "juanperez@gmail.com", ns = "123456789" },
                new Pacientes() { nombre = "María González", direccion = "Carrera 5 #15-25", correo = "mariagonzalez@hotmail.com", ns = "987654321" },
                new Pacientes() { nombre = "Pedro Ramirez", direccion = "Avenida 8 #12-50", correo = "pedroramirez@yahoo.com", ns = "456123789" },
                new Pacientes() { nombre = "Ana Torres", direccion = "Calle 15 #25-10", correo = "anatorres@gmail.com", ns = "789456123" },
                new Pacientes() { nombre = "Luisa Gómez", direccion = "Carrera 12 #18-30", correo = "luisagomez@gmail.com", ns = "321654987" }
            };
            return list;
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
