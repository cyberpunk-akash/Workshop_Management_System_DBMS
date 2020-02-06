using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Workshopmanagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {
            dashBoard dashboard = new dashBoard();
            dashboard.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //new loginform().Show();
            String uname1 = usernamelogin.Text;
            String pw1 = passwordlogin.Text;
            string hashed_pw1 = Encrypt(pw1);
            // string MyConnection1 = "datasource=localhost;database=wms;username=root;password=mypass";

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wms';username=root;password=kent");

            MySqlDataAdapter adapter;

            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `manager` WHERE `username` = '" + uname1 + "' AND `password` = '" + hashed_pw1 + "'", connection);

            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Wrong credentials entered");
            }
            else
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                new dashBoard().Show();
            }

            table.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new registration().Show();
        }
    }
}
