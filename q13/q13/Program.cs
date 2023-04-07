using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator obj = new calculator();

            Console.WriteLine("Summation is : " +obj.sum());

            Console.ReadKey();
        }
    }
}
