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
    public partial class StoreManagerForm : Form
    {
        private ManageEmployees manageEmployees;
        private int id;

        public StoreManagerForm(ManageEmployees manageEmployees, int id)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.id = id;
            storeManagerInterface1.SendInfo(manageEmployees, id);
        }

        private void btnStoreMLogOut_Click(object sender, EventArgs e)
        {
            btnStoreMEmployeeStatistic.BackColor = Color.SlateGray;
            btnStoreMStockStatistic.BackColor = Color.SlateGray;
            btnStoreM.BackColor = Color.SlateGray;
            btnStoreMLogOut.BackColor = Color.White;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStoreMEmployeeStatistic_Click(object sender, EventArgs e)
        {
            btnStoreMEmployeeStatistic.BackColor = Color.White;
            btnStoreMStockStatistic.BackColor = Color.SlateGray;
            btnStoreM.BackColor = Color.SlateGray;
            btnStoreMLogOut.BackColor = Color.SlateGray;
            storeManagerInterface1.Hide();
        }

        private void btnStoreMStockStatistic_Click(object sender, EventArgs e)
        {
            btnStoreMEmployeeStatistic.BackColor = Color.SlateGray;
            btnStoreMStockStatistic.BackColor = Color.White;
            btnStoreM.BackColor = Color.SlateGray;
            btnStoreMLogOut.BackColor = Color.SlateGray;
            storeManagerInterface1.Hide();
        }

        private void btnStoreM_Click(object sender, EventArgs e)
        {
            btnStoreMEmployeeStatistic.BackColor = Color.SlateGray;
            btnStoreMStockStatistic.BackColor = Color.SlateGray;
            btnStoreM.BackColor = Color.White;
            btnStoreMLogOut.BackColor = Color.SlateGray;
            storeManagerInterface1.Show();
        }

        private void storeManagerInterface1_Load(object sender, EventArgs e)
        {
            storeManagerInterface1.BringToFront();
        }
    }
}
