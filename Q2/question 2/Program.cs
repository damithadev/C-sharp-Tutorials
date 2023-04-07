using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter 1st Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st Number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("Devicible");
            }
            else {
                Console.WriteLine("Undivicible");
            }
            Console.ReadKey();
        }
    }
}
