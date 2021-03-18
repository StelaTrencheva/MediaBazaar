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
        private int id;

        public StockManagerForm(ManageEmployees manageEmployees, int id)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.id = id;
            this.stockManagerInterface1.SendInfo(manageEmployees, id);
        }
        private void PaintAllButtons()
        {
           btnStockMSchedule.BackColor = Color.SlateGray;
            btnStockMAccount.BackColor = Color.SlateGray;
            btnStockMLogOut.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            stockManagerInterface1.Hide();
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
    }
}
