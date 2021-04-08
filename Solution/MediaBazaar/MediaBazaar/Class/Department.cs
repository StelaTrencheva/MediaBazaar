using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Department
    {
        private int departmentID;
        private string name;

        public Department(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}
