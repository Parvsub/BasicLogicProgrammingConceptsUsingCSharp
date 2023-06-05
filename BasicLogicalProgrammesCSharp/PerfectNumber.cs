using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgrammesCSharp
{
    public class PerfectNumber {
        public static void PerfectNoProgramme()
        {
            Console.WriteLine("Enter the number");
            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is a perfect number");
            }
            else
            {
                Console.WriteLine(n + " is not a perfect number");
            }
        }
    }
}
        