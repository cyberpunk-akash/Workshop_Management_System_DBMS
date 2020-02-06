using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshopmanagement
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        
      /*  private void Button1_Click(object sender, EventArgs e)
        {
            //AddRetailer AddCustomerWindow = new AddRetailer();
            //AddCustomerWindow.Show();
        }
        */

        private void Button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            new retailer().ShowDialog();
            this.Close();


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new supplier().ShowDialog();
            this.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee emp = new employee();
            emp.ShowDialog();
            this.Close();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new vehicles().ShowDialog();
            this.Close();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Work_order().ShowDialog();
            this.Close();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new sum().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new average().Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            new Login().ShowDialog();
           
            this.Close();
        }
    }
}
