using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group16_Pharmacy_Inventory_System
{
    using System.Data.SqlClient;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public partial class Form1 : Form
    {
        Database db = new Database();
        String query;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            query = "select * from users";
            DataSet ds = db.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                if(textBox1.Text=="root" && textBox2.Text == "root")
                {
                    this.Hide();

                    Form2 f2 = new Form2(username);
                    f2.ShowDialog();
                }
            }
            else
            {
                query = "select * from users where username ='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
                ds = db.getData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role =="Administrator")
                    {
                        this.Hide();

                        Form2 f2 = new Form2(username);
                        f2.ShowDialog();
                    }
                    else if(role == "Pharmacist")
                    {
                            this.Hide();

                            Form2 f2 = new Form2(username);
                            f2.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /*string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Nariza" && textBox2.Text == "Nariza2007")
            {
                this.Hide();

                Form2 f2 = new Form2(username);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Try again.");
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
