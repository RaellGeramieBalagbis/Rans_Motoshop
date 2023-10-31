namespace WindowsFormsApp1.Forms
{
    partial class customerAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerAccount));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_MotorcycleBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_MotorcycleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridProducts.ColumnHeadersHeight = 40;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.Customer_UserName,
            this.Customer_Password,
            this.Customer_FirstName,
            this.Customer_LastName,
            this.Customer_ContactNumber,
            this.Customer_StreetName,
            this.Customer_City,
            this.Customer_EmailAddress,
            this.Customer_MotorcycleBrand,
            this.Customer_MotorcycleModel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProducts.DefaultCellStyle = dataGridViewCellStyle6;
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
            // AccountID
            // 
            this.AccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountID.HeaderText = "Account ID";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.Visible = false;
            // 
            // Customer_UserName
            // 
            this.Customer_UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_UserName.HeaderText = "Username";
            this.Customer_UserName.MinimumWidth = 6;
            this.Customer_UserName.Name = "Customer_UserName";
            // 
            // Customer_Password
            // 
            this.Customer_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Password.HeaderText = "Password";
            this.Customer_Password.MinimumWidth = 6;
            this.Customer_Password.Name = "Customer_Password";
            this.Customer_Password.Visible = false;
            // 
            // Customer_FirstName
            // 
            this.Customer_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_FirstName.HeaderText = "First Name";
            this.Customer_FirstName.MinimumWidth = 6;
            this.Customer_FirstName.Name = "Customer_FirstName";
            this.Customer_FirstName.Visible = false;
            // 
            // Customer_LastName
            // 
            this.Customer_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_LastName.HeaderText = "Last Name";
            this.Customer_LastName.MinimumWidth = 6;
            this.Customer_LastName.Name = "Customer_LastName";
            this.Customer_LastName.Visible = false;
            // 
            // Customer_ContactNumber
            // 
            this.Customer_ContactNumber.HeaderText = "Contact Number";
            this.Customer_ContactNumber.MinimumWidth = 6;
            this.Customer_ContactNumber.Name = "Customer_ContactNumber";
            this.Customer_ContactNumber.ReadOnly = true;
            this.Customer_ContactNumber.Width = 125;
            // 
            // Customer_StreetName
            // 
            this.Customer_StreetName.HeaderText = "Steet Name";
            this.Customer_StreetName.MinimumWidth = 6;
            this.Customer_StreetName.Name = "Customer_StreetName";
            this.Customer_StreetName.ReadOnly = true;
            this.Customer_StreetName.Width = 125;
            // 
            // Customer_City
            // 
            this.Customer_City.HeaderText = "City";
            this.Customer_City.MinimumWidth = 6;
            this.Customer_City.Name = "Customer_City";
            this.Customer_City.ReadOnly = true;
            this.Customer_City.Width = 125;
            // 
            // Customer_EmailAddress
            // 
            this.Customer_EmailAddress.HeaderText = "Email Address";
            this.Customer_EmailAddress.MinimumWidth = 6;
            this.Customer_EmailAddress.Name = "Customer_EmailAddress";
            this.Customer_EmailAddress.ReadOnly = true;
            this.Customer_EmailAddress.Width = 125;
            // 
            // Customer_MotorcycleBrand
            // 
            this.Customer_MotorcycleBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_MotorcycleBrand.HeaderText = "Motorycle Brand";
            this.Customer_MotorcycleBrand.MinimumWidth = 6;
            this.Customer_MotorcycleBrand.Name = "Customer_MotorcycleBrand";
            this.Customer_MotorcycleBrand.ReadOnly = true;
            // 
            // Customer_MotorcycleModel
            // 
            this.Customer_MotorcycleModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_MotorcycleModel.HeaderText = "Motorcycle Model";
            this.Customer_MotorcycleModel.MinimumWidth = 6;
            this.Customer_MotorcycleModel.Name = "Customer_MotorcycleModel";
            this.Customer_MotorcycleModel.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(400, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customers";
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
            this.label2.Size = new System.Drawing.Size(328, 69);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customers";
            // 
            // customerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.button1);
            this.Name = "customerAccount";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_MotorcycleBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_MotorcycleModel;
    }
}