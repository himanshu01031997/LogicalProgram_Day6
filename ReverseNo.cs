using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class ReverseNo
    {
        public static void findReverse()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Please enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!= 0)
            {

                rem = n % 10;
                reverse = reverse * 10 + rem;
                n=n/10;
            }
            Console.WriteLine("Reverse No is {0}",reverse);
        }
    }
}
