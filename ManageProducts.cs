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
    public partial class ManageProducts : Form
    {
        
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gifty\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
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
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        void filterbycategory()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTbl where ProdCat='"+SearchCombo.SelectedValue.ToString()+"'";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + ProdIdTxt.Text + ", '" + ProdNameTxt.Text + "', " + QtyTxt.Text + ", " + PriceTxt.Text + ", '"+ DescriptionTxt.Text +"', '" + CatCombo.SelectedValue.ToString() +"' )", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");

                Con.Close();
                populate();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProdNameTxt.Text + "', ProdQty=" + QtyTxt.Text + ", ProdPrice=" + PriceTxt.Text + ", ProdDesc='"+ DescriptionTxt.Text +"', ProdCat='"+ CatCombo.SelectedValue.ToString()+"' where ProdId=" + ProdIdTxt.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ProdIdTxt.Text == "")
            {
                MessageBox.Show("Enter Product ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProdId = " + ProdIdTxt.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully deleted ");
                Con.Close();
                populate();
            }

        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTxt.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTxt.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            QtyTxt.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTxt.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTxt.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterbycategory();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            populate();
        }











        //Unused snippets
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome hm = new AdminHome();
            hm.Show();
            this.Close();
        }
    }
}
