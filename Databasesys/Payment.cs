using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Databasesys
{
    public partial class Payment : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID;
        string type, date;

        public Payment()
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

        private void Payment_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Payment(Payment_ID, Pay_type, Pay_Date) values('" + ID + "', '" + type + "', '" + date + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtpayid.Text.ToString());
            type = txtpaytype.Text;
            date = txtpaydate.Text;
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Payment set Pay_type= '" + type + "',Pay_Date= '" + date + "' where Payment_ID = '"+ID+"'";
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
            string delete = "delete from Payment where Payment_ID = '" + ID + "'";
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
            string search = "select * from  Payment where Payment_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtpaytype.Text = read["Pay_type"].ToString();
                txtpaydate.Text = read["Pay_Date"].ToString();
            }
            conn.Close();
            loadgrid();
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from Payment";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridpayment.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
