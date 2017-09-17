using Serilog;
using StormDashboard.Service.Implementation;
using StormDashboard.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StormDashboard.Api.Controllers
{
    [Route("health")]
    public class HealthController : ApiController
    {
        private readonly IHealthCheckService _healthCheckService;

        public HealthController(IHealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            Log.Information("health end pit get method called");
            return Ok(_healthCheckService.PerformHealthCheck());
        }
    }
}
