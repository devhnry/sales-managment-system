namespace DG_Sales_Management_System
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.prodDGV = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cashier = new System.Windows.Forms.Label();
            this.categorybtn = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pidtxt);
            this.panel1.Controls.Add(this.pnametxt);
            this.panel1.Controls.Add(this.quantitytxt);
            this.panel1.Controls.Add(this.pricetxt);
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.prodDGV);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(226, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 913);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1208, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 33);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1562, 15);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 62);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1036, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pidtxt
            // 
            this.pidtxt.Location = new System.Drawing.Point(206, 230);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(237, 31);
            this.pidtxt.TabIndex = 14;
            // 
            // pnametxt
            // 
            this.pnametxt.Location = new System.Drawing.Point(206, 291);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(237, 31);
            this.pnametxt.TabIndex = 13;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(206, 340);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(237, 31);
            this.quantitytxt.TabIndex = 12;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(206, 395);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(237, 31);
            this.pricetxt.TabIndex = 11;
            this.pricetxt.TextChanged += new System.EventHandler(this.pricetxt_TextChanged);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(204, 448);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(239, 33);
            this.categoryBox.TabIndex = 10;
            this.categoryBox.Text = "Select Category";
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // prodDGV
            // 
            this.prodDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.prodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDGV.Location = new System.Drawing.Point(482, 143);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.RowHeadersWidth = 82;
            this.prodDGV.RowTemplate.Height = 33;
            this.prodDGV.Size = new System.Drawing.Size(1170, 743);
            this.prodDGV.TabIndex = 9;
            this.prodDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV_CellClick);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(332, 574);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(115, 44);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(181, 574);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(125, 44);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(33, 574);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 44);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(23, 450);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(175, 31);
            this.category.TabIndex = 5;
            this.category.Text = "CATEGORY";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(23, 395);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(103, 31);
            this.price.TabIndex = 4;
            this.price.Text = "PRICE";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(23, 340);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(161, 31);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "QUANTITY";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(23, 291);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 31);
            this.name.TabIndex = 2;
            this.name.Text = "NAME";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(23, 227);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(44, 31);
            this.id.TabIndex = 1;
            this.id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.Location = new System.Drawing.Point(30, 227);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(151, 37);
            this.cashier.TabIndex = 1;
            this.cashier.Text = "Cashiers";
            this.cashier.Click += new System.EventHandler(this.cashier_Click);
            // 
            // categorybtn
            // 
            this.categorybtn.AutoSize = true;
            this.categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.Location = new System.Drawing.Point(30, 282);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(181, 37);
            this.categorybtn.TabIndex = 3;
            this.categorybtn.Text = "Categories";
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(30, 847);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 37);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 909);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.categorybtn);
            this.Controls.Add(this.cashier);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashier;
        private System.Windows.Forms.Label categorybtn;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView prodDGV;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}