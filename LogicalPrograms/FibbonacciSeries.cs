using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibbonacciSeries
    {
        int f1 = 0, f2 = 1, f3 = 0;
        public int series()
        {
            Console.WriteLine("Enter the number:");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.WriteLine(f1);

            }
            return f1;
        }
        
    }
}
