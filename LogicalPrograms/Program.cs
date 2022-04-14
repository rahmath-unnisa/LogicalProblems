namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------Welcome To Logical Programs------------------------");
            bool end = true;
            Console.WriteLine("n1. Fibbonacci Series \n2. Perfect Number \n3. End of the program");
            while (end==true)
            {
                Console.WriteLine("Enter the option to execute the program ");
                int option= Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        FibbonacciSeries fibo = new FibbonacciSeries();
                        fibo.series();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.pnumber();
                        break;
                    case 3:
                        end = false;
                        break;
                    default: Console.WriteLine("Enter the proper option to execute");
                        break;
                }
            }
        }
    }
}


    
