using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgrammesCSharp
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            Console.WriteLine("Enter the Fibonacci Series");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}