using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coffee_Shop_withDB.Repository
{
    public class ItemsRepository
    {
        public bool ItemsAdd(string itemName, double price)
        {
            bool isAdded = false;

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO Items (ItemName, Price) VALUES ('" + itemName + "', " + price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);


                //Execute
                conn.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return isAdded;
        }

        public bool IsNameExists(string itemsName)
        {
            bool isExists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Items WHERE ItemName = '" + itemsName + "' ";
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

        public bool Delete(int itemId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"DELETE FROM Items WHERE ItemId = '" + itemId + "' ";
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

        public bool Update(string itemName, double itemPrice, int itemId)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE Items SET ItemName = '" + itemName + "', Price = " + itemPrice + " WHERE ItemId = " + itemId + "";
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

        public DataTable Display()
        {
            //try
            //{
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Items";
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

        public DataTable Search(string itemName)
        {
            //try
            //{
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Items WHERE ItemName = '" + itemName + "' ";
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
