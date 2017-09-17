using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog.Configuration;
using Serilog.Formatting.Json;

namespace StormDashboard.Api.Logging
{
    public static class LogingConfiguration
    {
        public static void BuildLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.RollingFile("C:\\Logs\\StromeDashboardLogs.txt")
                .WriteTo.Console(new JsonFormatter())
                .WriteTo.Trace()
                .CreateLogger();
        }
    }
}