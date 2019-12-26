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
    public partial class Items : Form
    {
        ItemManager _ItemManager = new ItemManager();

        public Items()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(itempriceTB.Text))
            {
                MessageBox.Show("Price should not be empty!");
                return;
            }

            //Check UNIQUE
            if (_ItemManager.IsNameExists(itemNameTB.Text))
            {
                MessageBox.Show(itemNameTB.Text + " already exists!");
            }

            bool added = _ItemManager.ItemsAdd(itemNameTB.Text, Convert.ToDouble(itempriceTB.Text));
            if(added)
            {
                MessageBox.Show("Items inserted successfully!");
            }
            else
                MessageBox.Show("Not inserted");

            //Display();
            showDataGridView.DataSource = _ItemManager.Display();

            itemNameTB.Text = "";
            itempriceTB.Text = "";
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            //Display();
            showDataGridView.DataSource = _ItemManager.Display();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _ItemManager.Search(itemNameTB.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(itemIdTB.Text))
            {
                MessageBox.Show("Item id can not be Empty!!!");
                return;
            }

            //Delete
            if (_ItemManager.Delete(Convert.ToInt32(itemIdTB.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            //Display();
            showDataGridView.DataSource = _ItemManager.Display();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(itemIdTB.Text))
            {
                MessageBox.Show("Item id can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(itempriceTB.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_ItemManager.Update(itemNameTB.Text, Convert.ToDouble(itempriceTB.Text), Convert.ToInt32(itemIdTB.Text)))
            {
                MessageBox.Show("Updated");
                //Display();
                showDataGridView.DataSource = _ItemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

            itemIdTB.Text = "";
            itemNameTB.Text = "";
            itempriceTB.Text = "";
        }
    }
}
