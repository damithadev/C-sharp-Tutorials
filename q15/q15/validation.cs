using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    internal class validation
    {
        public void eligibility(int age) 
        { 
            if (age > 21) 
            {
                Console.WriteLine("Eligibile");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}
