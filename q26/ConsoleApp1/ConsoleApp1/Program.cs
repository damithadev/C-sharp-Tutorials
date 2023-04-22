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
            Console.WriteLine("Enter Number 1: ");
            int num1FromUser = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 1: ");
            int num2FromUser = int.Parse(Console.ReadLine());

            EncapClass obj = new EncapClass();
            obj.setNum1(num1FromUser);
            obj.setNum2(num2FromUser);

            Console.WriteLine("Summation: " + obj.getSummation());
            Console.WriteLine("Substraction: " + obj.getSubtraction());
            Console.WriteLine("Multiplication: " + obj.getMultiplication());
            Console.WriteLine("Devision: " + obj.getDivision());

            Console.ReadKey();
        }
    }
}
