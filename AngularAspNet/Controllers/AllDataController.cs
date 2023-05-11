using AngularAspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using AngularAspNet.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllDataController : ControllerBase
    {
        RepositoryData repositoryData = new RepositoryData();
        // GET: api/<AllDataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AllDataController>/5
        [HttpGet("{id}")]
        public IEnumerable<Component> Get(int id)
        {
            return repositoryData.GetTypeData(id);
     
        }

        // POST api/<AllDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AllDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AllDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
