using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return "HelloWorld";
        }
    }
}
