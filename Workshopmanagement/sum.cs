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
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }
        MySqlConnection MyConn = new MySqlConnection("Server=localhost;User Id=root;Password=kent;Database=wms");
        MySqlDataAdapter adapter = new MySqlDataAdapter();


        private void Sum_Load(object sender, EventArgs e)
        {
            String query = "SELECT SUM(product_amount) AS tp,supplier.supplier_name AS s FROM supplier, inventory WHERE inventory.supplier_id = supplier.supplier_id GROUP BY supplier.supplier_name HAVING AVG(product_amount) >= 750; ";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MyConn.Open();
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                textBox1.Text = MyReader["tp"].ToString();
                textBox2.Text = MyReader["s"].ToString();


            }
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
