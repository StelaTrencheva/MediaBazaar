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
        private void PaintAllButtons()
        {
            btnStoreMEmployeeStatistic.BackColor = Color.SlateGray;
            btnStoreMStockStatistic.BackColor = Color.SlateGray;
            btnStoreM.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            storeManagerInterface1.Hide();

        }
        private void btnStoreMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStoreMEmployeeStatistic_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreMEmployeeStatistic.BackColor = Color.White;
            HideAllInterfaces();
            
        }

        private void btnStoreMStockStatistic_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreMStockStatistic.BackColor = Color.White;
            HideAllInterfaces();
        }

        private void btnStoreM_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreM.BackColor = Color.White;
            HideAllInterfaces();
            storeManagerInterface1.Show();
        }

        private void StoreManagerForm_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreM.BackColor = Color.White;
            HideAllInterfaces();
            storeManagerInterface1.Show();
        }
    }
}
