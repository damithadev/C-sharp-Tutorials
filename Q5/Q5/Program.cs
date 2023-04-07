using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius;

            Console.WriteLine("Enter the radius");
            radius = float.Parse(Console.ReadLine());

            Console.WriteLine("area " + (3.14 * radius * radius));
            Console.WriteLine("circumference " + (2* 3.14 * radius));

            
            Console.ReadKey();
        }
    }
}
