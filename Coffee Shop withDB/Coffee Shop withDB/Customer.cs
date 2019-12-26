using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Coffee_Shop_withDB.BLL;

namespace Coffee_Shop_withDB
{
    public partial class Customer : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        public Customer()
        {
            InitializeComponent();
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            //Set name mandatory
            if (String.IsNullOrEmpty(customerNameTB.Text))
            {
                MessageBox.Show("Customer Name should not be empty!");
                return;
            }
            //Set contact mandatory
            if (String.IsNullOrEmpty(contactTB.Text))
            {
                MessageBox.Show("Customer Contact should not be empty!");
                return;
            }
            //Set address mandatory
            if (String.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("Customer Address should not be empty!");
                return;
            }

            //Check unique
            if (_customerManager.IsContactExists(contactTB.Text))
            {
                MessageBox.Show(contactTB.Text + " already exists!");
            }

            bool isAdded = _customerManager.CustomersAdd(customerNameTB.Text, contactTB.Text, addressTB.Text);

            if(isAdded)
            {
                MessageBox.Show("Customer Information inserted successfully!");
            }
            else
                MessageBox.Show("Not inserted");

            //CustomerDisplay();
            customerShowDataGridView.DataSource = _customerManager.CustomerDisplay();

            customerNameTB.Text = "";
            contactTB.Text = "";
            addressTB.Text = "";
        }

        private void customerShowBtn_Click(object sender, EventArgs e)
        {
            customerShowDataGridView.DataSource = _customerManager.CustomerDisplay();
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            customerShowDataGridView.DataSource = _customerManager.CustomerSearch(Convert.ToInt32(customerIdTB.Text));

            customerIdTB.Text = "";
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(customerIdTB.Text))
            {
                MessageBox.Show("Customer id can not be Empty!!!");
                return;
            }

            //Delete
            if (_customerManager.CustomerDelete(Convert.ToInt32(customerIdTB.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            //CustomerDisplay();
            customerShowDataGridView.DataSource = _customerManager.CustomerDisplay();
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(customerIdTB.Text))
            {
                MessageBox.Show("Customer id can not be Empty!!!");
                return;
            }
            //Set Address as Mandatory
            if (String.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("Address Can not be Empty!!!");
                return;
            }
            //Set Contact as Mandatory
            if (String.IsNullOrEmpty(contactTB.Text))
            {
                MessageBox.Show("Contact Can not be Empty!!!");
                return;
            }

            if (_customerManager.CustomerUpdate(customerNameTB.Text, contactTB.Text, addressTB.Text, Convert.ToInt32(customerIdTB.Text)))
            {
                MessageBox.Show("Updated");
                //CustomerDisplay();
                customerShowDataGridView.DataSource = _customerManager.CustomerDisplay();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

            customerIdTB.Text = "";
            customerNameTB.Text = "";
            addressTB.Text = "";
            contactTB.Text = "";
        }
        
    }
}
