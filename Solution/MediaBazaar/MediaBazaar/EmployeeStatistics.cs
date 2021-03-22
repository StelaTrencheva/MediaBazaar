using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class EmployeeStatistics : UserControl
    {
        ManageEmployees mngEmp;
        public EmployeeStatistics()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
