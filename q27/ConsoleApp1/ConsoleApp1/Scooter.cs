using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Scooter : Tyre
    {
        public void scooterType() 
        {
            Console.WriteLine("It's red");
            tyreType();
        }
    }
}
