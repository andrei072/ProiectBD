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
using System.Windows.Forms;

namespace ProjectBD
{
    public partial class FormEmployeeTable : Form
    {
        public FormEmployeeTable()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668\MSSQLSERVER02;Initial Catalog=ProiectBD;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt;
        public void ShowData()
        {

           adapter = new SqlDataAdapter("SELECT * FROM tableEmployee", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectBDDataSet.TableEmployee' table. You can move, or remove it, as needed.
            this.tableEmployeeTableAdapter.Fill(this.proiectBDDataSet.TableEmployee);
            // TODO: This line of code loads data into the 'proiectBDDataSet.TableEmployee' table. You can move, or remove it, as needed.
            this.tableEmployeeTableAdapter.Fill(this.proiectBDDataSet.TableEmployee);
            // TODO: This line of code loads data into the 'proiectBDDataSet.TableEmployee' table. You can move, or remove it, as needed.
            this.tableEmployeeTableAdapter.Fill(this.proiectBDDataSet.TableEmployee);
            // TODO: This line of code loads data into the 'proiectBDDataSet7.TableEmployee' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'proiectBDDataSet.TableEmployee' table. You can move, or remove it, as needed.
            this.tableEmployeeTableAdapter.Fill(this.proiectBDDataSet.TableEmployee);

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FormAddEmployee FormNew = new FormAddEmployee();
            FormNew.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

            int rowIndex = e.RowIndex;
            FormDescription FormD = new FormDescription();
            FormEmployeeTable FormEmployee = new FormEmployeeTable();
            FormD.textBoxDescription.Text = FormEmployee.dataGridViewEmployee.Rows[rowIndex].Cells[6].Value.ToString();

            SqlCommand cmd;
            cmd = new SqlCommand("Select LogText FROm tableEmployee", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
            this.dataGridViewEmployee.Refresh();
            this.dataGridViewEmployee.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
