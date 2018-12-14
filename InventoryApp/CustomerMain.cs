using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

// Use this to require the Class we created
using InventoryApp.Class;

namespace InventoryApp
{
    class CustomerMain
    {
        // Define Connection to MYSQL
        private string config = "server = localhost; user id = root; database = dbInventory";
        MySqlConnection conn = new MySqlConnection();

        public CustomerMain()
        {
            conn.ConnectionString = config;
        }

        public void runQuery(string query)
        {
            conn.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = query;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = conn;
                myCommand.CommandType = CommandType.Text;
                string query = "SELECT kode_customer AS 'Kode Customer', nama_customer AS 'Nama Customer', jenis_customer AS 'Jenis Customer', alamat AS 'Alamat', nohp AS 'No Telpon', status AS 'Status' FROM customer";
                myCommand.CommandText = query;
                MySqlDataAdapter mdap = new MySqlDataAdapter(myCommand);
                mdap.Fill(ds, "customer");
                conn.Close();
                return ds;
            }
            catch (Exception)
            {
                Console.WriteLine("There is an error when getting the data!");
            }
            return ds;
        }

        public bool insertData(Customer c)
        {
            Boolean status = false;
            try
            {
                string query = "INSERT INTO customer (kode_customer, nama_customer, jenis_customer, nohp, alamat, status) VALUES ('" +
                    c.CustomerCode + "', '" +
                    c.CustomerName + "', '" +
                    c.CustomerType + "', '" +
                    c.PhoneNumber + "', '" +
                    c.Address + "', '" +
                    c.Status + "')";
                runQuery(query);
                status = true;

            }
            catch (MySqlException e)
            {
                Console.WriteLine("There is an error when inserting the data!");
            }

            return status;
        }

        public bool updateData(Customer c, string customerCode)
        {
            Boolean status = false;
            try
            {
                string query = "UPDATE customer SET kode_customer='" +
                    c.CustomerCode + "', nama_customer ='" +
                    c.CustomerName + "', jenis_customer ='" +
                    c.CustomerType + "', nohp ='" +
                    c.PhoneNumber + "', alamat ='" +
                    c.Address + "', status ='" +
                    c.Status + "' WHERE kode_customer = '" +
                    customerCode + "'";
                runQuery(query);
                status = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("There is an error when updating the data!");
            }
            return status;
        }

        public bool deleteData(string customerCode)
        {
            Boolean status = false;
            try
            {
                string query = "DELETE FROM customer WHERE kode_customer = '" + customerCode + "'";
                runQuery(query);
                status = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("There is an error when updating the data!");
            }
            return status;
        }
    }
}
