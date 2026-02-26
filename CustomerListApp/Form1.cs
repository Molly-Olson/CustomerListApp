using System.ComponentModel;

namespace CustomerListApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers { get; set; }
        public Form1()
        {
            InitializeComponent();
            Customers = new List<Customer>();
        }
        //fire code to create new customer, this event action was created by double clicking new customer attribute
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Customer data = new Customer("Molly", "Olson", "MO85@centralia.com", "555-555-5555");

            var newCustomerForm = new CustomerForm();
            newCustomerForm.ShowDialog();
        }
        //fire code to edit selected customer also created event action with double click
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.LoadCustomer(new Customer { 
                FirstName = "Molly", 
                LastName = "Olson",
                Email = "MO@gmail.com",
                Phone = "555-555-5555"
            });
            customerForm.ShowDialog();
        }
    }
}