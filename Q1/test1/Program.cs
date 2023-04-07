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
            int age;
            string name;

            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine(name + " - You are Eligible");
            }
            else
            {
                Console.WriteLine(name + " You are not Eligible");
            }
            Console.ReadKey();

        }
    }
}