using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class EmpComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee e1, Employee e2)
        {
            return e1.AnstId == e2.AnstId;
        }

        public int GetHashCode(Employee p)
        {
            return p.AnstId;
        }
    }
}
