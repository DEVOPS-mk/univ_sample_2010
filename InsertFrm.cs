using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.IO;

namespace Univer
{
    public partial class InsertFrm : Form
    {
        public InsertFrm()
        {
            InitializeComponent();
        }

        
        byte[] bl;
        string d;
        private void button1_Click(object sender, EventArgs e)
        {
            string str="Data Source=.;Initial Catalog=Univ;Integrated Security=True";


            string str2 = "Insert into student(SID,Sname,Scity,Stel,Entrance_Year,image_st ) values('" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "', N'" + textBox4.Text + "',N'" + textBox5.Text + "', @pic)";

            SqlParameter picparameter = new SqlParameter();

            picparameter.SqlDbType = SqlDbType.Image;
            picparameter.ParameterName = "pic";
            picparameter.Value = bl;


            SqlConnection sqlCon = new SqlConnection(str);
            SqlCommand sqlcmd = new SqlCommand(str2, sqlCon);
            try
            {

                sqlCon.Open();
                sqlcmd.Parameters.Add(picparameter);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد");
                sqlCon.Close();

            }
            catch
            {
                MessageBox.Show("اشکال در ثبت اطلاعات");
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
             d = openFileDialog1.FileName;
            textBox6.Text = d.ToString();
            FileStream  fl = new FileStream(d, FileMode.Open);
           int p =(int) fl.Length;
           bl = new BinaryReader(fl).ReadBytes((int) fl.Length);
           fl.Close(); 


          
            

            
        }

        private void InsertFrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }
    }
}
