using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class FibonacciSeries
    {
        static int n1 = 0, n2 = 1, n3,num;
        public static void CalculateFibonacci()
        {
            Console.WriteLine("enter the number of element");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " " );
            for(int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 +" ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
