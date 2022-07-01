using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWebCoreAspNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public PersonaController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        [Route("GetNombre")]
        public string Get()
        {
            return "Programación 3";
        }
    }
}
