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
        private int dept_mng_id;
        private string mngFName;
        private string mngLName;

        public int Dept_mng_id
        {
            get { return dept_mng_id; }
        }

        public Department(int code, string name, int dept_mng_id, string mngFName, string mngLName)
        {
            if(name == "")
            {
                throw new ArgumentException();
            }

            this.code = code;
            this.name = name;
            this.dept_mng_id = dept_mng_id;
            this.mngFName = mngFName;
            this.mngLName = mngLName;
        }

        public override string ToString()
        {
            return $"{this.name} --- Assign to: {this.mngFName} {this.mngLName}";
        }
    }
}
