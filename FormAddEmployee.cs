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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668\MSSQLSERVER02;Initial Catalog=ProiectBD;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("INSERT into TableEmployee(Surname, [Last Name], username, password) VALUES('" + textBoxName.Text + "','" + textBoxSurname.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')", conn);
            int i = sc.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Angajat adaugat");
            }
            else
            {
                MessageBox.Show("Eroare!");
            }
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxName.Focus();
        }
    }
}
