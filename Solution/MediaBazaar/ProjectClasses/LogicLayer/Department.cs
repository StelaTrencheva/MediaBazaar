using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Department
    {
        private int code;
        private string name;
        private List<Employee> managers;

        public int Code
        {
            get { return this.code; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public List<Employee> Managers
        {
            get { return this.managers; }
            set { managers = value; }
        }

        public Department(int code, string name)
        {
            if( name == "")
            {
                throw new ArgumentException();
            }

            this.code = code;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Code: {this.code} - {this.name}";
        }

        public string DisplayAssignDManager()
        {
            return $"Code: {this.code} - {this.name} -\t";
        }

        public string DisplayAssignPCategory()
        {
            return $"{this.name} ";
        }
    }
}
