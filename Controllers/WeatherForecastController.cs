using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
namespace Pizzas.API.Controllers{

        [ApiController]
        [Route("api/[controller]")]
        public class WeatherForecastController : ControllerBase
        {
            private static readonly string[] Summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            private readonly ILogger<WeatherForecastController> _logger;

            public WeatherForecastController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetWeatherForecast")]
            public IEnumerable<WeatherForecast> Get()
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }
        }

       /* public class PizzasControler : ControllerBase {
            [HttpGet]
            public IActionResult GetAll() {}

            [HttpGet("{id}")]
            public IActionResult GetById(int id) {}

            [HttpPost]
            public IActionResult Create(Pizza pizza) {}

            [HttpPut("{id}")]
            public IActionResult Update(int id, Pizza pizza) {}

            [HttpDelete("{id}")]
            public IActionResult  DeleteById(int id) {}
        }

}*/