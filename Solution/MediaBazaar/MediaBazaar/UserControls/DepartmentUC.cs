using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class DepartmentInterface : UserControl
    {
        private DepartmentManager deptMngr;
        private EmployeeManager empMng;
        public DepartmentInterface()
        {
            InitializeComponent();
            this.deptMngr = new DepartmentManager();
            this.empMng = new EmployeeManager();
            this.DisplayDepartments();
            this.DisplayDepartmentManagersInCbx();
            this.DisplayDepartmentsInCbx();
            this.DisplayDepartmentsWithDManagers();
            DisplayDepartmentsWithPCategories();
        }

        private void DisplayDepartments()//DISPLAY ON THE DEPARMENT TAB WHEN CREATING A DEPARTMENT
        {
            lbxDepartments.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartments())
            {
                lbxDepartments.Items.Add(i.ToString());
                //lbxDepartments.Items.Add("");
            }
        }

        private void DisplayDepartmentsWithDManagers()//DISPLAY ON ASSING DEPARTMENT MANAGER TAB
        {
            lbxDepartmentsAndDM.CustomTabOffsets.Add(150);
            lbxDepartmentsAndDM.UseCustomTabOffsets = true;
            lbxDepartmentsAndDM.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartmentsWithDManagers())
            {
                lbxDepartmentsAndDM.Items.Add(i.DisplayAssignDManager());
                //lbxDepartmentsAndDM.Items.Add("");
            }
        }

        private void DisplayDepartmentsWithPCategories()//DISPLAY ON ASSIGN PRODUCT CATEGORY
        {
            lbxDepartmentsAndPCategory.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartmentsWithPCategories())
            {
                lbxDepartmentsAndPCategory.Items.Add(i.DisplayAssignPCategory());
                //lbxDepartmentsAndPCategory.Items.Add("");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//ADD DEPARTMENT
        {
            try
            {
                this.deptMngr.AddDepartment(new Department((int)nudCode.Value, tbxName.Text));
                MessageBox.Show("Succesfully added");
                this.DisplayDepartments();
                this.DisplayDepartmentsInCbx();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please fill in the name.");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("The code or the department name already exist.");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
            
            tbxName.Clear();
            nudCode.Value = 1000;
        }

        private void DisplayDepartmentManagersInCbx()//DISPLAY DEPARTMENT MANAGER IN COMBOBOX IN ASSIGN DMANAGER TAB
        {
            cbxDManagers.Items.Clear();
            foreach (Employee emp in this.empMng.GetListOFAllEmployees())
            {
                if (emp.Position == EmployeeType.DEPARTMENT_MANAGER)
                {
                    cbxDManagers.Items.Add(emp.GetNames);
                }
            }
            cbxDManagers.SelectedIndex = 0;
        }

        private void DisplayDepartmentsInCbx()//DISPLAY DEPARTMENT IN COMBOBOX IN ASSIGN DMANAGER TAB
        {
            cbxDMDepartments.Items.Clear();
            foreach (Department dept in this.deptMngr.GetDepartments())
            {
                cbxDMDepartments.Items.Add(dept);
            }
            cbxDMDepartments.SelectedIndex = 0;
        }

        private void btnAssignDM_Click(object sender, EventArgs e)
        {
            try
            {
                Department d = (Department)cbxDMDepartments.SelectedItem;
                foreach (Employee emp in this.empMng.GetListOFAllEmployees())
                {
                    if (cbxDManagers.SelectedItem.ToString() == emp.GetNames)
                    {
                        this.deptMngr.AssignDManagerToDept(new Department(d.Code, d.Name, emp.Id, emp.FirstName, emp.LastName));
                    }
                }
                this.DisplayDepartmentsWithDManagers();
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("the department or department manager is already assign.");
            }
        }
    }
}
