using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        int sum = 0;
        public void pnumber()
        {
            Console.WriteLine("Enter the number");
            int num= Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum += i;

                }
            }
            if(num==sum)
            {
                Console.WriteLine("The number is perfect");

            }
            else
            {
                Console.WriteLine("The number is not perfect");
            }
        }
    }
}
