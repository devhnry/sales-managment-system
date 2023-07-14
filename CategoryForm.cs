using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DG_Sales_Management_System
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            showsdtbtopanel();
        }

        private void showsdtbtopanel()
        {
            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            connectdtb.Open();
            string selectionall = "select * from category";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectionall, connectdtb);
            var categorytable = new DataTable();
            dataadapter.Fill(categorytable);
            catDGV.DataSource = categorytable;
            catid.Clear(); catname.Clear(); catdesc.Clear();
            connectdtb.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        { 
                Application.Exit();
        }
        private void catDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (catDGV.SelectedRows.Count > 0)
            {
                catid.Text = catDGV.SelectedRows[0].Cells[0].Value?.ToString();
                catname.Text = catDGV.SelectedRows[0].Cells[1].Value?.ToString();
                catdesc.Text = catDGV.SelectedRows[0].Cells[2].Value?.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string categoryid, categoryname, categorydesc;
            categoryid = catid.Text;
            categoryname = catname.Text;
            categorydesc = catdesc.Text;
            string dgmarketconnection = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            string insertiondtb = "insert into category values(@catid, @catname, @catdesc)";
            MySqlConnection connectdtb = new MySqlConnection(dgmarketconnection);
            MySqlCommand insert = new MySqlCommand(insertiondtb, connectdtb);
            insert.Parameters.AddWithValue("@catid", categoryid);
            insert.Parameters.AddWithValue("@catname", categoryname);
            insert.Parameters.AddWithValue("@catdesc", categorydesc);
            try
            {
                connectdtb.Open();
                if (catid.Text == String.Empty || catname.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the Details");
                }
                else
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Category Added Succesfully");
                    catid.Clear(); catname.Clear(); catdesc.Clear();
                    connectdtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An Error Occured..Details \n" + ex.Message);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == String.Empty)
                {
                    MessageBox.Show("Select a Category");
                }
                else
                {
                    string dgmarketconnection = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connectdtb = new MySqlConnection(dgmarketconnection);
                    connectdtb.Open();
                    string deletion = "delete from category where catid = " + catid.Text + "";
                    MySqlCommand deletecmd = new MySqlCommand(deletion, connectdtb);
                    deletecmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Succesfully");
                    connectdtb.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showsdtbtopanel();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == String.Empty || catname.Text == String.Empty || catdesc.Text == String.Empty)
                {
                    MessageBox.Show("Missing Information !!");
                }
                else
                {
                    string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
                    connectdtb.Open();
                    string updatecategory = "update category set catname = '" + catname.Text + "', catdesc = '" + catdesc.Text + "'where catid = '" + catid.Text + "'";
                    MySqlCommand update = new MySqlCommand(updatecategory, connectdtb);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Category Succesfully Updated");
                    connectdtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            ProductForm productform = new ProductForm();
            productform.Show();
            this.Hide();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sellersbtn_Click(object sender, EventArgs e)
        {
            sellerForm sellerform = new sellerForm();
            sellerform.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            SignIN sign = new SignIN();
            sign.Show();
            this.Hide();

        }

        private void selling_Click(object sender, EventArgs e)
        {
            sellingForm sellingform = new sellingForm();
            sellingform.Show();
            this.Hide();
        }
    }
}
