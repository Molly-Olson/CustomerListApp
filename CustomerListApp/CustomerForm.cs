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
        public Customer GetCustomer()
        {
            return _customer;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtFirstName.DataBindings.Add("Text", _customer, "FirstName");
            txtLastName.DataBindings.Add("Text", _customer, "LastName");
            txtEmail.DataBindings.Add("Text", _customer, "Email");
            txtPhone.DataBindings.Add("Text", _customer, "Phone");
        }

        //  not sure what all this was below?

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    txtFirstName.DataBindings.Add("Text", _customer, "FirstName");
        //    txtLastName.DataBindings.Add("Text", _customer, "LastName");
        //    txtEmail.DataBindings.Add("Text", _customer, "Email");
        //    txtPhone.DataBindings.Add("Text", _customer, "Phone");
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
           // MessageBox.Show($"Customer saved: {_customer.FirstName} {_customer.LastName}");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
