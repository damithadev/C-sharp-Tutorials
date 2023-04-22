using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            double R = double.Parse(Console.ReadLine());

            EncapData obj = new EncapData();
            obj.setRadius(R);

           

            Console.WriteLine("Area is: " + obj.getArea());
            Console.WriteLine("Area is: " + obj.getCircumference());

            Console.ReadKey();
        }
    }
}
