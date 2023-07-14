using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DG_Sales_Management_System
{
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }

        private void showdtbonpanel()
        {
            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            connectdtb.Open();
            string selection = "select * from seller";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selection, connectdtb);
            var categorytable = new DataTable();
            dataadapter.Fill(categorytable);
            sellerDGV.DataSource = categorytable;
            sellerid.Clear(); sellername.Clear(); sellerage.Clear(); sellerphone.Clear(); sellerpass.Clear();
            connectdtb.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdtbonpanel();
        } 
        private void addBtn_Click(object sender, EventArgs e)
        {
            string sellersid, sellersname, sellersage, sellersphone, sellerspwd;
            sellersid = sellerid.Text;
            sellersname = sellername.Text;
            sellersage = sellerage.Text;
            sellersphone = sellerphone.Text;
            sellerspwd = sellerpass.Text;

            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            string insertionseller = "insert into seller values(@sellerid, @sellername,@sellerage, @sellerphone, @sellerpass)";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            MySqlCommand insert = new MySqlCommand(insertionseller, connectdtb);
            insert.Parameters.AddWithValue("@sellerid", sellersid);
            insert.Parameters.AddWithValue("@sellername", sellersname);
            insert.Parameters.AddWithValue("@sellerage", sellersage);
            insert.Parameters.AddWithValue("@sellerphone", sellersphone);
            insert.Parameters.AddWithValue("@sellerpass", sellerspwd);
            try
            {
                connectdtb.Open();
                if (sellerid.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the Details");
                }
                else
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Cashier Added Succesfully");
                    sellerid.Clear(); sellername.Clear(); sellerage.Clear(); sellerphone.Clear(); sellerpass.Clear();
                    connectdtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An Error Occured..Details \n" + ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sellerDGV.SelectedRows.Count > 0)
            {
                sellerid.Text = sellerDGV.SelectedRows[0].Cells[0].Value?.ToString();
                sellername.Text = sellerDGV.SelectedRows[0].Cells[1].Value?.ToString();
                sellerage.Text = sellerDGV.SelectedRows[0].Cells[2].Value?.ToString();
                sellerphone.Text = sellerDGV.SelectedRows[0].Cells[3].Value?.ToString();
                sellerpass.Text = sellerDGV.SelectedRows[0].Cells[4].Value?.ToString();
            }
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            CategoryForm categoryfrm = new CategoryForm();
            categoryfrm.Show();
            this.Hide();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            ProductForm productfrm = new ProductForm();
            productfrm.Show();
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerid.Text == String.Empty || sellername.Text == String.Empty || sellerage.Text == String.Empty
                    || sellerphone.Text == String.Empty || sellerpass.Text == String.Empty)
                {
                    MessageBox.Show("Missing Information !!");
                }
                else
                {
                    string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
                    connectdtb.Open();
                    string updateseller = "update seller set sellername = '" + sellername.Text + "', sellerage = '" + sellerage.Text + "',  sellerphone = '" + sellerphone.Text + "',  sellerpass = '" + sellerpass.Text + "' where sellerid = '" + sellerid.Text + "'";
                    MySqlCommand update = new MySqlCommand(updateseller, connectdtb);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Cashier Info Succesfully Updated");
                    connectdtb.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerid.Text == String.Empty)
                {
                    MessageBox.Show("Select a Cashier to Delete");
                }
                else
                {
                    string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                    MySqlConnection connecttodtb = new MySqlConnection(connectiontodgmarket);
                    connecttodtb.Open();
                    string deletion = "delete from seller where sellerid = " + sellerid.Text + "";
                    MySqlCommand delete = new MySqlCommand(deletion, connecttodtb);
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Seller Info Deleted Succesfully");
                    sellerid.Clear(); sellername.Clear(); sellerage.Clear(); sellerphone.Clear(); sellerpass.Clear();
                    connecttodtb.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : \n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showdtbonpanel();
        }

        private void selling_Click(object sender, EventArgs e)
        {
            sellingForm sellingform = new sellingForm();
            this.Hide();
            sellingform.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            SignIN sign = new SignIN();
            sign.Show();
            this.Hide();

        }
    }
}
