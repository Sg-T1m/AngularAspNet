using AngularAspNet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AngularAspNet.Repository;
namespace AngularAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastsController : ControllerBase
      
    {
        RepositoryData repositoryData = new RepositoryData();
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
          };
       
        private readonly ILogger<WeatherForecastsController> _logger;
    
     
        public WeatherForecastsController(ILogger<WeatherForecastsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Component> Get()
        {
          

            //var Components = db.Components.Include(ComponentsType => ComponentsType.ComponentsType).ToList();
            //List<Component> test = db.Components.Include(c => c.ComponentsType).ToList();
            //List<ComponentsType> test2 = db.ComponentsTypes.Include(c => c.Components).ToList();
            return repositoryData.GetAllComponets();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecasts
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            //    Components = test(),



            //})
            //.ToArray();

        }
        [HttpGet("{id}")]
        public IEnumerable<Component> Get(int id)
        {
            return repositoryData.GetTypeData(id);

        }
        
       
        [HttpGet("all/{id}")]
        public IEnumerable<Compatibility> Getpivo(int id)
        {
            return repositoryData.GetCompatibiltesa(id);

        }
    }
}