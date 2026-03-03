using System.ComponentModel;

namespace CustomerListApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers { get; set; }
        public Form1()
        {
            InitializeComponent();
            Customers = new BindingList<Customer>
            { 
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false
            };

            //Customers.AddRange(new List<Customer>
            //    {
            //    new Customer {
            //        FirstName = "Billie",
            //        LastName = "Olson",
            //        Email = "BRO@gmail.com",
            //        Phone = "555-555-5555"
            //    },
            //      new Customer {
            //        FirstName = "Kimball",
            //        LastName = "Olson2",
            //        Email = "KCO@gmail.com",
            //        Phone = "444-555-5555"
            //    },

           //     });
        }
        //fire code to create new customer, this event action was created by double clicking new customer attribute
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            //Customer data = new Customer("Molly", "Olson", "MO85@centralia.com", "555-555-5555");

            var newCustomerForm = new CustomerForm();

            if (newCustomerForm.ShowDialog() == DialogResult.OK)
            {
                // add the customer
                Customers.Add(newCustomerForm.GetCustomer());
               
            }
        }
        //fire code to edit selected customer also created event action with double click
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as Customer; 

            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a Customer to edit");
                    return;
            }

            customerForm.LoadCustomer(selectedCustomer);
            //{
            //    FirstName = "Molly",
            //    LastName = "Olson",
            //    Email = "MO@gmail.com",
            //    Phone = "555-555-5555"
            //});

            if (customerForm.ShowDialog() == DialogResult.OK)
            {
               // update the customer in the list MessageBox.Show("Dialog returned an ok.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = Customers;
        }
    }
}