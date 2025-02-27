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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Databasesys
{
    public partial class Property : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID;
        string name, type;

        public Property()
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

        private void Property_Load(object sender, EventArgs e)
        {
            loadgrid();

        }

        private void button1_Click(object sender, EventArgs e)
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
            string insert = "Insert into Property(Property_ID, Prop_Name, Prop_Type) values('" + ID + "', '" + name + "', '" + type + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from Property";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridproperty.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Property set Prop_Name= '" + name + "', Prop_Type= '" + type + "'  where Property_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated Successfully");
            conn.Close();
            loadgrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string delete = "delete from Property where Property_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted Successfully");
            conn.Close();
            loadgrid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string search = "select * from  Property where Property_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtname.Text = read["Prop_Name"].ToString();
                txtproptype.Text = read["Prop_Type"].ToString();
            }
            conn.Close();
            loadgrid();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtpropid.Text.ToString());
            name = txtname.Text;
            type = txtproptype.Text;
        }
    }
}
