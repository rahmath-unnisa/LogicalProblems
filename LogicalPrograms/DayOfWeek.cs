using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class DayOfWeek
    {
        public void weekday()
        {
            Console.WriteLine("Enter the Month 1 to 12");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Day 1 to 7");
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year 4 digits");
            int Year = Convert.ToInt32(Console.ReadLine());
            int y0 = Year - (14 - Month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = Month + 12 * ((14 - Month) / 12) - 2;
            int d0 = (Day + x + 31 * m0 / 12) % 7;
            switch(d0)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter proper option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
