using System;
using System.Threading.Tasks;

namespace BenchmarkApp
{
    class Program
    {
        private static readonly int[] MemorySizes = { 128, 256, 512, 1024, 2048, 3008 };
        
        static async Task Main(string[] args)
        {
            var functionName = args[0];
            var measurement = new ColdStartMeasurement(functionName);

            Console.WriteLine($"Measuring cold start for function {functionName}.");
            
            foreach (var memorySize in MemorySizes)
            {
                var coldStartTime = await measurement.MeasureAverageColdStartAsync(memorySize);
                
                Console.WriteLine($"{memorySize} MB: {coldStartTime} s");
            }
        }
    }
}
