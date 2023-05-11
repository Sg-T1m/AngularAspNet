using Microsoft.AspNetCore.Mvc;
using AngularAspNet.Model;
using AngularAspNet.Repository;

namespace AngularAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeComponentsController : ControllerBase
    {
        RepositoryData repositoryData = new RepositoryData();
        [HttpGet]
        public IEnumerable<Component> Get()
        {
            return repositoryData.GetTypeData(2);
        }
        [HttpGet("{id}")]
        public IEnumerable<Component> Get(int id)
        {
           return repositoryData.GetTypeData(id);
        }
    }
}
