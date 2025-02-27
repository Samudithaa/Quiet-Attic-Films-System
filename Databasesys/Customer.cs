using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Databasesys
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID, contno;
        string name, address, email;

        public Customer()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2dbms newform = new Form2dbms();
            this.Hide();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2dbms newform = new Form2dbms();
            this.Hide();
            newform.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Customer(Cus_ID, Cus_Name, Cus_Address, Email, Cont_No) values('" + ID + "', '" + name + "', '" + address + "', '" + email + "', '" + contno + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string delete = "delete from Customer where Cus_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data delete Successfully");
            conn.Close();
            loadgrid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string search = "select * from  Customer where Cus_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtname.Text = read["Cus_Name"].ToString();
                txtaddr.Text = read["Cus_Address"].ToString();
                txtemail.Text = read["Email"].ToString();
                txtcontact.Text = read["Cont_No"].ToString();
            }
            conn.Close();
            loadgrid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Customer set Cus_Name= '" + name + "',Cus_Address= '" + address + "',Email='" + email + "',Cont_No='" + contno + "' where Cus_ID = '"+ID+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data update Successfully");
            conn.Close();
            loadgrid();
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from Customer";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridcus.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtcusid.Text.ToString());
            name = txtname.Text;
            address = txtaddr.Text;
            email = txtemail.Text;
            contno = int.Parse(txtcontact.Text.ToString());

        }
    }
}
