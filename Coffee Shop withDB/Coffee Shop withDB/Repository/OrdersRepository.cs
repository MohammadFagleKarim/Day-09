using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coffee_Shop_withDB.Repository
{
    class OrdersRepository
    {
        public bool OrdersAdd(string itemName, int itemQuantity, double totalPrice, string customerName)
        {
            bool IsAdded = false;

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO Orders(ItemName, Quantity, TotalPrice, CustomerName) VALUES ('" + itemName + "', " + itemQuantity + ", " + totalPrice + ", '" + customerName + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Execute
                conn.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    IsAdded = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return IsAdded;
        }

        public bool IsCustomerExists(string customerName)
        {
            bool isExists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Orders WHERE CustomerName = '" + customerName + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Execute
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExists = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return isExists;
        }

        public bool OrdersDelete(int orderId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"DELETE FROM Orders WHERE OrderId = '" + orderId + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Execute
                conn.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool OrdersUpdate(string itemName, int itemQuantity, double totalPrice, string customerName, int orderId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE Orders SET ItemName = '" + itemName + "', Quantity = " + itemQuantity + ", TotalPrice = " + totalPrice + " , CustomerName = '" + customerName + "' WHERE OrderId = " + orderId + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Execute
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return false;
        }

        public DataTable OrderDisplay()
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Execute
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //    MessageBox.Show("Data not found");

            conn.Close();
            //}
            //catch (Exception exeption)
            //{
            //    MessageBox.Show(exeption.Message);
            //}

            return dataTable;
        }

        public DataTable CustomerSearch(int orderId)
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Orders WHERE OrderId = '" + orderId + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Execute
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //    MessageBox.Show("Data not found");

            //Close
            conn.Close();

            //}
            //catch (Exception exeption)
            //{
            //    MessageBox.Show(exeption.Message);
            //}

            return dataTable;
        }
    }
}
