namespace WindowsFormsApp1.Forms
{
    partial class createnewaccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.streetName = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.motorcycleBrand = new System.Windows.Forms.TextBox();
            this.motorcycleModel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "ACCOUNT INFORMATION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userName
            // 
            this.userName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.userName.Location = new System.Drawing.Point(188, 36);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(252, 22);
            this.userName.TabIndex = 4;
            this.userName.Text = "Enter User Name";
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.password.Location = new System.Drawing.Point(188, 64);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(252, 22);
            this.password.TabIndex = 5;
            this.password.Text = "Enter Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // confirmPass
            // 
            this.confirmPass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.confirmPass.Location = new System.Drawing.Point(188, 92);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(252, 22);
            this.confirmPass.TabIndex = 6;
            this.confirmPass.Text = "Confirm Password";
            this.confirmPass.Enter += new System.EventHandler(this.confirmPass_Enter);
            this.confirmPass.Leave += new System.EventHandler(this.confirmPass_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "CUSTOMER INFORMATION";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Contact Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Street Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "City:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 22);
            this.label12.TabIndex = 14;
            this.label12.Text = "MOTORCYCLE INFORMATION";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Motorcycle Brand:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Motorcycle Model:";
            // 
            // firstName
            // 
            this.firstName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.firstName.Location = new System.Drawing.Point(188, 180);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(252, 22);
            this.firstName.TabIndex = 17;
            this.firstName.Text = "Enter First Name";
            this.firstName.Enter += new System.EventHandler(this.firstName_Enter);
            this.firstName.Leave += new System.EventHandler(this.firstName_Leave);
            // 
            // lastName
            // 
            this.lastName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lastName.Location = new System.Drawing.Point(188, 209);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(252, 22);
            this.lastName.TabIndex = 18;
            this.lastName.Text = "Enter Last Name";
            this.lastName.Enter += new System.EventHandler(this.lastName_Enter);
            this.lastName.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // contactNumber
            // 
            this.contactNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.contactNumber.Location = new System.Drawing.Point(188, 238);
            this.contactNumber.MaxLength = 11;
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(252, 22);
            this.contactNumber.TabIndex = 19;
            this.contactNumber.Text = "Enter Contact Number";
            this.contactNumber.Enter += new System.EventHandler(this.contactNumber_Enter);
            this.contactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNumber_KeyPress);
            this.contactNumber.Leave += new System.EventHandler(this.contactNumber_Leave);
            // 
            // streetName
            // 
            this.streetName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.streetName.Location = new System.Drawing.Point(188, 266);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(394, 22);
            this.streetName.TabIndex = 20;
            this.streetName.Text = "Enter Street Name";
            this.streetName.Enter += new System.EventHandler(this.streetName_Enter);
            this.streetName.Leave += new System.EventHandler(this.streetName_Leave);
            // 
            // cityName
            // 
            this.cityName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityName.Location = new System.Drawing.Point(188, 295);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(252, 22);
            this.cityName.TabIndex = 21;
            this.cityName.Text = "Enter City";
            this.cityName.Enter += new System.EventHandler(this.cityName_Enter);
            this.cityName.Leave += new System.EventHandler(this.cityName_Leave);
            // 
            // emailAddress
            // 
            this.emailAddress.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailAddress.Location = new System.Drawing.Point(188, 323);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(394, 22);
            this.emailAddress.TabIndex = 22;
            this.emailAddress.Text = "Enter Email Address";
            this.emailAddress.Enter += new System.EventHandler(this.emailAddress_Enter);
            this.emailAddress.Leave += new System.EventHandler(this.emailAddress_Leave);
            // 
            // motorcycleBrand
            // 
            this.motorcycleBrand.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.motorcycleBrand.Location = new System.Drawing.Point(188, 387);
            this.motorcycleBrand.Name = "motorcycleBrand";
            this.motorcycleBrand.Size = new System.Drawing.Size(252, 22);
            this.motorcycleBrand.TabIndex = 23;
            this.motorcycleBrand.Text = "Enter Motorcycle Brand";
            this.motorcycleBrand.Enter += new System.EventHandler(this.motorcycleBrand_Enter);
            this.motorcycleBrand.Leave += new System.EventHandler(this.motorcycleBrand_Leave);
            // 
            // motorcycleModel
            // 
            this.motorcycleModel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.motorcycleModel.Location = new System.Drawing.Point(188, 422);
            this.motorcycleModel.Name = "motorcycleModel";
            this.motorcycleModel.Size = new System.Drawing.Size(252, 22);
            this.motorcycleModel.TabIndex = 24;
            this.motorcycleModel.Text = "Enter Motorcycle Model";
            this.motorcycleModel.Enter += new System.EventHandler(this.motorcycleModel_Enter);
            this.motorcycleModel.Leave += new System.EventHandler(this.motorcycleModel_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(298, 562);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "-Already Have an Account?-";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // createnewaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 617);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motorcycleModel);
            this.Controls.Add(this.motorcycleBrand);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.streetName);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createnewaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Account";
            this.Load += new System.EventHandler(this.createnewaccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox contactNumber;
        private System.Windows.Forms.TextBox streetName;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox motorcycleBrand;
        private System.Windows.Forms.TextBox motorcycleModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}