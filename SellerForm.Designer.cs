namespace DG_Sales_Management_System
{
    partial class sellerForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sellerDGV = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.sellerpass = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.Label();
            this.sellerid = new System.Windows.Forms.TextBox();
            this.sellername = new System.Windows.Forms.TextBox();
            this.sellerage = new System.Windows.Forms.TextBox();
            this.sellerphone = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.categorybtn = new System.Windows.Forms.Label();
            this.productbtn = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sellerDGV);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.sellerpass);
            this.panel1.Controls.Add(this.pwd);
            this.panel1.Controls.Add(this.sellerid);
            this.panel1.Controls.Add(this.sellername);
            this.panel1.Controls.Add(this.sellerage);
            this.panel1.Controls.Add(this.sellerphone);
            this.panel1.Controls.Add(this.phoneno);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(226, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 913);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1333, 15);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 62);
            this.exitBtn.TabIndex = 31;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1056, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 30;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 55);
            this.label1.TabIndex = 29;
            this.label1.Text = "Manage Sellers";
            // 
            // sellerDGV
            // 
            this.sellerDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.sellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerDGV.Location = new System.Drawing.Point(482, 141);
            this.sellerDGV.Name = "sellerDGV";
            this.sellerDGV.RowHeadersWidth = 82;
            this.sellerDGV.RowTemplate.Height = 33;
            this.sellerDGV.Size = new System.Drawing.Size(926, 743);
            this.sellerDGV.TabIndex = 28;
            this.sellerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerDGV_CellClick);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(329, 577);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(115, 44);
            this.delBtn.TabIndex = 27;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(178, 577);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(125, 44);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 577);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 44);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // sellerpass
            // 
            this.sellerpass.Location = new System.Drawing.Point(203, 477);
            this.sellerpass.Name = "sellerpass";
            this.sellerpass.Size = new System.Drawing.Size(237, 31);
            this.sellerpass.TabIndex = 24;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(20, 477);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(180, 31);
            this.pwd.TabIndex = 23;
            this.pwd.Text = "PASSWORD";
            // 
            // sellerid
            // 
            this.sellerid.Location = new System.Drawing.Point(203, 228);
            this.sellerid.Name = "sellerid";
            this.sellerid.Size = new System.Drawing.Size(237, 31);
            this.sellerid.TabIndex = 22;
            // 
            // sellername
            // 
            this.sellername.Location = new System.Drawing.Point(203, 289);
            this.sellername.Name = "sellername";
            this.sellername.Size = new System.Drawing.Size(237, 31);
            this.sellername.TabIndex = 21;
            // 
            // sellerage
            // 
            this.sellerage.Location = new System.Drawing.Point(203, 349);
            this.sellerage.Name = "sellerage";
            this.sellerage.Size = new System.Drawing.Size(237, 31);
            this.sellerage.TabIndex = 20;
            // 
            // sellerphone
            // 
            this.sellerphone.Location = new System.Drawing.Point(203, 413);
            this.sellerphone.Name = "sellerphone";
            this.sellerphone.Size = new System.Drawing.Size(237, 31);
            this.sellerphone.TabIndex = 19;
            // 
            // phoneno
            // 
            this.phoneno.AutoSize = true;
            this.phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneno.Location = new System.Drawing.Point(20, 413);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(175, 31);
            this.phoneno.TabIndex = 18;
            this.phoneno.Text = "PHONE_NO";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(20, 349);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(74, 31);
            this.age.TabIndex = 17;
            this.age.Text = "AGE";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(20, 289);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 31);
            this.name.TabIndex = 16;
            this.name.Text = "NAME";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(20, 225);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(44, 31);
            this.id.TabIndex = 15;
            this.id.Text = "ID";
            // 
            // categorybtn
            // 
            this.categorybtn.AutoSize = true;
            this.categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.Location = new System.Drawing.Point(23, 270);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(181, 37);
            this.categorybtn.TabIndex = 6;
            this.categorybtn.Text = "Categories";
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.AutoSize = true;
            this.productbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.Location = new System.Drawing.Point(23, 219);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(152, 37);
            this.productbtn.TabIndex = 4;
            this.productbtn.Text = "Products";
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(23, 844);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 37);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // sellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 909);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.categorybtn);
            this.Controls.Add(this.productbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categorybtn;
        private System.Windows.Forms.Label productbtn;
        private System.Windows.Forms.TextBox sellerid;
        private System.Windows.Forms.TextBox sellername;
        private System.Windows.Forms.TextBox sellerage;
        private System.Windows.Forms.TextBox sellerphone;
        private System.Windows.Forms.Label phoneno;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox sellerpass;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView sellerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label logout;
    }
}