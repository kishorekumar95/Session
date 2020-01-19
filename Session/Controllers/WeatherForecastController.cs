using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Session.Controllers
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
        private readonly BussinessLogicLayer _bussinessLogicLayer;
        //private readonly IHttpContextAccessor _contextAccessor;
        //private ISession _session => _contextAccessor.HttpContext.Session;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHttpContextAccessor http, BussinessLogicLayer bussinessLogicLayer)
        {
            _logger = logger;
            //_contextAccessor = http;
            _bussinessLogicLayer = bussinessLogicLayer;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  


            var rng = new Random();

            //BAL.PageLoad();
            //_session.SetString("Test", "Ben Rules!");

            //var message = _session.GetString("Test");
            _bussinessLogicLayer.PageLoad();

            var sessionVariable = _bussinessLogicLayer.PageLoadOne();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
