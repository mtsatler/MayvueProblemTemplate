using Problem.Name;
using Problem.Name.Solutions;
using BenchmarkDotNet.Attributes;

namespace Benchmarking
{
    [MemoryDiagnoser]
    [CsvExporter]
    public class Benchmarks
    {
        public Benchmarks()
        {
            // Any setup can be done here i.e. generating input and solution files
        }

        /* Add benchmark runs here. For example...

        [Benchmark]
        public void BenchmarkEddie() => Verify(Eddie.MaxTwinSum);



        */

    }
}
