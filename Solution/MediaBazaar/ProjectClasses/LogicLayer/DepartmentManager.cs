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
        List<Department> departments;

        public DepartmentManager()
        {
            this.dbMediator = new DBMediatorDepartment();
            departments = new List<Department>();
        }


        public void AddDepartment(Department newDept)//ADD DEPT
        {
            if (dbMediator.CheckIfDeptExist(newDept.Code, newDept.Name))
            {
                throw new RepeatingObjectException();
            }

            this.dbMediator.AddDepartment(newDept.Code, newDept.Name);
        }

        //public void AssignDManagerToDept(Department newDept, int mngId)
        //{
        //    if (dbMediator.CheckIfDManagerToDeptExists(newDept.Code, mngId))
        //    {
        //        throw new RepeatingObjectException();
        //    }

        //    this.dbMediator.AssignDManagerToDept(newDept.Code, mngId);
        //}

        public void DeleteDepartment(Department newDept)//DELETE A DEPT
        {
           this.dbMediator.DeleteDepartment(newDept.Code);
        }

        public List<Department> GetDepartments()//GET ALL DEPT
        {
            departments = this.dbMediator.GetDepartment();
            return departments;
        }

        public void UpdateDepartment(Department newDept)
        {
            this.dbMediator.UpdateDepartment(newDept.Code, newDept.Name);
        }

        //public List<Department> GetDepartmentsWithDManagers()
        //{
        //    return this.dbMediator.GetDepartmentWithDManager();
        //}

        //public List<Department> GetDepartmentsWithPCategories()
        //{
        //    return this.dbMediator.GetDepartmentWithPCategory();
        //}

        //fix these stuff after.
        public int GetDepartmentCode(string deptName)
        {
            foreach (Department depart in departments)
            {
                if (depart.Name== deptName)
                {
                    return depart.Code;
                }
            }
            return 0;
        }

        public bool AddCategoryDB(int deptId, string name)
        {
            return dbMediator.AddCategory(deptId, name);
        }

        public bool AddSubcategoryDB(int deptId, string catName, string name)
        {
            return dbMediator.AddSubcategory(deptId, catName, name);
        }

        public bool DeleteCategoryDB(int deptId, string name)
        {
            return dbMediator.DeleteCategory(deptId, name);
        }

        public bool DeleteSubcategoryDB(int deptId, string catName, string name)
        {
            return dbMediator.DeleteSubcategory(deptId, catName, name);
        }

        public List<Employee> GetDepartmentManagersDB(int deptId)
        {
            return dbMediator.GetDepartmentManagers(deptId);
        }

        public List<string> GetDepartmentCategorieDB(int deptId)
        {
            return dbMediator.GetDepartmentCategories(deptId);
        }

        public List<string> GetDepartmentSubcategories(int deptId, string category)
        {
            return dbMediator.GetDepartmentSubcategories(deptId, category);
        }
    }
}
