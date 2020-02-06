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

namespace Workshopmanagement
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            

        }

        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  comboBox1.Items.Add("Tokyo");
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(empname.Text) || string.IsNullOrEmpty(empemail.Text) || string.IsNullOrEmpty(empnumber.Text) )
            {
                MessageBox.Show("Please fill all compulsory fields");
            }
            else
            {
                try
                {
                    String gender = comboBox1.Text;


                    string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
                    string Query = "insert into wms.employee(name,email,mobile_number,gender) values('" + empname.Text +
                        "','" + empemail.Text + "','" + empnumber.Text + "','" + gender + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();
                    MyConn2.Close();
                    MessageBox.Show("Employee added");
                    //  MyConn2.Open();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


      
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                {
                    string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
                    MySqlConnection con = new MySqlConnection(MyConnection2);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.employee ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                // dataGridView1.ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String remove_emp = empremove.Text;
            try
            {
                string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
                string Query1 = "delete from wms.employee where emp_id= '" + remove_emp + "';";
                MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;
                MyConn1.Open();
                MyReader1 = MyCommand1.ExecuteReader();

                MessageBox.Show("Removed");

                // MessageBox.Show("name added");

                MyConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            label7.Text = dataGridView1[0, i].Value.ToString();
            empname.Text = dataGridView1[1, i].Value.ToString();
            empnumber.Text = dataGridView1[2, i].Value.ToString();
            empemail.Text = dataGridView1[3, i].Value.ToString();
            comboBox1.Text = dataGridView1[4, i].Value.ToString();
        }
        private void GetRecords()
        {

            string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
            DataSet ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from employee", MyConnection1);
            adapter.Fill(ds, "employee");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "employee";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // int i = dataGridView1.CurrentRow.Index;
            //int id = dataGridView1[0, i].Value.ToString();
            string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
            //  DataSet ds = new DataSet();
            //String q1 = "update warehouse_db.employee set name=" + empname.Text + ",email=" + empemail + ",mobile_number=" + empnumber.Text + "where emp_id=" + label7.Text + ";";
            //   adapter = new MySqlDataAdapter(q1, MyConnection1);
            // adapter.Fill(ds, "employee");
            //empemail.Clear();
            //  empname.Clear();
            //empnumber.Clear();
            //GetRecords();

            String q1 = "update wms.employee set name='" + empname.Text + "', gender='" + comboBox1.Text + "', email='" +
                empemail.Text + "',mobile_number='" + empnumber.Text + "' where emp_id=" + label7.Text + ";";
            DataSet ds = new DataSet();
            adapter = new MySqlDataAdapter(q1, MyConnection1);
            adapter.Fill(ds, "employee");
            empnumber.Clear();
            empname.Clear();
            empemail.Clear();
            label7.Text = "";
            // textBox4.Clear();
            label5.Text = "";
            GetRecords();

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void Employee_Load_1(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashBoard().ShowDialog();
                this.Close();
        }
    }
}
