using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EncapData
    {
        private double radius;
        private double PI = 3.14;
        
        public void setRadius(double RadiusFromUser)
        {
            radius = RadiusFromUser;
        }
        

        public double getArea()
        {
            return PI * radius * radius; 
        }

        public double getCircumference()
        {
            return 2 * PI * radius;
        }
    }
}
