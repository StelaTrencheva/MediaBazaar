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
    public partial class StockManagerForm : Form
    {
        private ManageEmployees manageEmployees;
        private Employee currentEmp;

        public StockManagerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new ManageEmployees();
            this.currentEmp = currentEmp;
            this.stockManagerInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnStockMSchedule.BackColor = Color.SlateGray;
            btnStockMAccount.BackColor = Color.SlateGray;
            btnStockMLogOut.BackColor = Color.SlateGray;
            btnStockMAddProduct.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            stockManagerInterface1.Hide();
            addProductInterface1.Hide();
        }
        private void btnStockMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void stockManagerInterface1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStockMSchedule_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockMSchedule.BackColor = Color.White;
            HideAllInterfaces();
        }

        private void btnStockMAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockMAccount.BackColor = Color.White;
            HideAllInterfaces();
            stockManagerInterface1.Show();
        }

        private void StockManagerForm_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnStockMAccount.BackColor = Color.White;
            stockManagerInterface1.Show();
        }

        private void btnStockMAddProduct_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnStockMAddProduct.BackColor = Color.White;
            addProductInterface1.Show();
        }
    }
}
