namespace DG_Sales_Management_System
{
    partial class sellingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.datelbl = new System.Windows.Forms.Label();
            this.sellerlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodDGV1 = new System.Windows.Forms.DataGridView();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.billidtxt = new System.Windows.Forms.TextBox();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.amountlbl);
            this.panel1.Controls.Add(this.addproduct);
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.sellerlbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodDGV1);
            this.panel1.Controls.Add(this.orderDGV);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.billidtxt);
            this.panel1.Controls.Add(this.pnametxt);
            this.panel1.Controls.Add(this.quantitytxt);
            this.panel1.Controls.Add(this.pricetxt);
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.billDGV);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1743, 1023);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "LogOut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(1056, 515);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(35, 31);
            this.amountlbl.TabIndex = 24;
            this.amountlbl.Text = "N";
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(139, 511);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(304, 44);
            this.addproduct.TabIndex = 23;
            this.addproduct.Text = "ADD PRODUCT";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(1368, 60);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(91, 31);
            this.datelbl.TabIndex = 22;
            this.datelbl.Text = "DATE";
            this.datelbl.Click += new System.EventHandler(this.datelbl_Click);
            // 
            // sellerlbl
            // 
            this.sellerlbl.AutoSize = true;
            this.sellerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerlbl.Location = new System.Drawing.Point(79, 91);
            this.sellerlbl.Name = "sellerlbl";
            this.sellerlbl.Size = new System.Drawing.Size(124, 31);
            this.sellerlbl.TabIndex = 21;
            this.sellerlbl.Text = "SELLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "AMOUNT :";
            // 
            // prodDGV1
            // 
            this.prodDGV1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.prodDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prodDGV1.Location = new System.Drawing.Point(29, 568);
            this.prodDGV1.Name = "prodDGV1";
            this.prodDGV1.RowHeadersWidth = 82;
            this.prodDGV1.RowTemplate.Height = 33;
            this.prodDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDGV1.Size = new System.Drawing.Size(514, 426);
            this.prodDGV1.TabIndex = 18;
            this.prodDGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV1_CellContentClick);
            // 
            // orderDGV
            // 
            this.orderDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pid,
            this.prodName,
            this.price1,
            this.quantity1,
            this.Total});
            this.orderDGV.Location = new System.Drawing.Point(681, 118);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersWidth = 82;
            this.orderDGV.RowTemplate.Height = 33;
            this.orderDGV.Size = new System.Drawing.Size(1046, 381);
            this.orderDGV.TabIndex = 17;
            // 
            // Pid
            // 
            this.Pid.FillWeight = 320.5128F;
            this.Pid.HeaderText = "ProdID";
            this.Pid.MinimumWidth = 10;
            this.Pid.Name = "Pid";
            this.Pid.Width = 50;
            // 
            // prodName
            // 
            this.prodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prodName.FillWeight = 133.6226F;
            this.prodName.HeaderText = "PName";
            this.prodName.MinimumWidth = 10;
            this.prodName.Name = "prodName";
            this.prodName.Width = 120;
            // 
            // price1
            // 
            this.price1.FillWeight = 34.41998F;
            this.price1.HeaderText = "Price";
            this.price1.MinimumWidth = 10;
            this.price1.Name = "price1";
            this.price1.Width = 120;
            // 
            // quantity1
            // 
            this.quantity1.FillWeight = 8.983406F;
            this.quantity1.HeaderText = "Quantity";
            this.quantity1.MinimumWidth = 10;
            this.quantity1.Name = "quantity1";
            this.quantity1.Width = 50;
            // 
            // Total
            // 
            this.Total.FillWeight = 2.461207F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 10;
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1651, 41);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 62);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // billidtxt
            // 
            this.billidtxt.Location = new System.Drawing.Point(206, 230);
            this.billidtxt.Name = "billidtxt";
            this.billidtxt.Size = new System.Drawing.Size(237, 31);
            this.billidtxt.TabIndex = 14;
            // 
            // pnametxt
            // 
            this.pnametxt.Enabled = false;
            this.pnametxt.Location = new System.Drawing.Point(206, 291);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(237, 31);
            this.pnametxt.TabIndex = 13;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(206, 398);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(237, 31);
            this.quantitytxt.TabIndex = 12;
            // 
            // pricetxt
            // 
            this.pricetxt.Enabled = false;
            this.pricetxt.Location = new System.Drawing.Point(206, 343);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(237, 31);
            this.pricetxt.TabIndex = 11;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 25;
            this.categoryBox.Location = new System.Drawing.Point(29, 454);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(239, 33);
            this.categoryBox.TabIndex = 10;
            this.categoryBox.Text = "Category";
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // billDGV
            // 
            this.billDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Location = new System.Drawing.Point(681, 630);
            this.billDGV.Name = "billDGV";
            this.billDGV.RowHeadersWidth = 82;
            this.billDGV.RowTemplate.Height = 33;
            this.billDGV.Size = new System.Drawing.Size(1046, 314);
            this.billDGV.TabIndex = 9;
            this.billDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDGV_CellContentClick);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(1447, 950);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(115, 44);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(813, 950);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 44);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(23, 395);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(161, 31);
            this.price.TabIndex = 4;
            this.price.Text = "QUANTITY";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(23, 340);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(103, 31);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "PRICE";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(23, 291);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 31);
            this.name.TabIndex = 2;
            this.name.Text = "P NAME";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(23, 227);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(112, 31);
            this.id.TabIndex = 1;
            this.id.Text = "BILL ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLERS\r\n";
            // 
            // sellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 1047);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sellingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.sellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox billidtxt;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView prodDGV1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label sellerlbl;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
    }
}