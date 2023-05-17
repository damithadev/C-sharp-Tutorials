using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

                Console.WriteLine("Enter no 1 : ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter no 2 : ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Division" + (x / y));
                
            }
            catch (FormatException d)
            {
                Console.WriteLine("System Error: " + d.Message);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine("System Error: " + ex.Message);
            }
            catch (OverflowException f)
            {
                Console.WriteLine("System Error: " + f.Message);
            }
            finally 
            {
                

            }
            
           
            Console.ReadKey();
        }
    }
}
