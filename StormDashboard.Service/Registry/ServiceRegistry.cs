using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Configuration.DSL;
using StormDashboard.Service.Interfaces;
using StormDashboard.Service.Implementation;

namespace StormDashboard.Service.Registry
{
    public class ServiceRegistry
    {
        public ServiceRegistry()
        {
            //For<IHealthCheckService>().Use<HealthCheckService>();
        }
    }
}
