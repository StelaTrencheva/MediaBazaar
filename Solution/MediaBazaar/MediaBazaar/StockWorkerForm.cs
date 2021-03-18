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
        private void PaintAllButtons()
        {
          btnStockWProductData.BackColor = Color.SlateGray;
            btnStockWRestockRequest.BackColor = Color.SlateGray;
            btnStockWAccount.BackColor = Color.SlateGray;
            btnStockWLogOut.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            stockWorkerInterface1.Hide();
            productData1.Hide();
        }
        private void btnStockWLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStockWProductData_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWProductData.BackColor = Color.White;
            HideAllInterfaces();
            productData1.Show();
        }

        private void btnStockWRestockRequest_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWRestockRequest.BackColor = Color.White;
            HideAllInterfaces();
        }

        private void btnStockWAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWAccount.BackColor = Color.White;
            HideAllInterfaces();
            stockWorkerInterface1.Show();
        }

        private void StockWorkerForm_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWAccount.BackColor = Color.White;
            HideAllInterfaces();
            stockWorkerInterface1.Show();
        }
    }
}
