namespace WindowsFormsApp1.Forms
{
    partial class ViewProductSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.Product_MotorcycleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_MotorcycleBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1137, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "My History";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1309, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Account Settings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(965, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cart Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(845, 95);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Multiline = true;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(643, 37);
            this.txtboxSearch.TabIndex = 12;
            // 
            // Product_MotorcycleModel
            // 
            this.Product_MotorcycleModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_MotorcycleModel.HeaderText = "Motorcycle Model/Type";
            this.Product_MotorcycleModel.MinimumWidth = 6;
            this.Product_MotorcycleModel.Name = "Product_MotorcycleModel";
            // 
            // Product_MotorcycleBrand
            // 
            this.Product_MotorcycleBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_MotorcycleBrand.HeaderText = "Motorcycle Brand";
            this.Product_MotorcycleBrand.MinimumWidth = 6;
            this.Product_MotorcycleBrand.Name = "Product_MotorcycleBrand";
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.MinimumWidth = 6;
            this.Product_Category.Name = "Product_Category";
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Quantity.HeaderText = "Quantity ";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            // 
            // Product_Price
            // 
            this.Product_Price.HeaderText = "Product Price";
            this.Product_Price.MinimumWidth = 6;
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Visible = false;
            this.Product_Price.Width = 125;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_ID
            // 
            this.Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_ID.HeaderText = "ProductID";
            this.Product_ID.MinimumWidth = 6;
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Visible = false;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProducts.ColumnHeadersHeight = 40;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Product_Price,
            this.Product_Quantity,
            this.Product_Category,
            this.Product_MotorcycleBrand,
            this.Product_MotorcycleModel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.dataGridProducts.Location = new System.Drawing.Point(12, 137);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 40;
            this.dataGridProducts.Size = new System.Drawing.Size(1537, 418);
            this.dataGridProducts.TabIndex = 10;
            this.dataGridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(415, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Products";
            // 
            // ViewProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Name = "ViewProductSupplier";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_MotorcycleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_MotorcycleBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        public System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Label label1;
    }
}