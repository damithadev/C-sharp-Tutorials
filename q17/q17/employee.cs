using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    internal class employee
    {
        public int calculation(int h)
        {
            

            if (h < 10) 
            { 
                return 5000;
            }
            else if (h > 30)
            {
                return 60000;
            }
            else if (h < 20)
            {
                return 25000;
            }
            else
            {
                return 45000;
            }


               
        }
    }
}
