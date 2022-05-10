using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectBD
{
    public partial class FormLogIn : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668\MSSQLSERVER02;Initial Catalog=ProiectBD;Integrated Security=True");
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
           
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "password")
            {
                new FormEmployeeTable().Show();
                this.Hide();

            }
            else if (textBoxUsername.Text == null && textBoxPassword.Text == null)
            {
                MessageBox.Show(
                     "Nu ai introdus Username-ul si Parola",
                     "Warning!",
                     MessageBoxButtons.OK);
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
                
            }
            else
            {
                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                try
                {
                    String querry = "SELECT * FROM TableEmployee WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if(dtable.Rows.Count > 0)
                    {
                        username = textBoxUsername.Text;
                        password = textBoxPassword.Text;

                        FormEmployeeLogTime F3 = new FormEmployeeLogTime();
                        F3.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        textBoxUsername.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
