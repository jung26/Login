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

namespace Login
{
    public partial class LoginSuccessForm : Form
    {
        public LoginSuccessForm()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += (sender, e) => populate();
            populate();
            fillcategory();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Login&Registration.mdf;Integrated Security=True;Connect Timeout=30");



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();

        }

        public void populate()
        {

            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM Account";

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    account_dtv.DataSource = dt;
                    account_dtv.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
            private void tabPage1_Click(object sender, EventArgs e)
        {
            populate();

        }



        void fillcategory()
        {
            try
            {
                Con.Open();
               
                string query = "SELECT * FROM Account";
                SqlCommand cmd = new SqlCommand(query, Con);

              
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                name_cb.ValueMember = "Id"; 
                name_cb.DisplayMember = "Id"; 
                name_cb.DataSource = dt;

               
                name_cb.DropDownStyle = ComboBoxStyle.DropDownList;

               

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            populate();
            user_tb.Visible = false;
            password_tb.Visible = false;
            user_lb.Visible = false;
            password_lb.Visible = false;
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private int selectedAccountId = 0; 
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                
                string query = "UPDATE Account SET User=@User WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@User", user_tb.Text);
                cmd.Parameters.AddWithValue("@Id", selectedAccountId);
               
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated");
                   
                    user_tb.Text = "";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate(); 
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            user_tb.Visible = false;
            password_tb.Visible=false;
            user_lb.Visible=false;
            password_lb.Visible=false; 
            

            if (name_cb.SelectedItem != null)
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM Account WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Id", name_cb.SelectedValue);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete");
            }
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_tb.Visible = true;
            password_tb.Visible = true;
            user_lb.Visible = true;
            password_lb.Visible = true;
            

            if (name_cb.SelectedItem != null)
            {
                try
                {
                    Con.Open();
                    //history
                    string query2 = "INSERT INTO HistoryTable(Username, Password) VALUES (@Username, @Password)";
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    cmd2.Parameters.AddWithValue("@Username", user_tb.Text);
                    cmd2.Parameters.AddWithValue("@Password", password_tb.Text);
                    int rowsAffected2 = cmd2.ExecuteNonQuery();
                    if (rowsAffected2 > 0)
                    {
                      
                        MessageBox.Show("Successfully Updated");

                    }


                    string query = "UPDATE Account SET [User]=@User, Password=@Password WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@User", user_tb.Text);
                    cmd.Parameters.AddWithValue("@Password", password_tb.Text); 
                    cmd.Parameters.AddWithValue("@Id", name_cb.SelectedValue);
                   
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update");
            }



        }
        public void populate1()
        {

            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM HistoryTable";

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHistory.DataSource = dt;
                    dgvHistory.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            populate1();
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
