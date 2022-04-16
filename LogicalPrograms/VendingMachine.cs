using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        int i;
        public void notes()
        {
            int[] note = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] frequency = new int[note.Length];
            Console.WriteLine("Enter the amount ");
            int amount = Convert.ToInt32((Console.ReadLine()));
            for (int i = 0; i < note.Length; i++) 
            {
                if(amount>0)
                {
                    frequency[i] = amount / note[i];
                    amount-=frequency[i] * note[i];
                }
            }
            for(int i=0; i < frequency.Length; i++)
            {
                if(frequency[i] != 0)
                {
                    Console.WriteLine(note[i]+"----------->"+frequency[i]);
                }
            }


        }
    }
}
