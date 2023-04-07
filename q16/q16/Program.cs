using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;

            Console.Write("Enter a number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            summation obj1 = new summation();
            obj1.operation(a, b);


            multiplication obj2 = new multiplication();
            obj2.operation(a, b);

            Console.ReadKey();
        }
    }
}
