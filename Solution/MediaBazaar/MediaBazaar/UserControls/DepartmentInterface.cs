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
        private DepartmentManager dept;
        public DepartmentInterface()
        {
            InitializeComponent();
            this.dept = new DepartmentManager();
            this.DisplayDepartments();
        }

        private void DisplayDepartments()
        {
            lbxDepartments.Items.Clear();
            foreach (Department i in this.dept.GetDepartments())
            {
                lbxDepartments.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Text == "")
                {
                    MessageBox.Show("Please fill in the name.");
                    this.DisplayDepartments();
                }
                else
                {
                    this.dept.AddDepartment(tbxName.Text);
                    MessageBox.Show("Succesfully added");
                    this.DisplayDepartments();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }

            tbxName.Clear();
        }
    }
}
