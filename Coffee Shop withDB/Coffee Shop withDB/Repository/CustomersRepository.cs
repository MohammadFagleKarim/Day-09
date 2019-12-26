using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coffee_Shop_withDB.Repository
{
    public class CustomersRepository
    {
        public bool CustomersAdd(string customerName, string customerContact, string customerAddress)
        {
            bool IsAdded = false;

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('" + customerName + "', '" + customerContact + "', '" + customerAddress + "')";
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

        public bool IsContactExists(string customerContact)
        {
            bool isExists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Customers WHERE Contact = '" + customerContact + "' ";
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

        public bool CustomerDelete(int customerId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"DELETE FROM Customers WHERE CustomerId = '" + customerId + "' ";
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

        public bool CustomerUpdate(string customerName, string customerContact, string customerAddress, int customerId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE Customers SET CustomerName = '" + customerName + "', Address = '" + customerAddress + "' ," +
                    " Contact = '" + customerContact + "' WHERE CustomerId = '" + customerId + "' ";
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

        public DataTable CustomerDisplay()
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Customers";
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

        public DataTable CustomerSearch(int customerId)
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Customers WHERE CustomerId = '" + customerId + "' ";
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
