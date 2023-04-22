using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class test
    {
        private int num1;
        private int num2;

        public void setNums(int num1FromUser, int num2FromUser)
        {
            num1 = num1FromUser;
            num2 = num2FromUser;



        }

       


        public int getSummation(int num1, int num2)
        {
            return num1 + num2;
        }

        public int getSubtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int getMultiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int getDivision(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
