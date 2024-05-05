using AlgorithmsInC_.Sorting;

namespace AlgorithmsInC_
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!stoppingToken.IsCancellationRequested)
            {
                int[] arr = new int[4000];
               var sortedArray= BubbleSorting.SortTheArray(arr);
                foreach (int i in sortedArray)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}