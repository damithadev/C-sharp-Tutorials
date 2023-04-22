using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EncapClass
    {
        private int num1;
        private int num2;

        public void setNum1(int num1FromUser)
        {
            num1 = num1FromUser;
        }

        public void setNum2(int num2FromUser)
        {
            num2 = num2FromUser;
        }


        public int getSummation()
        {
            return num1 + num2;
        }

        public int getSubtraction()
        {
            return num1 - num2;
        }

        public int getMultiplication()
        {
            return num1 * num2;
        }

        public int getDivision()
        {
            return num1 / num2;
        }
    }
}
