using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EncapClass obj = new EncapClass();
            obj.setAge(20);
            obj.setName("Damitha");

            Console.WriteLine("Age is: " +obj.getAge());
            Console.WriteLine("Name is: " + obj.getName());
            Console.ReadKey();

            /*Update*/
        }
    }
}
