using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    internal class employee
    {
        public string name;
        public int age;
        public void empinfo()
        {
            Console.Write("Enter name: ");
            name= Console.ReadLine();

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Name - " + name + "\n" + "Age - " +age);
        } 
    }
}
