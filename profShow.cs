using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.IO;

namespace Univer
{
    public partial class profShow : Form
    {
        public profShow()
        {
            InitializeComponent();
        }

        private void profShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'univDataSet.Prof' table. You can move, or remove it, as needed.
            try
            {
                
                this.profTableAdapter.Fill(this.univDataSet.Prof);
            }
            catch 
            { MessageBox.Show("خطا در پایگاه داده"); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=Univ;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(str);
            string str2 = "select * from Prof where PID='" + textBox1.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(str2, sqlcon);
            sqlcon.Open();

            DataSet ds=new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(str2, str);
            DA.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            int dg = dataGridView1.Size.Height;
            
        
           
            
        }
    }
}
