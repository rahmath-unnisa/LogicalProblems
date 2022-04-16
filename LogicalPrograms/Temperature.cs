using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Temperature
    {
        public void CelToFaren()
        {
            int farenhite;
            Console.WriteLine("Enter The Temperature In Celcius");
            int  celcius= Convert.ToInt32(Console.ReadLine());
            farenhite = (celcius * 9 / 5) + 32;
            Console.WriteLine("Temperature In Farenhite Is:" + farenhite);
        }
        public void FerenToCel()
        {
            float celcius,value;
            Console.WriteLine("Enter The Temperature In Farenhite");
            int farenhite = Convert.ToInt32(Console.ReadLine());
            value = (farenhite - 32) * 5;
            celcius = value / 9;
            Console.WriteLine("Temperature In Celcius Is:" + celcius);


            
        }
    }
}
