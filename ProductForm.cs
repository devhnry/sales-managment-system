using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DG_Sales_Management_System
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private void combinationboxselection()
        {
            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            string selectionquery = "select catname from category";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            MySqlCommand command = new MySqlCommand(selectionquery, connectdtb);
            connectdtb.Open();
            command.ExecuteNonQuery();
            MySqlDataReader datareader = command.ExecuteReader();
            DataTable combinationbox = new DataTable();
            combinationbox.Columns.Add("catname", typeof(string));
            combinationbox.Load(datareader);
            categoryBox.ValueMember = "catname";
            categoryBox.DataSource = combinationbox;
            connectdtb.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combinationboxselection();
            showdtbonpanel();
        }

        private void showdtbonpanel()
        {
            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            connectdtb.Open();
            string selectallquery = "select * from product";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectallquery, connectdtb);
            var categorytable = new DataTable();
            dataadapter.Fill(categorytable);
            prodDGV.DataSource = categorytable;
            pidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear(); pricetxt.Clear();
            connectdtb.Close();
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            CategoryForm categoryform = new CategoryForm();
            categoryform.Show();
            this.Hide();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            string productid, productname, productqty, productprice, productcateg;
            productid = pidtxt.Text;
            productname = pnametxt.Text;
            productqty = quantitytxt.Text;
            productprice = pricetxt.Text;
            productcateg = categoryBox.SelectedValue.ToString();

            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            string insertionquery = "insert into product values(@prodid, @prodname,@prodqty, @prodprice, @prodcat)";
            MySqlConnection connectiondtb = new MySqlConnection(connectiontodgmarket);
            MySqlCommand command = new MySqlCommand(insertionquery, connectiondtb);
            command.Parameters.AddWithValue("@prodid", productid);
            command.Parameters.AddWithValue("@prodname", productname);
            command.Parameters.AddWithValue("@prodqty", productqty);
            command.Parameters.AddWithValue("@prodprice", productprice);
            command.Parameters.AddWithValue("@prodcat", productcateg);
            try
            {
                connectiondtb.Open();
                if (pidtxt.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the Details");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Added Succesfully");
                    pidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear(); pricetxt.Clear();
                    connectiondtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An Error Occured..Details \n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showdtbonpanel();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pidtxt.Text == String.Empty)
                {
                    MessageBox.Show("Missing Information !!");
                }
                else
                {
                    string connectdtbdgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connectdtb = new MySqlConnection(connectdtbdgmarket);
                    connectdtb.Open();
                    string updateproduct = "update product set prodname = '" + pnametxt.Text + "', prodqty = '" + quantitytxt.Text + "',  prodprice = '" + pricetxt.Text + "',  prodcat = '" + categoryBox.SelectedValue.ToString() + "' where prodid = '" + pidtxt.Text + "'";
                    MySqlCommand update = new MySqlCommand(updateproduct, connectdtb);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Product Succesfully Updated");
                    connectdtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void prodDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prodDGV.SelectedRows.Count > 0)
            {
                pidtxt.Text = prodDGV.SelectedRows[0].Cells[0].Value.ToString();
                pnametxt.Text = prodDGV.SelectedRows[0].Cells[1].Value.ToString();
                quantitytxt.Text = prodDGV.SelectedRows[0].Cells[2].Value.ToString();
                pricetxt.Text = prodDGV.SelectedRows[0].Cells[3].Value.ToString();
                categoryBox.SelectedValue = prodDGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pidtxt.Text == String.Empty)
                {
                    MessageBox.Show("Select a Category");
                }
                else
                {
                    string connectdtbdgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connectdtb = new MySqlConnection(connectdtbdgmarket);
                    connectdtb.Open();
                    string deletequery = "delete from product where prodid = " + pidtxt.Text + "";
                    MySqlCommand deletion = new MySqlCommand(deletequery, connectdtb);
                    deletion.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Succesfully");
                    connectdtb.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void cashier_Click(object sender, EventArgs e)
        {
            sellerForm sellerform = new sellerForm();
            sellerform.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectiondtbdgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connectiondtbdgmarket);
            connectdtb.Open();
            string selectionall = "select * from where prodcat ='" + comboBox1.SelectedValue.ToString() + "' ";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectionall, connectdtb);
            MySqlCommandBuilder databuilder = new MySqlCommandBuilder(dataadapter);
            var categorytable = new DataSet();
            dataadapter.Fill(categorytable);
            prodDGV.DataSource = categorytable.Tables[0];
            pidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear();
            connectdtb.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIN sign = new SignIN();
            sign.Show();
        }
    }
}
