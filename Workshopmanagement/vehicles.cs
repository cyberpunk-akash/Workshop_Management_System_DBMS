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
    public partial class vehicles : Form
    {
        private const string ConnectionString = "DataSource=localhost;database=wms;username=root;password=kent";
        public vehicles()
        {
            InitializeComponent();
        }

        /*private void Vehicles_Load(object sender, EventArgs e)
        {

        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicle_name_add.Text) || string.IsNullOrEmpty(Vehicle_no_add.Text) || string.IsNullOrEmpty(capacity_add.Text))
            {
                MessageBox.Show("Please fill all compulsory fields");
            }

            else { 
            try
            {
                string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
                string Query1 = "insert into wms.vehicle(vehicle_no,vehicle_name,capcity) values('" + Vehicle_no_add.Text + "','" + vehicle_name_add.Text + "','" + capacity_add.Text + "');";
                MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;
                MyConn1.Open();
                MyReader1 = MyCommand1.ExecuteReader();

                MessageBox.Show("Added");

                // MessageBox.Show("name added");

                MyConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                {

                    MySqlConnection con = new MySqlConnection(ConnectionString);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.vehicle", con))
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                {

                    MySqlConnection con = new MySqlConnection(ConnectionString);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.vehicle where vehicle_no in (select vehicle_no from vehicle where capcity>=" + desired_capacity.Text+");", con))
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                {

                    MySqlConnection con = new MySqlConnection(ConnectionString);
                    using (MySqlCommand cmd = new MySqlCommand("select * from wms.vehicle where vehicle.capcity>=" + desired_capacity.Text, con))
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

        private void Remove_Click(object sender, EventArgs e)
        {
            String remove_vehicle = vehicle_remove.Text;
            try
            {
                string MyConnection1 = "datasource=localhost;database=wms;username=root;password=kent";
                string Query1 = "delete from wms.vehicle where vehicle_no= '" + remove_vehicle + "';";
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
        private void Vehicle_no_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Work_Order wrkord = new Work_Order();
            //wrkord.Show();
            //this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new dashBoard().ShowDialog();
            this.Close();
        }
    }
}
