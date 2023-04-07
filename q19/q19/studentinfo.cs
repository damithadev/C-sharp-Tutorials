using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q19
{
    internal class studentinfo
    {
        public void stdInfo()
        {
            Console.Write("Enter Your age : ");
            int age = int.Parse(Console.ReadLine());

            student obj = new student();
           

            Console.WriteLine("Name is : " +obj.stdData());

            Console.WriteLine("Age is : " +age);
   
        }
    }
}
