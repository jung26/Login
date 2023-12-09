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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login
{
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Login&Registration.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
            PopulateGenderComboBox();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Passwordcb.Checked == true)
            {
                Password_tb.PasswordChar = '\0';
                confirnpassword_tb.PasswordChar = '\0';
            }
            else
            {
                Password_tb.PasswordChar = '*';
                confirnpassword_tb.PasswordChar = '*'; 
            }
        }
        private void PopulateGenderComboBox()
        {
           
            gender_cb.Items.Clear();

          
            gender_cb.Items.Add("Male");
            gender_cb.Items.Add("Female");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_tb.Text != "" && Password_tb.Text != "" && Email_tb.Text != "" && gender_cb.Text != "")
            {
                if (Password_tb.Text == confirnpassword_tb.Text)
                {
                    if (Email_tb.Text.EndsWith("@gmail.com"))
                    {


                        try
                        {
                            Con.Open();



                            SqlCommand cmd = new SqlCommand("INSERT INTO Account ([User], Email, Gender, Password, DateCreated,  isActive) VALUES (@User, @Email, @Gender, @Password, @DateCreated, @IsActive)", Con);



                            cmd.Parameters.AddWithValue("@User", user_tb.Text);
                            cmd.Parameters.AddWithValue("@Email", Email_tb.Text);
                            cmd.Parameters.AddWithValue("@Gender", gender_cb.Text);
                            cmd.Parameters.AddWithValue("@Password", Password_tb.Text);
                            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@LastLogin", DBNull.Value);
                            cmd.Parameters.AddWithValue("@IsActive", "Yes");

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error");
                        }
                        finally
                        {
                            Con.Close();
                        }
                    } else
                    {
                        MessageBox.Show("Enter a valud email");
                    }
                } else
                {
                    MessageBox.Show("Password does not match");
                }
            } else
            {
                MessageBox.Show("Fill all the sdkjfhakjfh");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void user_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Password_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirnpassword_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 auser = new Form1();
            auser.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
