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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Test by elf
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = dbInventory");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM USER WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Success!, Welcome " + username, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainMenuForm m = new MainMenuForm();
                m.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
