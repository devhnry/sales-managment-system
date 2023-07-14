using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web;
using System.Windows.Forms;

namespace DG_Sales_Management_System
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }
        public static string sellername = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult exitthesystem;
            exitthesystem = MessageBox.Show("Do you wish to Quit", "Sign Up Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitthesystem == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text = String.Empty;
            passwordtxt.Text = String.Empty;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == String.Empty || passwordtxt.Text == String.Empty)
            {
                MessageBox.Show("Enter USERNAME & PASSWORD");
            }
            else
            {
                if (position.SelectedIndex > -1)
                {
                    if (position.SelectedItem.ToString() == "Admin")
                    {
                        if (usernametxt.Text == "Admin" && passwordtxt.Text == "Admin")
                        {
                            MessageBox.Show("Login SUCCESSFULL !");
                            ProductForm form = new ProductForm();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("As Admin, Enter the Correct USERNAME and PASSWORD");
                        }
                    }
                    else
                    {
                        string connectiontodgmarket = "datasource=localhost;port=3306;username=root;password=;database=dgmarket;";
                        MySqlConnection connectdtb = new MySqlConnection(connectiontodgmarket);
                        connectdtb.Open();
                        string selectsellers = "Select count(8) from seller where sellername = '" + usernametxt.Text + "' and sellerpass = '" + passwordtxt.Text + "'";
                        MySqlDataAdapter dataadapter = new MySqlDataAdapter(selectsellers, connectdtb);
                        DataTable sellertable = new DataTable();
                        dataadapter.Fill(sellertable);
                        if (sellertable.Rows[0][0].ToString() == "1")
                        {
                            sellername = usernametxt.Text;
                            sellingForm sellingForm = new sellingForm();
                            sellingForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                        connectdtb.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Select A ROLE [Admin OR Seller]");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
