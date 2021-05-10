using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class DepartmentManager
    {
        DBMediatorDepartment dbMediator;

        public DepartmentManager()
        {
            this.dbMediator = new DBMediatorDepartment();
        }

        public void AddDepartment(Department newDept)
        {
            if (dbMediator.CheckIfDeptExist(newDept.Code, newDept.Name))
            {
                throw new RepeatingObjectException();
            }
            
            this.dbMediator.AddDepartment(newDept.Code, newDept.Name);
        }

        public void AssignDManagerToDept(Department newDept)
        {
            if (dbMediator.CheckIfDManagerToDeptExists(newDept.Code, newDept.Dept_mng_id))
            {
                throw new RepeatingObjectException();
            }

            this.dbMediator.AssignDManagerToDept(newDept.Code, newDept.Dept_mng_id);
        }

        public List<Department> GetDepartments()
        {
            return this.dbMediator.GetDepartment();
        }

        public List<Department> GetDepartmentsWithDManagers()
        {
            return this.dbMediator.GetDepartmentWithDManager();
        }

        public List<Department> GetDepartmentsWithPCategories()
        {
            return this.dbMediator.GetDepartmentWithPCategory();
        }
    }
}
