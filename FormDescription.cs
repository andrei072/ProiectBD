﻿using System;
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
    public partial class FormDescription : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668\MSSQLSERVER02;Initial Catalog=ProiectBD;Integrated Security=True");
        SqlDataAdapter data;
        DataTable dt;

        public FormDescription()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDescription_Load(object sender, EventArgs e)
        {
         
        }
    }
}
