using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum " + (a + b));
            Console.WriteLine("Substraction " + ( a - b));
            Console.WriteLine("Multiplication " + (a * b));
            Console.WriteLine("Division " + (a / b));
            Console.ReadKey();
        }
    }
}
