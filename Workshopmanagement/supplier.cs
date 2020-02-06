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
    public partial class supplier : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        String globalVaraiable = "";
        public DataSet ds = new DataSet();
        public supplier()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            label5.Text = dataGridView1[0, i].Value.ToString();
            textBox1.Text = dataGridView1[1, i].Value.ToString();
            textBox2.Text = dataGridView1[2, i].Value.ToString();
            textBox3.Text = dataGridView1[3, i].Value.ToString();
            textBox4.Text = dataGridView1[4, i].Value.ToString();
            globalVaraiable = label5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill all * marked fields");
            }

            else
            {
                ds = new DataSet();
                adapter = new MySqlDataAdapter("INSERT INTO supplier(supplier_name,supplier_phoneno,supplier_email,supplier_address) VALUES " +
                    "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                adapter.Fill(ds, " supplier");
                MessageBox.Show("added Retailer");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                GetRecords();
            }
        }
        private void GetRecords()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from supplier", conn);
            adapter.Fill(ds, "supplier");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "supplier";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("update supplier set supplier_name= '" + textBox1.Text + "',supplier_phoneno = '" + textBox2.Text + "', supplier_email = '" + textBox3.Text + "' , supplier_address = '" + textBox4.Text + "' where supplier_id = " + label5.Text, conn);
            adapter.Fill(ds, "supplier");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label5.Text = "";
            GetRecords();

        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            
            int i = dataGridView1.CurrentRow.Index;
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from supplier where supplier_id = "+dataGridView1[0, i].Value.ToString(), conn);
            adapter.Fill(ds, "supplier");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label5.Text = "";
            GetRecords();
            }
            */




        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new inventory().ShowDialog();
            this.Close();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashBoard().ShowDialog();
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand("createsupplierList", conn);
            comm.CommandType = CommandType.StoredProcedure;
            String hell = comm.ExecuteNonQuery().ToString();
            MessageBox.Show(hell);


       




         }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand("createsupplierList", conn);
            conn.Open();
            comm.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("emailList", MySqlDbType.VarChar).Value = "";
            String hell = comm.ExecuteNonQuery().ToString();
            MessageBox.Show(hell);


        }
    }
        
}

