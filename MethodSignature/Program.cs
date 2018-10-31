using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSignature
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10L, 0L == 10L);
        }

        private static (long, long) SomeCalculation(long l1, long l2, bool boolFlag)
        {
            return (l1, l2);
        }
    }
}