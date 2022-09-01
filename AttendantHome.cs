using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class AttendantHome : Form
    {
        public AttendantHome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageSales sales = new ManageSales();
            sales.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }
    }
}
