using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    internal class calculation
    {
        public void converter()
        {
            double km;

            Console.WriteLine("Enter KM Value : ");
            km = double.Parse(Console.ReadLine());

            double cm = km * 100000;
            Console.WriteLine(cm);

        
        }
    }
}
