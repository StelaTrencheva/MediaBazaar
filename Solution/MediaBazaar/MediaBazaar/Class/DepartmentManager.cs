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

        public void AddDepartment(Department newDept)
        {
            if (dbMediator.CheckIfExists(newDept.Dept_mng_id, newDept.Name))
            {
                throw new RepeatingObjectException();
            }
            
            this.dbMediator.AddDepartment(newDept.Name, newDept.Dept_mng_id);
        }

        public List<Department> GetDepartments()
        {
            return this.dbMediator.GetDepartment();
        }
    }
}
