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
    public partial class Form4 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();
        public Form4()
        {
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
        {
            try
            {

                string Query = "select supplier_name from wms.supplier";
                //MySqlConnection MyConn = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand = new MySqlCommand(Query, conn);
                conn.Open();
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string name = MyReader.GetString("supplier_name");
                    comboBox1.Items.Add(name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            //ds = new DataSet();
            //adapter = new MySqlDataAdapter("select supplier_name from supplier where supplier_id = " + Convert.ToInt32(textBox1.Text), conn);
            //adapter.Fill(ds, "supplier");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
              //int id = Int32.Parse(comboBox1.Text);
            
            
                int x = Int32.Parse(textBox5.Text);
                string name="";
                int stock=0;
            float amt=0;
           
                MySqlConnection conn1 = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
                String query1 = "Select * from inventory where product_id=" +x;
                //MySqlConnection MyConn = new MySqlConnection(conn1);
                MySqlCommand MyCommand1 = new MySqlCommand(query1, conn1);
                conn1.Open();
                MySqlDataReader MyReader1 = MyCommand1.ExecuteReader();
                while (MyReader1.Read())
                {
                    name = MyReader1.GetString("product_name");
                    stock= Convert.ToInt32(MyReader1["product_stock"]);
                    amt= MyReader1.GetFloat(4);
                    //comboBox1.Items.Add(name);
                }

           

            String msg = " Supplier Name " + comboBox1.Text.ToString() +
                          Environment.NewLine + "Product ID = " + textBox5.Text + "  " + "Product Name = " + name +
                          Environment.NewLine + "Amount =" + amt +
                          Environment.NewLine + "adding 18 % GST" +
                          Environment.NewLine + "Product Total =" + amt*1.18;
            MessageBox.Show(msg);
        }
    }
}