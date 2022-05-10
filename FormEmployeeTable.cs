using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBD
{
    public partial class FormEmployeeTable : Form
    {
        public FormEmployeeTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
