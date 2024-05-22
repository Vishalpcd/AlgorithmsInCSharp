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
                Console.WriteLine("====================Bubble Sort==============");
                Helper.PrintBefore(arr);
                var sortedArray= BubbleSorting.SortTheArray(arr);
                Helper.PrintAfter(sortedArray);

                int[] arr1 = { 2, 6, 7, 9, 100, 1 };
                Console.WriteLine("====================Insertion Sort==============");
                Helper.PrintBefore(arr1);
                var insertionSortedArray = InsertionSort.SortTheArray(arr1);
                Helper.PrintAfter(insertionSortedArray);

            }
        }
    }
}