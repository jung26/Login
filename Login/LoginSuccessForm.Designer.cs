namespace Login
{
    partial class LoginSuccessForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.account_dtv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.user_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_cb = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_dtv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.Controls.Add(this.account_dtv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // account_dtv
            // 
            this.account_dtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.account_dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.account_dtv.Location = new System.Drawing.Point(8, 6);
            this.account_dtv.Name = "account_dtv";
            this.account_dtv.RowHeadersWidth = 51;
            this.account_dtv.RowTemplate.Height = 24;
            this.account_dtv.Size = new System.Drawing.Size(776, 407);
            this.account_dtv.TabIndex = 2;
            this.account_dtv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.password_tb);
            this.tabPage2.Controls.Add(this.password_lb);
            this.tabPage2.Controls.Add(this.user_tb);
            this.tabPage2.Controls.Add(this.user_lb);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.name_cb);
            this.tabPage2.Controls.Add(this.delete_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(272, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 24;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(353, 313);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(156, 30);
            this.password_tb.TabIndex = 23;
            this.password_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.Location = new System.Drawing.Point(215, 313);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(106, 25);
            this.password_lb.TabIndex = 22;
            this.password_lb.Text = "Password";
            // 
            // user_tb
            // 
            this.user_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tb.Location = new System.Drawing.Point(353, 224);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(156, 30);
            this.user_tb.TabIndex = 21;
            this.user_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user_lb
            // 
            this.user_lb.AutoSize = true;
            this.user_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lb.Location = new System.Drawing.Point(242, 229);
            this.user_lb.Name = "user_lb";
            this.user_lb.Size = new System.Drawing.Size(57, 25);
            this.user_lb.TabIndex = 20;
            this.user_lb.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // name_cb
            // 
            this.name_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cb.FormattingEnabled = true;
            this.name_cb.Location = new System.Drawing.Point(353, 134);
            this.name_cb.Name = "name_cb";
            this.name_cb.Size = new System.Drawing.Size(156, 33);
            this.name_cb.TabIndex = 17;
            this.name_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_btn.Location = new System.Drawing.Point(435, 32);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 50);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.CausesValidation = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(7, 4);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(623, 419);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // LoginSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginSuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSuccessForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.account_dtv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView account_dtv;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox name_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_lb;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}