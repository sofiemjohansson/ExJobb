using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   public abstract class Employee : Person
    {
        public int AnstId { get; set; }
        public string Position { get; set; }

        public Employee (string fn, string sn, string address, int age, string phone, string email, int empNum, string position)
            : base(fn, sn, address, age, phone, email)
        {
            AnstId = empNum;
            Position = position;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"AnställningsId: {AnstId}, Position {Position}, ");
            return sb.ToString();
        }
    }
}
