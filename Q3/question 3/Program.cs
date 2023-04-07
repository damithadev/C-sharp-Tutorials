using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
            for (int x=num; x<=100; x++)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("error");
            }   Console.ReadKey();

        }
    }
}
