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
            this.DisplayDepartmentManagers();
        }

        private void DisplayDepartmentManagers()
        {
            cbxDManager.Items.Clear();
            foreach(Employee emp in this.empMng.GetListOFAllEmployees())
            {
                if(emp.Position == EmployeeType.DEPARTMENT_MANAGER)
                {
                    cbxDManager.Items.Add(emp.GetNames());
                }
            }
            cbxDManager.SelectedIndex = 0;
        }

        private void DisplayDepartments()
        {
            lbxDepartments.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartments())
            {
                lbxDepartments.Items.Add(i);
                lbxDepartments.Items.Add("");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Employee emp in this.empMng.GetListOFAllEmployees())
                {
                    if (cbxDManager.SelectedItem.ToString() == emp.GetNames())
                    {
                        this.deptMngr.AddDepartment(new Department(0, tbxName.Text, emp.Id, emp.FirstName, emp.LastName));
                        MessageBox.Show("Succesfully added");
                        this.DisplayDepartments();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please fill in the name.");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This department manager is already assign or\nthis department name already exists.");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
            

            tbxName.Clear();
        }
    }
}
