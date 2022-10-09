using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class PrimeNo
    {
         static int count = 0;
        public static void checkprime()
        {
            Console.WriteLine("enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the {0} is prime", num);
            }
            else
            {
                Console.WriteLine("the num is not prime");
            }
        }
    }
}
