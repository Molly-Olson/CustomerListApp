using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerListApp
{
    public partial class CustomerForm : Form
    {
        private Customer _customer;


        // constructor with data
        //public CustomerForm(Customer data)
        //{
        //    InitializeComponent();
        //    _customer = data;
        //}
        // constructor without data
        public CustomerForm()
        {
            InitializeComponent();
            _customer = new Customer();
        }
        //below single function to load a customer
        public void LoadCustomer(Customer customer)
        {
            _customer = customer;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            lblFirstName.DataBindings.Add("Text", _customer, "FirstName");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.DataBindings.Add("Text", _customer, "FirstName");
            txtLastName.DataBindings.Add("Text", _customer, "LastName");
            txtEmail.DataBindings.Add("Text", _customer, "Email");
            txtPhone.DataBindings.Add("Text", _customer, "Phone");
        }
    }
}
