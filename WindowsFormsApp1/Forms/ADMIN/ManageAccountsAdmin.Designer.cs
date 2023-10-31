namespace WindowsFormsApp1.Forms
{
    partial class ManageAccountsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccountsAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(964, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Supplier(s)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1137, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Manage Products";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1309, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Generate Reports";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(792, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Customer(s)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.adminID,
            this.admin_Role,
            this.admin_FirstName,
            this.Admin_LastName,
            this.admin_user,
            this.admin_Password});
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
            this.dataGridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducts_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 82);
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
            this.txtboxSearch.Location = new System.Drawing.Point(845, 82);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Multiline = true;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(626, 38);
            this.txtboxSearch.TabIndex = 12;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(302, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admins";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(598, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(144, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Edit Admin";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // adminID
            // 
            this.adminID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adminID.HeaderText = "Account ID";
            this.adminID.MinimumWidth = 6;
            this.adminID.Name = "adminID";
            // 
            // admin_Role
            // 
            this.admin_Role.HeaderText = "Role";
            this.admin_Role.MinimumWidth = 6;
            this.admin_Role.Name = "admin_Role";
            this.admin_Role.Width = 125;
            // 
            // admin_FirstName
            // 
            this.admin_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admin_FirstName.HeaderText = "First Name";
            this.admin_FirstName.MinimumWidth = 6;
            this.admin_FirstName.Name = "admin_FirstName";
            // 
            // Admin_LastName
            // 
            this.Admin_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Admin_LastName.HeaderText = "Last Name";
            this.Admin_LastName.MinimumWidth = 6;
            this.Admin_LastName.Name = "Admin_LastName";
            // 
            // admin_user
            // 
            this.admin_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admin_user.HeaderText = "Username";
            this.admin_user.MinimumWidth = 6;
            this.admin_user.Name = "admin_user";
            // 
            // admin_Password
            // 
            this.admin_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admin_Password.HeaderText = "Password";
            this.admin_Password.MinimumWidth = 6;
            this.admin_Password.Name = "admin_Password";
            // 
            // ManageAccountsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 559);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "ManageAccountsAdmin";
            this.Text = "Manage Accounts (Admin)";
            this.Load += new System.EventHandler(this.ManageAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_Password;
    }
}