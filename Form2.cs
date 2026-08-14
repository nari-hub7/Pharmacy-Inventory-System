using group16_Pharmacy_Inventory_System.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace group16_Pharmacy_Inventory_System
{
    public partial class Form2 : Form
    {
        Database db = new Database();
        String query;
        DataSet ds;

        public Form2(string username)
        {
            InitializeComponent();
            label1.Text = "Welcome, " + username + "!";
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void Salebtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Sale());
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Dashboard());
        }

        private void AddUserbtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_AddUser());
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Products());
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Customers());
        }
    }
}
