using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BetterConsoleApp
{

    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation($"Run number {i}");
                _log.LogError("Run number",i);
                _log.LogWarning("Run number");
                _log.LogCritical($"Run number {i}");
            }

            var result = new List<string>();
            result.Add("Hello");
            result.Add("World!");
            result.Add("My");
            result.Add("name");
            result.Add("is");
            result.Add("...");
            result.Add("Francesco");
            result.Add("Virgulini");
            result.Add("and this code is working correctly!");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}