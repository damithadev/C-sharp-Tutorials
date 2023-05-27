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
            int[,] array = new int[2, 4]; // Declare a 2-dimensional array with 2 rows and 4 columns

            // Get user inputs for array elements
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter element at position [{i}, {j}]: ");
                    string input = Console.ReadLine();
                    int number;
                    if (int.TryParse(input, out number))
                    {
                        array[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        j--; // Decrement j to re-ask for the same column
                    }
                }
            }

            // Display the array elements in a 2x4 matrix
            Console.WriteLine("Array elements:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
