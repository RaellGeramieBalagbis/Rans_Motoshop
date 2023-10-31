namespace WindowsFormsApp1.Forms
{
    partial class supplierAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierAccount));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.AccountID,
            this.Supplier_Company,
            this.Supplier_FirstName,
            this.Supplier_LastName,
            this.Supplier_ContactNumber,
            this.Supplier_StreetName,
            this.Supplier_City,
            this.Supplier_EmailAddress,
            this.Supplier_UserName,
            this.Password_Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.dataGridProducts.Location = new System.Drawing.Point(12, 128);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 40;
            this.dataGridProducts.Size = new System.Drawing.Size(1475, 418);
            this.dataGridProducts.TabIndex = 10;
            this.dataGridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(400, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Supplier";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1184, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(723, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 69);
            this.label2.TabIndex = 15;
            this.label2.Text = "Supplier";
            // 
            // AccountID
            // 
            this.AccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountID.HeaderText = "Supplier ID";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.Visible = false;
            // 
            // Supplier_Company
            // 
            this.Supplier_Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_Company.HeaderText = "Company Name";
            this.Supplier_Company.MinimumWidth = 6;
            this.Supplier_Company.Name = "Supplier_Company";
            this.Supplier_Company.ReadOnly = true;
            // 
            // Supplier_FirstName
            // 
            this.Supplier_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_FirstName.HeaderText = "First Name";
            this.Supplier_FirstName.MinimumWidth = 6;
            this.Supplier_FirstName.Name = "Supplier_FirstName";
            this.Supplier_FirstName.Visible = false;
            // 
            // Supplier_LastName
            // 
            this.Supplier_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_LastName.HeaderText = "Last Name";
            this.Supplier_LastName.MinimumWidth = 6;
            this.Supplier_LastName.Name = "Supplier_LastName";
            this.Supplier_LastName.Visible = false;
            // 
            // Supplier_ContactNumber
            // 
            this.Supplier_ContactNumber.HeaderText = "Contact Number";
            this.Supplier_ContactNumber.MinimumWidth = 6;
            this.Supplier_ContactNumber.Name = "Supplier_ContactNumber";
            this.Supplier_ContactNumber.ReadOnly = true;
            this.Supplier_ContactNumber.Width = 125;
            // 
            // Supplier_StreetName
            // 
            this.Supplier_StreetName.HeaderText = "Steet Name";
            this.Supplier_StreetName.MinimumWidth = 6;
            this.Supplier_StreetName.Name = "Supplier_StreetName";
            this.Supplier_StreetName.ReadOnly = true;
            this.Supplier_StreetName.Width = 125;
            // 
            // Supplier_City
            // 
            this.Supplier_City.HeaderText = "City";
            this.Supplier_City.MinimumWidth = 6;
            this.Supplier_City.Name = "Supplier_City";
            this.Supplier_City.ReadOnly = true;
            this.Supplier_City.Width = 125;
            // 
            // Supplier_EmailAddress
            // 
            this.Supplier_EmailAddress.HeaderText = "Email Address";
            this.Supplier_EmailAddress.MinimumWidth = 6;
            this.Supplier_EmailAddress.Name = "Supplier_EmailAddress";
            this.Supplier_EmailAddress.ReadOnly = true;
            this.Supplier_EmailAddress.Width = 125;
            // 
            // Supplier_UserName
            // 
            this.Supplier_UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_UserName.HeaderText = "Username";
            this.Supplier_UserName.MinimumWidth = 6;
            this.Supplier_UserName.Name = "Supplier_UserName";
            // 
            // Password_Password
            // 
            this.Password_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password_Password.HeaderText = "Password";
            this.Password_Password.MinimumWidth = 6;
            this.Password_Password.Name = "Password_Password";
            this.Password_Password.Visible = false;
            // 
            // supplierAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.button1);
            this.Name = "supplierAccount";
            this.Text = "Manage Accounts";
            this.Load += new System.EventHandler(this.ManageAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_Password;
    }
}