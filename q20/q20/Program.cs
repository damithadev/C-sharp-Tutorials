using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj= new employee();   //Automatically calling the constructor

            obj.function(); //calling the function
            Console.ReadKey();
        }
    }
}
