using StormDashboard.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StormDashboard.Service.Models;

namespace StormDashboard.Service.Implementation
{
    public class HealthCheckService : IHealthCheckService
    {
        public HealthCheckResponse PerformHealthCheck()
        {
            return new HealthCheckResponse { Message = "UP" };
        }
    }
}
