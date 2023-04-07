using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ocount = 0;
            int Ecount = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Enter a number ");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Ecount = Ecount + 1;
                }
                else
                {
                    Ocount = Ocount +1;
                }
            }
            Console.WriteLine(Ocount);
            Console.WriteLine(Ecount);


            Console.ReadKey();
        }
    }
}
