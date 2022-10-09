namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1.fibonacci Series\n2.PerfectNo\n3.ReverseNo\n4.PrimeNo\n5.Coupanno\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries.CalculateFibonacci();
                    break;
                case 2:
                    PerfectNo.CheckPerfectno();
                    break;
                case 3:
                    ReverseNo.findReverse();
                    break;
                case 4:
                    PrimeNo.checkprime();
                    break;
                case 5:
                    CoupanNo.Distinct();
                    break;
                default:
                    break;
            }
        }
    }
}