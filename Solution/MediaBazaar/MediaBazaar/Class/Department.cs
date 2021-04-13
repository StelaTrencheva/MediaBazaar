using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Department
    {
        private int code;
        private string name;

        public Department(int code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name}.";
        }
    }
}
