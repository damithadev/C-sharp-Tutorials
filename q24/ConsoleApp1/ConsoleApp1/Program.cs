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
            Hello hello = new Hello();
            Console.WriteLine("Your age is: " + hello.a);
            Console.ReadLine();

        }
    }

    public class Hello
    {
        public int a = 100;
    }
}
