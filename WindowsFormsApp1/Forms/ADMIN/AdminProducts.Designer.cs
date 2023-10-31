namespace WindowsFormsApp1.Forms
{
    partial class AdminProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProducts));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodmodel = new System.Windows.Forms.TextBox();
            this.prodbrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prodqual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.prodcat = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(550, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Products";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(851, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(736, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Motorcycle Model";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodmodel
            // 
            this.prodmodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.prodmodel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodmodel.Location = new System.Drawing.Point(904, 358);
            this.prodmodel.Margin = new System.Windows.Forms.Padding(4);
            this.prodmodel.Multiline = true;
            this.prodmodel.Name = "prodmodel";
            this.prodmodel.Size = new System.Drawing.Size(572, 49);
            this.prodmodel.TabIndex = 6;
            // 
            // prodbrand
            // 
            this.prodbrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.prodbrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodbrand.Location = new System.Drawing.Point(178, 358);
            this.prodbrand.Margin = new System.Windows.Forms.Padding(4);
            this.prodbrand.Multiline = true;
            this.prodbrand.Name = "prodbrand";
            this.prodbrand.Size = new System.Drawing.Size(536, 49);
            this.prodbrand.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(13, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Motorcycle Brand";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(804, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Product Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(417, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Product Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodqual
            // 
            this.prodqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.prodqual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodqual.Location = new System.Drawing.Point(600, 277);
            this.prodqual.Margin = new System.Windows.Forms.Padding(4);
            this.prodqual.Multiline = true;
            this.prodqual.Name = "prodqual";
            this.prodqual.Size = new System.Drawing.Size(206, 49);
            this.prodqual.TabIndex = 3;
            this.prodqual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prodqual_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(23, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Product Price";
            // 
            // prodprice
            // 
            this.prodprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.prodprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodprice.Location = new System.Drawing.Point(162, 277);
            this.prodprice.Margin = new System.Windows.Forms.Padding(4);
            this.prodprice.Multiline = true;
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(221, 49);
            this.prodprice.TabIndex = 2;
            this.prodprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prodprice_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(23, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Product Name";
            // 
            // prodname
            // 
            this.prodname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.prodname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(162, 192);
            this.prodname.Margin = new System.Windows.Forms.Padding(4);
            this.prodname.Multiline = true;
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(617, 49);
            this.prodname.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(767, 464);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // prodcat
            // 
            this.prodcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcat.FormattingEnabled = true;
            this.prodcat.ItemHeight = 25;
            this.prodcat.Items.AddRange(new object[] {
            "Accessories",
            "Oils",
            "Spare Parts",
            "Tires"});
            this.prodcat.Location = new System.Drawing.Point(967, 205);
            this.prodcat.Margin = new System.Windows.Forms.Padding(4);
            this.prodcat.Name = "prodcat";
            this.prodcat.Size = new System.Drawing.Size(397, 129);
            this.prodcat.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(471, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // AdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prodcat);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prodmodel);
            this.Controls.Add(this.prodbrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prodqual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AdminProducts";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodmodel;
        private System.Windows.Forms.TextBox prodbrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prodqual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prodprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox prodcat;
        private System.Windows.Forms.Button button2;
    }
}