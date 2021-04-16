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
            this.dept = new Department(0, name, id, fname, lname);
            if (dbMediator.CheckIfExists(id,name))
            {
                throw new RepeatingObjectException();
            }
            
            this.dbMediator.AddDepartment(name, id);
        }

        public List<Department> GetDepartments()
        {
            return this.dbMediator.GetDepartment();
        }
    }
}
