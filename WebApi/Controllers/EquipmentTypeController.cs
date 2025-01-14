using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.DB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentTypeController : ControllerBase
    {
        // GET: api/<EquipmentTypeController>
        [HttpGet]
        public IEnumerable<EquipmentType> Get()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var eqTypes = db.EquipmentType.ToList();

                return eqTypes;
            }
        }

        // GET api/<EquipmentTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EquipmentTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EquipmentTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EquipmentTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
