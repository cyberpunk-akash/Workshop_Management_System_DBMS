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
    public partial class average : Form
    {
        public average()
        {
            InitializeComponent();
        }
        MySqlConnection MyConn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void Average_Load(object sender, EventArgs e)
        {
            String query = "SELECT P.product_id AS PID,P.receipt_amount AS price,C.retailer_name AS R FROM retailer_receipt P, retailer C WHERE P.retailer_id = C.retailer_id AND P.receipt_amount =(SELECT MAX(P.receipt_amount) FROM retailer_receipt P WHERE P.retailer_id = C.retailer_id)";
     
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MyConn.Open();
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                textBox1.Text = MyReader["PID"].ToString();
                textBox2.Text = MyReader["price"].ToString()+"Rupees";
                textBox1.Text = MyReader["R"].ToString();
                

            }

        }
    }
}
