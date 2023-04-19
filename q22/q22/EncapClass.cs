using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22
{
    internal class EncapClass
    {
        private int age;
        private string name;
        public void setAge(int ageFromUser)
        {
            age = ageFromUser;
        }
        public int getAge()
        {
            return age;
        }

        public void setName(string ageFromUser)
        {
            name = ageFromUser;
        }
        public string getName()
        {
            return name;
        }

    }
}
