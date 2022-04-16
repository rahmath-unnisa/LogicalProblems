namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------Welcome To Logical Programs------------------------");
            bool end = true;
            Console.WriteLine("n1. Fibbonacci Series \n2. Perfect Number \n3. Prime Number \n4. Reverse A Number \n5. Day Of The Week \n6. End of the program");
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
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.number();
                        break ;
                    case 4:
                        ReverseOfNumber reverseOfNumber = new ReverseOfNumber();
                        reverseOfNumber.reverse();
                        break;
                    case 5:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.weekday();
                        break;

                    case 6:
                        end = false;
                        break;
                    default: Console.WriteLine("Enter the proper option to execute");
                        break;
                }
            }
        }
    }
}


    
