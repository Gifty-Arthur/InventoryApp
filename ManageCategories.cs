using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryApp
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gifty\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CatIdTxt.Text + "', '" + CatNameTxt.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");

                Con.Close();
                populate();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTxt.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTxt.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(CatIdTxt.Text == "")
            {
                MessageBox.Show("Enter the category ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTbl where CatId='" + CatIdTxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully deleted");
                Con.Close();
                populate();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName ='" + CatNameTxt.Text + "' where CatId='" + CatIdTxt.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome hm = new AdminHome();
            hm.Show();
            this.Close();
        }
    }
}
