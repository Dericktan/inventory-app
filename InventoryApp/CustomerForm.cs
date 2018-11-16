using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private bool validateInputs()
        {
            string jenisPelanggan = cbCustomerType.Text.Trim();
            string kodePelanggan = txtCustomerCode.Text.Trim();
            string namaPelanggan = txtCustomerName.Text.Trim();
            string nohpPelanggan = txtCustomerPhone.Text.Trim();
            string alamatPelanggan = rtbCustomerAddress.Text;
            string keteranganPelanggan = txtCustomerStatus.Text.Trim();

            if (jenisPelanggan == "")
            {
                MessageBox.Show("Please input Jenis Pelanggan");
                return false;
            }
            if (kodePelanggan == "")
            {
                MessageBox.Show("Please input Kode Pelanggan");
                return false;
            }
            if (namaPelanggan == "")
            {
                MessageBox.Show("Please input Nama Pelanggan");
                return false;
            }
            if (nohpPelanggan == "")
            {
                MessageBox.Show("Please input Nomor HP Pelanggan");
                return false;
            }
            if (alamatPelanggan == "")
            {
                MessageBox.Show("Please input Alamat Pelanggan");
                return false;
            }
            if (keteranganPelanggan == "")
            {
                MessageBox.Show("Please input Keteragan Pelanggan");
                return false;
            }

            return true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string jenisPelanggan = cbCustomerType.Text.Trim();
            string kodePelanggan = txtCustomerCode.Text.Trim();
            string namaPelanggan = txtCustomerName.Text.Trim();
            string nohpPelanggan = txtCustomerPhone.Text.Trim();
            string alamatPelanggan = rtbCustomerAddress.Text;
            string keteranganPelanggan = txtCustomerStatus.Text.Trim();

            if (validateInputs())
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = dbInventory");
                string query = "INSERT INTO customer (kode_customer, nama_customer, jenis_customer, nohp, alamat, status) VALUES ('"
                    + kodePelanggan + "', '"
                    + namaPelanggan + "', '"
                    + jenisPelanggan + "', '"
                    + nohpPelanggan + "', '"
                    + alamatPelanggan + "', '"
                    + keteranganPelanggan + "')";
                conn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                MessageBox.Show("Input berhasil!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
