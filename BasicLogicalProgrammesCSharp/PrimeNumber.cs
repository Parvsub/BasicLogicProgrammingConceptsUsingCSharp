using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgrammesCSharp
{
    public class PrimeNumber {
        public static void Primenumber()
        {
                Console.WriteLine("Enter the number");
                int i;
                int count = 0;
                int n = Convert.ToInt32(Console.ReadLine());
                for (i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(n + " is a Prime number");
                }
                else
                {
                    Console.WriteLine(n + " is not a Prime number");
                }
            }
        }
    }




