using System;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object
            student myObj = new student();
            student obj1 = new student();

            //accessing methods
            //myObj.Myfunction();
            //obj1.x= 1;

            //Console.WriteLine(obj1.sum);
            myObj.MyInfo();
            Console.ReadKey();  
        }
    }
}
