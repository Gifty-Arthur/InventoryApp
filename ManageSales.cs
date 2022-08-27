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
    public partial class ManageSales : Form
    {
        public ManageSales()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gifty\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populateproducts()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        void fillcategory()
        {
            string query = "select * from CategoryTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void updateproduct()
        {
            Con.Open();
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTxt.Text);
            if (newQty < 0)
                MessageBox.Show("Operation Failed");
            else
            {
                string query = "update ProductTbl set ProdQty = " + newQty + " where ProdId = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
           
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void ManageSales_Load(object sender, EventArgs e)
        {
            populateproducts();
            fillcategory();
        }

        int flag = 0;
        int stock;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTxt.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        DataTable table = new DataTable();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (QtyTxt.Text == "")
            {
                MessageBox.Show("Enter the required quantity of products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else if (Convert.ToInt32(QtyTxt.Text) > stock)
            {
                MessageBox.Show("Not enough stock available");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTxt.Text);
                totprice = qty * uprice;
                table.Columns.Add("Num", typeof(int));
                table.Columns.Add("Product", typeof(string));
                table.Columns.Add("Qty", typeof(int));
                table.Columns.Add("UPrice", typeof(int));
                table.Columns.Add("TotPrice", typeof(int));
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
            updateproduct();
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            if(OrdIdTxt.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Fill in the data correctly!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values("+ OrdIdTxt.Text +", '"+ OrdDate.Text +"', "+ TotAmount.Text +")", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully Added");

                    Con.Close();
                    //populate();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
