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
    public partial class StockWorkerForm : Form
    {
        private ManageEmployees manageEmployees;
        private int id;

        public StockWorkerForm(ManageEmployees manageEmployees, int id)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.id = id;
            stockWorkerInterface1.SendInfo(manageEmployees, id);
        }

        private void btnStockWLogOut_Click(object sender, EventArgs e)
        {
            btnStockWProductData.BackColor = Color.SlateGray;
            btnStockWRestockRequest.BackColor = Color.SlateGray;
            btnStockWAccount.BackColor = Color.SlateGray;
            btnStockWLogOut.BackColor = Color.White;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStockWProductData_Click(object sender, EventArgs e)
        {
            btnStockWProductData.BackColor = Color.White;
            btnStockWRestockRequest.BackColor = Color.SlateGray;
            btnStockWAccount.BackColor = Color.SlateGray;
            btnStockWLogOut.BackColor = Color.SlateGray;
            stockWorkerInterface1.Hide();
            productData1.Show();
        }

        private void btnStockWRestockRequest_Click(object sender, EventArgs e)
        {
            btnStockWProductData.BackColor = Color.SlateGray;
            btnStockWRestockRequest.BackColor = Color.White;
            btnStockWAccount.BackColor = Color.SlateGray;
            btnStockWLogOut.BackColor = Color.SlateGray;
            stockWorkerInterface1.Hide();
            productData1.Hide();
        }

        private void btnStockWAccount_Click(object sender, EventArgs e)
        {
            btnStockWProductData.BackColor = Color.SlateGray;
            btnStockWRestockRequest.BackColor = Color.SlateGray;
            btnStockWAccount.BackColor = Color.White;
            btnStockWLogOut.BackColor = Color.SlateGray;
            stockWorkerInterface1.Show();
            productData1.Hide();
        }

        private void stockWorkerInterface1_Load(object sender, EventArgs e)
        {
            stockWorkerInterface1.BringToFront();
        }
    }
}
