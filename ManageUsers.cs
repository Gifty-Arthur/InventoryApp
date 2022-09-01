using System.Data;
using System.Data.SqlClient;

namespace InventoryApp
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gifty\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form3_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + UnameTxt.Text + "', '" + FnameTxt.Text + "', '" + PassTxt.Text + "', '" + PhoneTxt.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");

                Con.Close();
                populate();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTxt.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTxt.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PassTxt.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTxt.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PhoneTxt.Text == "")
            {
                MessageBox.Show("Enter phone number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where Uphone = '" + PhoneTxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted ");
                Con.Close();
                populate();
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + UnameTxt.Text + "', Ufullname='" + FnameTxt.Text + "', Upassword='" + PassTxt.Text + "' where Uphone='" + PhoneTxt.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome hm = new AdminHome ();
            hm.Show ();
            this.Close ();
        }
    }
}
