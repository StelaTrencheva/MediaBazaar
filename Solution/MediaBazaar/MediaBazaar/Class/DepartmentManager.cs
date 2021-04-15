using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class DepartmentManager
    {
        DBMediatorDepartment dbMediator;
        Department dept;

        public DepartmentManager()
        {
            this.dbMediator = new DBMediatorDepartment();
        }

        public void AddDepartment(string name, int id, string fname, string lname)
        {
            foreach(Department d in this.GetDepartments())
            {
                if(d.Dept_mng_id == id)
                {
                    throw new RepeatingObjectException();
                }
            }
            this.dept = new Department(0, name, id, fname, lname);
            this.dbMediator.AddDepartment(name, id);
        }

        public List<Department> GetDepartments()
        {
            return this.dbMediator.GetDepartment();
        }
    }
}
