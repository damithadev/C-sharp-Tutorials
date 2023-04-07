using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int[] num = { 25, 41, 10, 78, 68, 36, 89, 37 };
            int max = 0;

            for (int i=0; i<num.Length; i++)
            {
                if (max < num[i])
                    max = num[i];
            }

            int min = max;
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                    min = num[i];
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();

            
        }
    }
}
