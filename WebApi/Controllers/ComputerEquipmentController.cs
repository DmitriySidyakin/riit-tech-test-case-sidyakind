using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ComputerEquipmentController : ControllerBase
    {
        // GET: api/<ComputerEquipmentController>
        [HttpGet()]
        public IEnumerable<string> Get(string? filter, string? group, bool requireTotalCount, string? searchExpr, string? searchOperation, string? searchValue, int skip, string? sort, int take)
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/<ComputerEquipmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ComputerEquipmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComputerEquipmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComputerEquipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
