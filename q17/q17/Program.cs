using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h;

            Console.WriteLine("Enter working hours : ");
            h = int.Parse(Console.ReadLine());

            employee obj = new employee();

            int salary = obj.calculation(h);
            Console.WriteLine(salary);

            Console.ReadKey();
        }
    }
}
