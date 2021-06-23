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
            this.deptMngr = new DepartmentManager(DatabaseType.MAIN);
            this.empMng = new EmployeeManager(DatabaseType.MAIN);
            this.DisplayDepartments();
        }

        private void DisplayDepartments()//DISPLAY ON THE DEPARMENT TAB WHEN CREATING A DEPARTMENT
        {
            lbxDepartments.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartments())
            {
                lbxDepartments.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//ADD DEPARTMENT
        {
            try
            {
                this.deptMngr.AddDepartment(new Department((int)nudDepartmentCode.Value, tbxDepartmentName.Text));
                MessageBox.Show("Succesfully added");
                this.DisplayDepartments();
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
            
            tbxDepartmentName.Clear();
            nudDepartmentCode.Value = 1000;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach(Department dept in this.deptMngr.GetDepartments())
                {
                    if(lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        this.deptMngr.DeleteDepartment(dept);
                        MessageBox.Show("Successfully deleted.");
                        this.DisplayDepartments();
                        break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach(Department dept in this.deptMngr.GetDepartments())
                {
                    if(lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        ModifyDepartment modifyDept = new ModifyDepartment(dept, deptMngr);
                        modifyDept.ShowDialog();
                        break;
                    }
                }
            }
            this.DisplayDepartments();
        }

        private void tbxSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            lbxDepartments.Items.Clear();
            foreach(Department dept in this.deptMngr.GetDepartments())
            {
                if (dept.ToString().ToLower().Contains(tbxSearchDepartment.Text))
                {
                    lbxDepartments.Items.Add(dept);
                }
            }
        }

        private void btnAssignDepartmentManager_Click(object sender, EventArgs e)
        {
            if (lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach (Department dept in this.deptMngr.GetDepartments())
                {
                    if (lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        AssignDepartmentManagerToDepartment assignDepartmentManagerToDepartment = 
                            new AssignDepartmentManagerToDepartment(dept);
                        assignDepartmentManagerToDepartment.ShowDialog();
                        break;
                    }
                }
            }
            this.DisplayDepartments();
        }

        private void lbxDepartments_DoubleClick(object sender, EventArgs e)
        {
            Department d = (Department)lbxDepartments.SelectedItem;
            DepartmentDetailsForm departmentDetailsForm = new DepartmentDetailsForm(d, this.deptMngr);
            departmentDetailsForm.ShowDialog();
        }
    }
}
