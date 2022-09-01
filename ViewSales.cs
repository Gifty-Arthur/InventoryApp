using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
            populateproducts();
        }
    
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gifty\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populateproducts()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
