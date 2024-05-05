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
                int[] arr = {2,6,7,9,100,1};
                Console.WriteLine("=================Array before sorting =======================");
                foreach (int i in arr)
                {
                    Console.Write(" "+i+" ");
                }
                Console.WriteLine();
                var sortedArray= BubbleSorting.SortTheArray(arr);

               
                Console.WriteLine("=================Array After sorting =======================");
                foreach (int i in sortedArray)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine() ;

            }
        }
    }
}