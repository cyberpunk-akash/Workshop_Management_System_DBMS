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
    public partial class retailer : Form
    {
        string MyConnection2 = "datasource=localhost;database=wms;username=root;password=kent";
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public DataSet ds = new DataSet();
        
        public retailer()
        {
            InitializeComponent();
            getRecords();
            dataGridView.Columns[0].HeaderText= "ID";
            dataGridView.Columns[1].HeaderText = "Name";
            dataGridView.Columns[2].HeaderText = "Phone number";
            dataGridView.Columns[3].HeaderText = "Email";
            dataGridView.Columns[4].HeaderText = "Address";
            dataGridView.Columns[0].Width = 25;
            dataGridView.Columns[1].Width = 80;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].Width = 200;

        }

        public void getRecords()
        {
            try
            {
                string Query = "select * from wms.retailer";
                MySqlConnection MyConn = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand;
                MyAdapter.Fill(dTable);
                dataGridView.DataSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string email1 = email.Text;

          
            


            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(addr.Text) || string.IsNullOrEmpty(phoneno.Text))
            {
                MessageBox.Show("Please fill all compulsory fields");
            }
            else
            {
                try
                {


                    string Query = "insert into wms.retailer(retailer_name, retailer_phoneno, retailer_email, retailer_address) " +
                        "values('" + name.Text + "','" + phoneno.Text + "','" + email.Text + "','" + addr.Text + "');";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();

                    MessageBox.Show("Retailer added");
                    name.Clear();
                    phoneno.Clear();
                    email.Clear();
                    addr.Clear();
                    getRecords();
                    // MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receipt rcpt = new Receipt();
            rcpt.ShowDialog();
            this.Close();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int i = dataGridView.CurrentRow.Index;
            label6.Text = dataGridView[0, i].Value.ToString();
            name.Text = dataGridView[1, i].Value.ToString();
            phoneno.Text = dataGridView[2, i].Value.ToString();
            email.Text = dataGridView[3, i].Value.ToString();
            addr.Text = dataGridView[4, i].Value.ToString();

        }

        private void Retailer_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(MyConnection2);
            int i = dataGridView.CurrentRow.Index;
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from retailer where retailer_id = " + dataGridView[0, i].Value.ToString(), MyConn);
            adapter.Fill(ds, "retailer");
            name.Clear();
            email.Clear();
            phoneno.Clear();
            email.Clear();
            label6.Text = "";
            getRecords();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection MyConn = new MySqlConnection(MyConnection2);
            int i = dataGridView.CurrentRow.Index;
            label5.Text = dataGridView[0, i].Value.ToString();
            ds = new DataSet();
            adapter = new MySqlDataAdapter("update retailer set retailer_name= '" + name.Text +
                "',retailer_phoneno = '" + phoneno.Text + "', retailer_email = '" + email.Text + "' , retailer_address = '" + addr.Text + "' where retailer_id = " + label5.Text, MyConn);
            adapter.Fill(ds, "supplier");
            name.Clear();
            email.Clear();
            addr.Clear();
            phoneno.Clear();
            label5.Text = "";
            getRecords();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashBoard().ShowDialog();
            this.Close();
        }
    }
}
