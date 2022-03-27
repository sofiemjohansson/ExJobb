using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Employee
    {
     

        public Nurse(string fn, string sn, string address, int age, string phone, string email, int empNum, string position, double salary)
            : base(fn, sn, address, age, phone, email, empNum, position)
        {
          
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
