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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;

            String gender = null;
            if (radioButton1.Checked == true) { gender = "Male"; }

            if (radioButton2.Checked == true) { gender = "Female"; }

        //    if (string.IsNullOrEmpty(this.password.Text) || string.IsNullOrEmpty(repassword.Text)) { MessageBox.Show("Please fill the password fields."); }

          

           // if (String.IsNullOrEmpty(username.Text)) { MessageBox.Show("Please enter a username."); }

          //  if (String.IsNullOrEmpty(mobile.Text)) { MessageBox.Show("Please enter your mobile number."); }

           // if (String.IsNullOrEmpty(email.Text)) { MessageBox.Show("Please enter your email."); }



            String hashed_pw = null;
            String password1 = password.Text;
            hashed_pw = Encrypt(password1);



            if (String.IsNullOrEmpty(fname.Text) || String.IsNullOrEmpty(mname.Text) || String.IsNullOrEmpty(lname.Text) || String.IsNullOrEmpty(mobile.Text) || String.IsNullOrEmpty(username.Text) ||
                String.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(this.password.Text) || string.IsNullOrEmpty(repassword.Text))
            {
                MessageBox.Show("Please fill all compulsory fields");
            }
            if (!this.password.Text.Equals(repassword.Text)) { MessageBox.Show("Passwords do not match."); }

            else
            {
                try
                {

                    string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
                    string Query = "insert into wms.manager(username,password,email,mobile_number,gender) values('" + username.Text + "','" + hashed_pw + "','" + email.Text + "','" + mobile.Text + "','" + gender + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();


                    MyConn2.Close();
                    //  MyConn2.Open();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //////////////////////////////////
                ///checking if trigger did or not
                ///



                try
                {
                    string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
                    string Query = "select count(*) as c from (select manager_id from manager where manager.username = '" + username.Text + "') as id;";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MyConn.Open();
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();
                    while (MyReader.Read())
                    {
                        flag = MyReader.GetInt32("c");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }





                if (flag == 1)
                {

                    try
                    {
                        string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
                        string Query1 = "insert into wms.manager_name(manager_first_name,manager_middle_name,manager_last_name) values('" + fname.Text + "','" + mname.Text + "','" + lname.Text + "');";
                        MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                        MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                        MySqlDataReader MyReader1;
                        MyConn1.Open();
                        MyReader1 = MyCommand1.ExecuteReader();

                        MessageBox.Show("Added");

                        // MessageBox.Show("name added");

                        MyConn1.Close();
                        new Login().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


        }
    }
}
