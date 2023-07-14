using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DG_Sales_Management_System
{
    public partial class sellingForm : Form
    {
        public sellingForm()
        {
            InitializeComponent();
        }

        private void showbilltblonpanel()
        {
            string connecttodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connecttodgmarket);
            connectdtb.Open();
            string selectiondtb = "select billid,sellername,billdate,txtamount from billtbl";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectiondtb, connectdtb);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var billtable = new DataSet();
            adapter.Fill(billtable);
            billDGV.DataSource = billtable.Tables[0];
            billidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear();
            connectdtb.Close();
        }

        private void combinationbox()
        {
            string connectionstring = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            string query = "select catname from category";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable combo = new DataTable();
            combo.Columns.Add("catname", typeof(string));
            combo.Load(reader);
            categoryBox.ValueMember = "catname";
            categoryBox.DataSource = combo;
            conn.Close();
        }

        private void sellingForm_Load(object sender, EventArgs e)
        {
            showbilltblonpanel();
            showcategorytableonpanel();
            combinationbox();
            sellerlbl.Text = SignIN.sellername;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int flag = 0;


        private void prodDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (1 > 0)
            {
                pnametxt.Text = prodDGV1.SelectedRows[0].Cells[0].Value?.ToString();
                pricetxt.Text = prodDGV1.SelectedRows[0].Cells[1].Value?.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            datelbl.Text = DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString();
        }

        private int n = 0;
        private int gtotal = 0;

        private void addproduct_Click(object sender, EventArgs e)
        {
            if (pnametxt.Text == String.Empty || pricetxt.Text == String.Empty || quantitytxt.Text == String.Empty)
            {
                MessageBox.Show("Missing information !!");
            }
            else
            {
                int total = Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(quantitytxt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = pnametxt.Text;
                newRow.Cells[2].Value = pricetxt.Text;
                newRow.Cells[3].Value = quantitytxt.Text;
                newRow.Cells[4].Value = Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(quantitytxt.Text);
                orderDGV.Rows.Add(newRow);
                gtotal += total;
                n++;
                amountlbl.Text = "N " + gtotal.ToString();
            }
        }

        private void showcategorytableonpanel()
        {
            string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
            connectdtb.Open();
            string selectprod = "select prodname,prodqty from product";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectprod, connectdtb);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(dataadapter);
            var categorytable = new DataSet();
            dataadapter.Fill(categorytable);
            prodDGV1.DataSource = categorytable.Tables[0];
            billidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear(); pricetxt.Clear();
            connectdtb.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string dgmarketconnection = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(dgmarketconnection);
            if(billidtxt.Text == string.Empty)
            {
                MessageBox.Show("Missing BillId Number");
            }
            else
            {
                try
                {
                    connectdtb.Open();
                    string insertionbill = "insert into billtbl values(" + billidtxt.Text + " , '" + sellerlbl.Text + "', '" + datelbl.Text + "', '" + gtotal.ToString() + "')";
                    MySqlCommand insert = new MySqlCommand(insertionbill, connectdtb);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Succesfully");
                    connectdtb.Close();
                    showcategorytableonpanel();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error Details : \n" + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showcategorytableonpanel();
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dgmarketconnection = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
            MySqlConnection connectdtb = new MySqlConnection(dgmarketconnection);
            connectdtb.Open();
            string selectionquery = "select prodname,prodqty from product where prodcat ='" + categoryBox.SelectedValue.ToString() + "' ";
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectionquery, connectdtb);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(dataadapter);
            var categorytable = new DataSet();
            dataadapter.Fill(categorytable);
            prodDGV1.DataSource = categorytable.Tables[0];
            billidtxt.Clear(); pnametxt.Clear(); pricetxt.Clear(); quantitytxt.Clear();
            connectdtb.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignIN sign = new SignIN();
            sign.Show();
            this.Hide();
        }

        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
