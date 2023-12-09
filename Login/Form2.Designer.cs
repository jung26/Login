namespace Login
{
    partial class Form2
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
            System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Passwordcb = new System.Windows.Forms.CheckBox();
            this.confirnpassword_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthday_dateTimePicker
            // 
            birthday_dateTimePicker.CustomFormat = "MM-dd-yyyy";
            birthday_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthday_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            birthday_dateTimePicker.Location = new System.Drawing.Point(170, 251);
            birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            birthday_dateTimePicker.Size = new System.Drawing.Size(271, 30);
            birthday_dateTimePicker.TabIndex = 17;
            birthday_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gender_cb);
            this.panel1.Controls.Add(birthday_dateTimePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Email_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Passwordcb);
            this.panel1.Controls.Add(this.confirnpassword_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Password_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(160, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 540);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(166, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Go Back to Login";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // gender_cb
            // 
            this.gender_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Location = new System.Drawing.Point(170, 196);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(121, 33);
            this.gender_cb.TabIndex = 2;
            this.gender_cb.SelectedIndexChanged += new System.EventHandler(this.gender_cb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(63, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Birthday";
            // 
            // Email_tb
            // 
            this.Email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_tb.Location = new System.Drawing.Point(170, 144);
            this.Email_tb.Multiline = true;
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(271, 36);
            this.Email_tb.TabIndex = 15;
            this.Email_tb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(69, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(63, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Passwordcb
            // 
            this.Passwordcb.AutoSize = true;
            this.Passwordcb.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordcb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Passwordcb.Location = new System.Drawing.Point(315, 417);
            this.Passwordcb.Name = "Passwordcb";
            this.Passwordcb.Size = new System.Drawing.Size(126, 20);
            this.Passwordcb.TabIndex = 11;
            this.Passwordcb.Text = "Show Password";
            this.Passwordcb.UseVisualStyleBackColor = true;
            this.Passwordcb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // confirnpassword_tb
            // 
            this.confirnpassword_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirnpassword_tb.Location = new System.Drawing.Point(170, 375);
            this.confirnpassword_tb.Multiline = true;
            this.confirnpassword_tb.Name = "confirnpassword_tb";
            this.confirnpassword_tb.PasswordChar = '*';
            this.confirnpassword_tb.Size = new System.Drawing.Size(271, 36);
            this.confirnpassword_tb.TabIndex = 10;
            this.confirnpassword_tb.TextChanged += new System.EventHandler(this.confirnpassword_tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm a passwowrd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_tb
            // 
            this.Password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tb.Location = new System.Drawing.Point(170, 311);
            this.Password_tb.Multiline = true;
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(271, 36);
            this.Password_tb.TabIndex = 4;
            this.Password_tb.TextChanged += new System.EventHandler(this.Password_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(52, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // user_tb
            // 
            this.user_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tb.Location = new System.Drawing.Point(170, 92);
            this.user_tb.Multiline = true;
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(271, 36);
            this.user_tb.TabIndex = 1;
            this.user_tb.TextChanged += new System.EventHandler(this.user_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 564);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Passwordcb;
        private System.Windows.Forms.TextBox confirnpassword_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}