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

        public string ToString()
        {
            return "Customer Code: " + customerCode + ", Customer Name: " + customerName + ", Customer Type: " + customerType + ", Phone Number: " + phoneNumber + ", Alamat: " + address + ", Status: " + status;
        }
    }
}
