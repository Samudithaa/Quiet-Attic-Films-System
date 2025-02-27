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
    public partial class Location : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID;
        string name;

        public Location()
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

        private void Location_Load(object sender, EventArgs e)
        {
            loadgrid();


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
            string insert = "Insert into Location(Location_ID, Loc_Name) values('" + ID + "', '" + name + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtlocationid.Text.ToString());
            name = txtname.Text;
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from Location";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridlocation.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Location set Loc_Name= '" + name + "' Where Location_ID = '"+ID+"'";
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
            string delete = "delete from Location where Location_ID = '" + ID + "'";
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
            string search = "select * from  Location where Location_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtname.Text = read["Loc_Name"].ToString();
            }
            conn.Close();
            loadgrid();
        }
    }
}
