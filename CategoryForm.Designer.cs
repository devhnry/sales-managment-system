namespace DG_Sales_Management_System
{
    partial class CategoryForm
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
            this.catDGV = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.catid = new System.Windows.Forms.TextBox();
            this.catname = new System.Windows.Forms.TextBox();
            this.catdesc = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.sellersbtn = new System.Windows.Forms.Label();
            this.productbtn = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.catDGV);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.catid);
            this.panel1.Controls.Add(this.catname);
            this.panel1.Controls.Add(this.catdesc);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(230, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 913);
            this.panel1.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1224, 15);
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
            this.label1.Size = new System.Drawing.Size(462, 55);
            this.label1.TabIndex = 29;
            this.label1.Text = "Manage Categories";
            // 
            // catDGV
            // 
            this.catDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDGV.Location = new System.Drawing.Point(498, 140);
            this.catDGV.Name = "catDGV";
            this.catDGV.RowHeadersWidth = 82;
            this.catDGV.RowTemplate.Height = 33;
            this.catDGV.Size = new System.Drawing.Size(817, 743);
            this.catDGV.TabIndex = 28;
            this.catDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellClick);
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
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
            // catid
            // 
            this.catid.Location = new System.Drawing.Point(203, 228);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(237, 31);
            this.catid.TabIndex = 22;
            // 
            // catname
            // 
            this.catname.Location = new System.Drawing.Point(203, 289);
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(237, 31);
            this.catname.TabIndex = 21;
            // 
            // catdesc
            // 
            this.catdesc.Location = new System.Drawing.Point(203, 349);
            this.catdesc.Name = "catdesc";
            this.catdesc.Size = new System.Drawing.Size(237, 31);
            this.catdesc.TabIndex = 20;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(20, 349);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(162, 31);
            this.description.TabIndex = 17;
            this.description.Text = "Description";
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
            // sellersbtn
            // 
            this.sellersbtn.AutoSize = true;
            this.sellersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellersbtn.Location = new System.Drawing.Point(12, 285);
            this.sellersbtn.Name = "sellersbtn";
            this.sellersbtn.Size = new System.Drawing.Size(151, 37);
            this.sellersbtn.TabIndex = 9;
            this.sellersbtn.Text = "Casheirs";
            this.sellersbtn.Click += new System.EventHandler(this.sellersbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.AutoSize = true;
            this.productbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.Location = new System.Drawing.Point(12, 230);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(152, 37);
            this.productbtn.TabIndex = 7;
            this.productbtn.Text = "Products";
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(12, 839);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 37);
            this.logout.TabIndex = 10;
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 897);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.sellersbtn);
            this.Controls.Add(this.productbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categories";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView catDGV;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox catid;
        private System.Windows.Forms.TextBox catname;
        private System.Windows.Forms.TextBox catdesc;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label sellersbtn;
        private System.Windows.Forms.Label productbtn;
        private System.Windows.Forms.Label logout;
    }
}