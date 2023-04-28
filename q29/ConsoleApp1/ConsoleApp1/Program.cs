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
            /*Animal obj1 = new Animal();
            obj1.method1();*/

            Dog obj2 = new Dog();
            obj2.method1();
            obj2.method2();

            Console.ReadKey();
        }
    }
}
