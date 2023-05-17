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
            try
            {
                Console.WriteLine("Enter Liter Value : ");
                int liter = int.Parse(Console.ReadLine());

                Console.WriteLine("Mililiter : " + (liter * 1000));
            }
            catch (FormatException ex) 
            {
                Console.WriteLine( "System Error: " + ex.Message );
            
            }
            Console.ReadKey();
        }
    }
}
