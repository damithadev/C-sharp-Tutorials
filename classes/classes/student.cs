using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class student
    {
        //properties
        public int sum = 100;
        public int a = 10, b = 20;
        public int x;

        //methods
        public void Myfunction() 
        {
            //sum = a + b;
            Console.WriteLine(sum); 
        }

        public void MyInfo()
        {
            Console.WriteLine("Name - Damitha");
            Console.WriteLine("Batch - 22.1");
            Console.WriteLine("Degree - Software Engineering");
        }
    }
}
