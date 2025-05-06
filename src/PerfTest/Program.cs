using BenchmarkDotNet.Running;
using System.Reflection;

namespace PerfTest
{
    class Program
    {
        static void Main()
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run();
        }
    }
}
