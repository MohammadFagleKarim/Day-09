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
    public partial class Order : Form
    {
        OrderManager _OrderManager = new OrderManager();

        public Order()
        {
            InitializeComponent();
        }

        private void orderAddBtn_Click(object sender, EventArgs e)
        {
            //Set ItemName mandatory
            if (String.IsNullOrEmpty(orderItemNameTB.Text))
            {
                MessageBox.Show("Item Name should not be empty!");
                return;
            }
            //Set Quantity mandatory
            if (String.IsNullOrEmpty(quantityTB.Text))
            {
                MessageBox.Show("Quantity should not be empty!");
                return;
            }
            //Set TotalPrice mandatory
            if (String.IsNullOrEmpty(totalPriceTB.Text))
            {
                MessageBox.Show("Price should not be empty!");
                return;
            }
            //Set CustomerName mandatory
            if (String.IsNullOrEmpty(OrderCustomerNameTB.Text))
            {
                MessageBox.Show("Customer Name should not be empty!");
                return;
            }

            //Check unique
            if (_OrderManager.IsCustomerExists(OrderCustomerNameTB.Text))
            {
                MessageBox.Show(OrderCustomerNameTB.Text + " already exists!");
            }

            bool isAdded = _OrderManager.OrdersAdd(orderItemNameTB.Text, Convert.ToInt32(quantityTB.Text), Convert.ToDouble(totalPriceTB.Text), OrderCustomerNameTB.Text);

            if (isAdded)
            {
                MessageBox.Show("Order Information inserted successfully!");
            }
            else
                MessageBox.Show("Not inserted");

            //CustomerDisplay();
            orderShowDataGridView.DataSource = _OrderManager.OrderDisplay();

            orderItemNameTB.Text = "";
            quantityTB.Text = "";
            totalPriceTB.Text = "";
            OrderCustomerNameTB.Text = "";
        }

        private void orderShowBtn_Click(object sender, EventArgs e)
        {
            orderShowDataGridView.DataSource = _OrderManager.OrderDisplay();
        }

        private void orderDeleteBtn_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(orderIdTB.Text))
            {
                MessageBox.Show("Order id can not be Empty!!!");
                return;
            }

            //Delete
            if (_OrderManager.OrdersDelete(Convert.ToInt32(orderIdTB.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            //CustomerDisplay();
            orderShowDataGridView.DataSource = _OrderManager.OrderDisplay();
        }

        private void orderUpdateBtn_Click(object sender, EventArgs e)
        {
            //Set OrderId as Mandatory
            if (String.IsNullOrEmpty(orderIdTB.Text))
            {
                MessageBox.Show("Order id can not be Empty!!!");
                return;
            }
            //Set ItemName mandatory
            if (String.IsNullOrEmpty(orderItemNameTB.Text))
            {
                MessageBox.Show("Item Name should not be empty!");
                return;
            }
            //Set Quantity mandatory
            if (String.IsNullOrEmpty(quantityTB.Text))
            {
                MessageBox.Show("Quantity should not be empty!");
                return;
            }
            //Set TotalPrice mandatory
            if (String.IsNullOrEmpty(totalPriceTB.Text))
            {
                MessageBox.Show("TotalPrice should not be empty!");
                return;
            }
            //Set CustomerName mandatory
            if (String.IsNullOrEmpty(OrderCustomerNameTB.Text))
            {
                MessageBox.Show("Customer Name should not be empty!");
                return;
            }

            if (_OrderManager.OrdersUpdate(orderItemNameTB.Text, Convert.ToInt32(quantityTB.Text), Convert.ToDouble(totalPriceTB.Text), OrderCustomerNameTB.Text, Convert.ToInt32(orderIdTB.Text)))
            {
                MessageBox.Show("Updated");
                //CustomerDisplay();
                orderShowDataGridView.DataSource = _OrderManager.OrderDisplay();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

            orderIdTB.Text = "";
            orderItemNameTB.Text = "";
            quantityTB.Text = "";
            totalPriceTB.Text = "";
            OrderCustomerNameTB.Text = "";
        }

        private void orderSearchBtn_Click(object sender, EventArgs e)
        {
            orderShowDataGridView.DataSource = _OrderManager.CustomerSearch(Convert.ToInt32(orderIdTB.Text));
        }
    }
}
