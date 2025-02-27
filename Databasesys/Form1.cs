using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Databasesys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False"); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string us = txtus.Text;
            string pw = txtpw.Text; 

            if (us == "admin" && pw == "123")
            {
                Form2dbms newform = new Form2dbms();
                this.Hide();
                newform.Show();
                
            }
            
            else
            {
                MessageBox.Show("Login Fail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtus.Clear();
                txtpw.Clear();
                txtus.Focus(); 
            } 


        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtus.Clear();
            txtpw.Clear();
            txtus.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpw_Click(object sender, EventArgs e)
        {

        }

        private void lblus_Click(object sender, EventArgs e)
        {

        }
    }
}
