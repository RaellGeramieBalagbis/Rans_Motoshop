namespace WindowsFormsApp1.Forms
{
    partial class addAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listRoleAdmin = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminLastName = new System.Windows.Forms.TextBox();
            this.adminFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.adminPass2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adminPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adminUser = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listRoleAdmin);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.adminLastName);
            this.panel2.Controls.Add(this.adminFirstName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.adminPass2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adminPass);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.adminUser);
            this.panel2.Location = new System.Drawing.Point(24, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 598);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(575, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Role";
            // 
            // listRoleAdmin
            // 
            this.listRoleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoleAdmin.FormattingEnabled = true;
            this.listRoleAdmin.ItemHeight = 25;
            this.listRoleAdmin.Items.AddRange(new object[] {
            "Manager",
            "Mechanic",
            "Programmer",
            "Personnel"});
            this.listRoleAdmin.Location = new System.Drawing.Point(579, 211);
            this.listRoleAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.listRoleAdmin.Name = "listRoleAdmin";
            this.listRoleAdmin.Size = new System.Drawing.Size(397, 129);
            this.listRoleAdmin.TabIndex = 38;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(610, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(526, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Last Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminLastName
            // 
            this.adminLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.adminLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLastName.Location = new System.Drawing.Point(526, 422);
            this.adminLastName.Margin = new System.Windows.Forms.Padding(4);
            this.adminLastName.Multiline = true;
            this.adminLastName.Name = "adminLastName";
            this.adminLastName.Size = new System.Drawing.Size(479, 49);
            this.adminLastName.TabIndex = 8;
            // 
            // adminFirstName
            // 
            this.adminFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.adminFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminFirstName.Location = new System.Drawing.Point(39, 422);
            this.adminFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.adminFirstName.Multiline = true;
            this.adminFirstName.Name = "adminFirstName";
            this.adminFirstName.Size = new System.Drawing.Size(479, 49);
            this.adminFirstName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(39, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(39, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(257, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 69);
            this.label3.TabIndex = 25;
            this.label3.Text = "Add Admin";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(418, 517);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 52);
            this.button3.TabIndex = 13;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(39, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirm Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminPass2
            // 
            this.adminPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.adminPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPass2.Location = new System.Drawing.Point(43, 292);
            this.adminPass2.Margin = new System.Windows.Forms.Padding(4);
            this.adminPass2.Multiline = true;
            this.adminPass2.Name = "adminPass2";
            this.adminPass2.PasswordChar = '*';
            this.adminPass2.Size = new System.Drawing.Size(479, 49);
            this.adminPass2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(39, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // adminPass
            // 
            this.adminPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.adminPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPass.Location = new System.Drawing.Point(43, 211);
            this.adminPass.Margin = new System.Windows.Forms.Padding(4);
            this.adminPass.Multiline = true;
            this.adminPass.Name = "adminPass";
            this.adminPass.PasswordChar = '*';
            this.adminPass.Size = new System.Drawing.Size(479, 49);
            this.adminPass.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(39, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Username";
            // 
            // adminUser
            // 
            this.adminUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.adminUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUser.Location = new System.Drawing.Point(43, 130);
            this.adminUser.Margin = new System.Windows.Forms.Padding(4);
            this.adminUser.Multiline = true;
            this.adminUser.Name = "adminUser";
            this.adminUser.Size = new System.Drawing.Size(479, 49);
            this.adminUser.TabIndex = 2;
            // 
            // addAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 609);
            this.Controls.Add(this.panel2);
            this.Name = "addAdmin";
            this.Text = "add Admin Account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminPass2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.TextBox adminUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminLastName;
        private System.Windows.Forms.TextBox adminFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listRoleAdmin;
        private System.Windows.Forms.Label label1;
    }
}