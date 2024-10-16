using Microsoft.AspNetCore.Mvc;
using Movies.API.EndpointsDocumentation;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet("GetWeatherForecast")]
        [DocumentationFileAttribute("Docs/GetHello.md")]
        public IEnumerable<WeatherForecast> GetHello()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetCurrentTime")]
        [DocumentationFileAttribute("Docs/GetGoodbye.md")]
        public IActionResult GetGoodbye()
        {
            return Ok(DateTime.UtcNow.ToLongTimeString());
        }

        [HttpGet("GetData")]
        public IActionResult GetData()
        {
            return Ok("This is the result");
        }
    }
}
