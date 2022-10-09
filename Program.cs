namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1.fibonacci Series\n2.PerfectNo\n3.ReverseNo");
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
                default:
                    break;



            }
        }
    }
}