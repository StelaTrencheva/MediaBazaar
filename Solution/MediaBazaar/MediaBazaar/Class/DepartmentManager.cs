using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class DepartmentManager
    {
        DatabaseMediator dbMediator;

        public DepartmentManager()
        {
            this.dbMediator = new DatabaseMediator();
        }

        public void AddDepartment(string name)
        {
            this.dbMediator.AddDepartment(name);
        }

        public List<Department> GetDepartments()
        {
            return this.dbMediator.GetDepartment();
        }
    }
}
