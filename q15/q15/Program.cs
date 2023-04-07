using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());

            validation obj = new validation();
            obj.eligibility(age);

            Console.ReadKey();
        }
    }
}
