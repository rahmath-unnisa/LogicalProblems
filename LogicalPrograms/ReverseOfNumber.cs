using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
     public class ReverseOfNumber
    {
        int  num,rev;
        public void reverse()
        {
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                int rem = num % 10;
                rev = rev *10 + rem;
                num = num / 10;

            }
            Console.WriteLine("Reversed number:" + rev);

        }
    }
}
