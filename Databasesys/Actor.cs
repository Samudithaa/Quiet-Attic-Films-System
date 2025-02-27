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
using System.Security.Cryptography;

namespace Databasesys
{
    public partial class Actor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=Quietattic;Integrated Security=True;Encrypt=False");

        int ID, contno;
        string name, address, salary;

        public Actor()
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

        private void Actor_Load(object sender, EventArgs e)
        {
            loadgrid();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Actor set Actor_Name= '" + name + "',Actor_Address= '" + address + "',Salary='" + salary + "',Cont_No='" + contno + "' where Actor_ID = '"+ID+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data update Successfully");
            conn.Close();
            loadgrid();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtsearch.Text);
            conn.Open();
            string delete = "delete from Actor where Actor_ID = '" + ID + "'";
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
            string search = "select * from  Actor where Actor_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtname.Text = read["Actor_Name"].ToString();
                txtaddr.Text = read["Actor_Address"].ToString();
                txtsalary.Text = read["Salary"].ToString();
                txtcont.Text = read["Cont_No"].ToString();
            }
            conn.Close();
            loadgrid();
        }

        private void datagridactor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Actor(Actor_ID, Actor_Name, Actor_Address, Salary, Cont_No) values('" + ID + "', '" + name + "', '" + address + "', '" + salary + "', '" + contno + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add");
            conn.Close();
            loadgrid();
        }

        private void loadgrid()
        {
            conn.Open();
            string querry = "Select * from Actor";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            datagridactor.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void Loadelement()
        {
            ID = int.Parse(txtactorid.Text.ToString());
            name = txtname.Text;
            address = txtaddr.Text;
            salary = txtsalary.Text;
            contno = int.Parse(txtcont.Text.ToString());

        }
    }
}
