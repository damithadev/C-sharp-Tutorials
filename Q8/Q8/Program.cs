using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number :");
                num[i] = int.Parse(Console.ReadLine());
            }
            
            int max = 0;    
            for (int i = 0;i < num.Length;i++)
            {
                if (max < num[i])
                    max = num[i];
            }

            int min = max;
            for (int i = 0; i <num.Length; i++)
            {
                if (min > num[i])
                    min = num[i];
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.ReadKey();
        }
    }
}
