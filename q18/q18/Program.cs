using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2 ;

            Console.Write("Enter 1st Number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("1. Summation ");
            Console.WriteLine("2. Substraction ");
            Console.WriteLine("3. Multiplication ");
            Console.WriteLine("4. Division ");

            Console.WriteLine("");
            Console.Write("Select a operator : ");
            
            
            int opr = int.Parse(Console.ReadLine());


            calculation obj = new calculation();


            if (opr == 1 ) 
            {
                double answer = obj.sum(num1, num2);
                Console.WriteLine("Answer = " + answer);
            }
            else if (opr == 2 ) 
            {
                double answer = obj.sub(num1, num2);
                Console.WriteLine("Answer = " + answer);
            }
            else if (opr == 3 )
            {
                double answer = obj.mult(num1, num2);
                Console.WriteLine("Answer = " + answer);
            }
            else if (opr == 4)
            {
                double answer = obj.div(num1, num2);
                Console.WriteLine("Answer = " +answer);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
            
        }
    }
}
