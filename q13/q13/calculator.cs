using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace q13
{
    internal class calculator
    {
        public int sum()
        {
            Console.Write("Enter 1st No: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2st No: ");
            int num2 = int.Parse(Console.ReadLine());

            int summation = num1+ num2;
            return summation; 
        }
    }
}
