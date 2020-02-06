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
    public partial class inventory : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();
        public inventory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("INSERT INTO inventory (supplier_id,product_name,product_stock,product_amount) VALUES ('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
            adapter.Fill(ds, " inventory ");
            MessageBox.Show("added Retailer");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            GetRecords();
        }
        private void GetRecords()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from inventory", conn);
            adapter.Fill(ds, "inventory");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "inventory";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            label1.Text = dataGridView1[0, i].Value.ToString();
            textBox4.Text = dataGridView1[1, i].Value.ToString();
            textBox1.Text = dataGridView1[2, i].Value.ToString();
            textBox2.Text = dataGridView1[3, i].Value.ToString();
            textBox3.Text = dataGridView1[4, i].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("update inventory set supplier_id =" + textBox4.Text +
                ",product_name= '" + textBox1.Text + "',product_stock = '" + textBox2.Text +
                "', product_amount = " + textBox3.Text + " where product_id = " + Convert.ToInt32(label1.Text), conn);
            adapter.Fill(ds, "inventory");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //label5.Text = "";
            //label1.Text = "";
            GetRecords();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from inventory where product_id = " + dataGridView1[0, i].Value.ToString(), conn);
            adapter.Fill(ds, "inventory");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label1.Text = "";
            GetRecords();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashBoard().ShowDialog();
            this.Close();
        }
    }
}
