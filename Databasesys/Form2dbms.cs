using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesys
{
    public partial class Form2dbms : Form
    {
        public Form2dbms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            staff newform = new staff();
            this.Hide();
            newform.Show();
            
        }

        private void btncus_Click(object sender, EventArgs e)
        {
            Customer newform = new Customer();
            this.Hide();
            newform.Show();
        }

        private void btndirect_Click(object sender, EventArgs e)
        {
            Director newform = new Director();
            this.Hide();
            newform.Show();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            Location newform = new Location();
            this.Hide();
            newform.Show();
        }

        private void btnprop_Click(object sender, EventArgs e)
        {
            Property newform = new Property();
            this.Hide();
            newform.Show();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            Payment newform = new Payment();
            this.Hide();
            newform.Show();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            Order newform = new Order();
            this.Hide();
            newform.Show();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Production newform = new Production();
            this.Hide();
            newform.Show();
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            Actor newform = new Actor();
            this.Hide();
            newform.Show();
        }
    }
}
