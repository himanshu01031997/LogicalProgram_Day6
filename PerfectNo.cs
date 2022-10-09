using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class PerfectNo
    {
        public static void CheckPerfectno()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("find the perfect no within a given range:");
            Console.WriteLine("enter the starting range or number:");
            mn =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range or number:");
            mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if(sum ==n)
                    Console.WriteLine("{0}",n);
            }

        }
    }
}
