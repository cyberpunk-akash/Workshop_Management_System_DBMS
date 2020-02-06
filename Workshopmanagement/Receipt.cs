using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace Workshopmanagement
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            FillCombo();
        }

        
        MySqlConnection MyConn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        //public DataSet ds = new DataSet();
        string name1;
        void FillCombo()
        {
            try
            {
                
                string Query = "select retailer_name from wms.retailer";
                //MySqlConnection MyConn = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MyConn.Open();
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string name = MyReader["retailer_name"].ToString();
                    comboBox1.Items.Add(name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            //string name1;
            
            string retailer = comboBox1.Text.ToString();
            int distance=Convert.ToInt32(textBox2.Text);


            MySqlConnection conn1 = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
            String query1 = "Select * from inventory where product_id=" + x;
            //MySqlConnection MyConn = new MySqlConnection(conn1);
            MySqlCommand MyCommand1 = new MySqlCommand(query1, conn1);
            conn1.Open();
            MySqlDataReader MyReader1 = MyCommand1.ExecuteReader();
            while (MyReader1.Read())
            {
                name1 = MyReader1.GetString("product_name");
                
            }



            

            MySqlConnection MyConn1 = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
                MyConn1.Open();
                MySqlCommand cmd = new MySqlCommand("get_retail_id", MyConn1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", MySqlDbType.VarChar).Value = comboBox1.SelectedValue;
                cmd.ExecuteNonQuery();
                
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        label5.Text = reader["retailer"].ToString();

                        
                    }

                }
            string query = "insert into retailer_receipt values(retailer_name, product_id, receipt_amount) values()";


                
            String msg = " Retailer Name " + retailer +
                      Environment.NewLine + "Product ID = " + x + "  " + "Product Name = " + name1 +
                      Environment.NewLine + "Amount =" + (distance * 15);
            MessageBox.Show(msg);


            // string Query = "insert into wms.retailer_receipt(retailer_id, product_id, date_delivered) " +
            //      "values('" + label5.Text() + "'," + Convert.ToInt32((textBox1.Text) + ",'" + textBox2.Text + "')";
        }
           
        }
    }

