using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Use this to require the Class we created
using InventoryApp.Class;

namespace InventoryApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        CustomerMain customerClass = new CustomerMain();

        // if customerCode exist, user is in edit mode
        // if not exist, considered as inputting new customer
        string customerCode;

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataMember = "customer";
            LoadData();
        }
        
        void LoadData()
        {
            DataSet data = customerClass.getData();
            dataGridView1.DataSource = data;
            ClearInputs();
        }

        void ClearInputs()
        {
            cbCustomerType.Text = "";
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            rtbCustomerAddress.Text = "";
            txtCustomerStatus.Text = "";

            customerCode = "";
            btnSave.Text = "Simpan";
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
                Customer c = new Customer();
                c.CustomerCode = kodePelanggan;
                c.CustomerName = namaPelanggan;
                c.CustomerType = jenisPelanggan;
                c.PhoneNumber = nohpPelanggan;
                c.Address = alamatPelanggan;
                c.Status = keteranganPelanggan;
                customerClass.insertData(c);
                LoadData();
                
                MessageBox.Show("Input berhasil!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string jenisPelanggan = cbCustomerType.Text.Trim();
            string kodePelanggan = txtCustomerCode.Text.Trim();
            string namaPelanggan = txtCustomerName.Text.Trim();
            string nohpPelanggan = txtCustomerPhone.Text.Trim();
            string alamatPelanggan = rtbCustomerAddress.Text;
            string keteranganPelanggan = txtCustomerStatus.Text.Trim();

            if (validateInputs())
            {
                Customer c = new Customer();
                c.CustomerCode = kodePelanggan;
                c.CustomerName = namaPelanggan;
                c.CustomerType = jenisPelanggan;
                c.PhoneNumber = nohpPelanggan;
                c.Address = alamatPelanggan;
                c.Status = keteranganPelanggan;
                Console.WriteLine("Save Clicked!");
                Console.WriteLine(c.ToString());
                Console.WriteLine("Save Clicked!");
                if (customerCode == "" || customerCode == null)
                {
                    customerClass.insertData(c);
                    MessageBox.Show("Inserted Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    customerClass.updateData(c, customerCode);
                    MessageBox.Show("Updated Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCustomerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbCustomerType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtbCustomerAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCustomerPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCustomerStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            customerCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            btnSave.Text = "Rubah";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerCode == "" || customerCode == null)
            {
                MessageBox.Show("You need to select a customer to be delete!");
            }
            else
            {
                customerClass.deleteData(customerCode);
                LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
