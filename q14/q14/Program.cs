using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter a nuameric value: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a nuameric value: ");
            b = int.Parse(Console.ReadLine());

            calculation obj = new calculation();
            obj.summation(a, b);

            Console.ReadKey();
        }
    }
}
