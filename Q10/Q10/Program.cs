using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2, 4];

            //read
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Write
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
