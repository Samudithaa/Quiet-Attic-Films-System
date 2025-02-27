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
    public partial class Order : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID;
        string type;

        public Order()
        {
            InitializeComponent();
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

        private void Order_Load(object sender, EventArgs e)
        {
            loadgrid();


        }

        private void txtorderty_TextChanged(object sender, EventArgs e)
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

        private void datagridorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into new_order(Order_ID, Order_type) values('" + ID + "', '" + type + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from new_order";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridorder.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtorderid.Text.ToString());
            type = txtorderty.Text;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update new_order set Order_type= '" + type + "' where Order_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data update Successfully");
            conn.Close();
            loadgrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string delete = "delete from new_order where Order_ID = '" + ID + "'";
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
            string search = "select * from  new_order where Order_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtorderty.Text = read["Order_type"].ToString();
            }
            conn.Close();
            loadgrid();
        }
    }
}
