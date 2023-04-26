using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tyre
    {
        public int noOfTyers = 4;
        protected void tyreType()
        {
            Console.WriteLine("Tubles tyre");
            Console.WriteLine(noOfTyers);
        }
    }
}
