using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public void monthlypay()
        {
            Console.WriteLine("Enter The Principle Amount");
            int principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Years");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Rate Of Interest");
            int rate = Convert.ToInt32(Console.ReadLine());
            var n = 12 * year;
            Console.WriteLine(n);
            float r = rate / 1200;
            Console.WriteLine(r);
            double payment = ((principle * r) / (1 - Math.Pow((1 + r), - n)));
        }
    }
}
