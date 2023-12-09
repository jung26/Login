using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Login&Registration.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        SqlDataReader mdr;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {
            Form1 user = new Form1();
            user.Show();
            this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();

                    string selectQuery = "SELECT * FROM Account WHERE [User] = @Username AND [Password] = @Password";

                    using (SqlCommand command = new SqlCommand(selectQuery, Con))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        using (SqlDataReader mdr = command.ExecuteReader())
                        {
                            if (mdr.Read())
                            {
                             
                                LoginSuccessForm cust = new LoginSuccessForm();
                                cust.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong UserName or Password");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }

        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password_cb.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 user = new Form2();
            user.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}