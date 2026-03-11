using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
		string connectionString = "Data Source=DESKTOP-DB8HM32\\SQLEXPRESS; Initial Catalog=WINFORMAPP; TrustServerCertificate=True; Integrated Security=True";
		SqlCommandBuilder Bldr; 
        SqlDataAdapter da; 
        DataRow rec;
		DataSet ds;

		public Form2()
        {
            InitializeComponent();
        }

		private void Form2_Load(object sender, EventArgs e)
		{
			da = new SqlDataAdapter("Select *  from Employeetb", connectionString);
			ds = new DataSet();
			da.Fill(ds, "Employeetb");
			dataGridView1.DataSource = ds.Tables[0];
			da.FillSchema(ds, SchemaType.Source, "Employeetb");
			Bldr = new SqlCommandBuilder(da);
		}

		private void btnInsert_Click(object sender, EventArgs e)
        {
			try
			{
				rec = ds.Tables[0].NewRow();
				rec[0] = txtEmpId.Text;
				rec[1] = txtEmpName.Text;
				rec[2] = txtDesignation.Text;
				rec[3] = txtDOJ.Text;
				rec[4] = txtSalary.Text;
				rec[5] = txtDeptNo.Text;
				ds.Tables[0].Rows.Add(rec);
				MessageBox.Show("Record is Inserted into dataset Table");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateToDatabase_Click(object sender, EventArgs e)
        {

        }

        
    }
}
