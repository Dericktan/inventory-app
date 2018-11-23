using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace InventoryApp.Class
{
    class Customer
    {
        private string customerCode, customerName, customerType, phoneNumber, address, status;

        // Define Connection to MYSQL
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = dbInventory");

        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
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
                string query = "SELECT kode_customer, nama_customer, jenis_customer, alamat, nohp, status FROM customer";
                myCommand.CommandText = query;
                MySqlDataAdapter mdap = new MySqlDataAdapter(myCommand);
                mdap.Fill(ds, "customer");
                conn.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error when getting the data!");
            }
            return ds;
        }

        public bool insertData(Customer c)
        {
            Boolean status = false;

            try
            {
                string query = "INSERT INTO customer VALUES ('" +
                    c.CustomerCode + "', '" +
                    c.CustomerName + "', '" +
                    c.CustomerType + "', '" +
                    c.PhoneNumber + "', '" +
                    c.Address + "', '" +
                    c.Status + "'";
                runQuery(query);
                status = true;

            }
            catch (Exception)
            {
                MessageBox.Show("There is an error when inserting the data!");
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
            catch (Exception)
            {
                MessageBox.Show("There is an error when updating the data!");
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
            catch (Exception)
            {
                MessageBox.Show("There is an error when updating the data!");
            }
            return status;
        }
    }
}
