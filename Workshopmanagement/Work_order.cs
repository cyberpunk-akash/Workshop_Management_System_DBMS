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
    public partial class Work_order : Form

    {
        private const string ConnectionString = "DataSource=localhost;database=wms;username=root;password=kent";
        MySqlConnection conn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();
        public Work_order()
        {
            InitializeComponent();
        }

        private void Work_order_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            
            string query = "select emp_id from employee;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetInt32(0));
                    // reader["colname"]
                }
            }

            conn.Close();
            conn = new MySqlConnection(ConnectionString);
            conn.Open();

            query = "select vehicle_no from vehicle;";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    comboBox5.Items.Add(reader.GetString(0));

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
                string Query1 = "insert into wms.work_order(emp_id,vehicle_no,capcity) values('" + Vehicle_no_add.Text + "','" + vehicle_name_add.Text + "','" + capacity_add.Text + "');";
                MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;
                MyConn1.Open();
                MyReader1 = MyCommand1.ExecuteReader();

                MessageBox.Show("Added");

                // MessageBox.Show("name added");

                MyConn1.Close();

                */
                ds = new DataSet();
                adapter = new MySqlDataAdapter("INSERT INTO work_order(emp_id,vehicle_no,product_id,status,comments) VALUES " +
                    "('" + comboBox1.Text + "','" + comboBox5.Text + "','" + textBox2.Text + "','"+ comboBox2.Text
                    +"','"+ textBox6.Text+"')", conn);
                adapter.Fill(ds, " work_order");
                MessageBox.Show("added Retailer");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int id1 = Convert.ToInt32(textBox1.Text);
            int id2 = Convert.ToInt32(textBox2.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(comboBox1.Text);

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();

            string query = "select name from employee where emp_id ='" + id + "';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    display_empName.Text = reader.GetString(0);
                }
            }

            conn.Close();



        }
        /*
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                {

                    MySqlConnection con = new MySqlConnection(ConnectionString);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.work_order having work_order.status=Pending", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView2.DataSource = dt;
                                dataGridView2.ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }*/
        
        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String no = comboBox5.Text;

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();

            string query = "select vehicle_name from vehicle where vehicle_no='" + no + "';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    display_vehiclename.Text = reader.GetString(0);
                }
            }

            conn.Close();
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new dashBoard().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                {

                    MySqlConnection con = new MySqlConnection(ConnectionString);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.work_order ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView2.DataSource = dt;
                                dataGridView2.ReadOnly = true;
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
    }
}
