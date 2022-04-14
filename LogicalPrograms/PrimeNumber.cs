using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        int n, a = 0;
        public void number()
        {
            Console.WriteLine("Enter a number:");
            n= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    a++;

                }
            }
            if (a == 2)
            {
                Console.WriteLine("Is a prime number" );

            }
            else
                Console.WriteLine("Is not a prime number" );
        }
    }
}
