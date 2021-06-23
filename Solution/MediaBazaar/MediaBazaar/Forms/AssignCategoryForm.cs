using ProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class AssignCategoryForm : Form
    {
        private Department department;
        private DepartmentManager departmentManager;

        public AssignCategoryForm(Department department, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.department = department;
            this.departmentManager = departmentManager;
            lblDepartmentName.Text = department.Name;
            this.Category();
        }

        public void Category()
        {
            cbxCategory.Items.Clear();
            foreach(string category in this.departmentManager.GetCategories())
            {
                cbxCategory.Items.Add(category);
            }
            cbxCategory.SelectedIndex = 0;
        }
    }
}
