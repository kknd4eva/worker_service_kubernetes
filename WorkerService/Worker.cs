using WorkerService.Services;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IFelineService _felineService;

        public Worker(ILogger<Worker> logger, IFelineService felineService)
        {
            _logger = logger;
            _felineService = felineService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var fact = await _felineService.GetFelineFact();
                _logger.LogInformation("Meow! Cat fact found: {fact}", fact.Fact);
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}