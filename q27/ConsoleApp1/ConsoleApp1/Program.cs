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
            Scooter obj = new Scooter();
            obj.scooterType();

            Car obj1 = new Car();
            obj1.carType();
            Console.ReadKey();
        }
    }
}
