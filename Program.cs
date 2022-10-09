namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1.fibonacci series\n2.Perfect No\n");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries.CalculateFibonacci();
                    break;
                case 2:
                    PerfectNo.CheckPerfectno();
                    break;
                    default:
                    break;

            }
        }
    }
}
