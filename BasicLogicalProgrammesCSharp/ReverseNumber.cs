using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgrammesCSharp
{
    public class ReverseNumber
    {
        public static void Reversenumber()
        {
            Console.WriteLine("Enter the Number");
            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                sum = sum * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
