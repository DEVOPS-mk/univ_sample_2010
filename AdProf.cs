using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Univer
{
    public partial class AdProf : Form
    {
        public AdProf()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdProf_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           TextBox txt=new TextBox();
            
            

        }
        byte[] bl;

        private void button1_Click(object sender, EventArgs e)
        {
            string str="Data Source=.;Initial Catalog=Univ;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(str);
            
            string cmd = "Insert into Prof(PID,Pname,License,Degree,img_prof) values(N'" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + comboBox1.SelectedItem + "', N'" + listBox1.SelectedItem + "', @pic)";

            try
            {

                
                SqlParameter s = new SqlParameter("pic", bl);
                s.ParameterName = "pic";
                s.SqlDbType = SqlDbType.Image;
                s.SqlValue = bl;
                SqlCommand sqlcmd = new SqlCommand(cmd, sqlcon);
                
                sqlcmd.Parameters.Add(s);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("...ثبت شد ");

            }

            catch
            {
                MessageBox.Show("  اشکال در ثبت اطلاعات");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
            textBox5.Text = openFileDialog1.FileName;
            
           
           
            


            FileStream fl = new FileStream(openFileDialog1.FileName,FileMode.Open);

             bl = new BinaryReader(fl).ReadBytes((int) fl.Length);

            fl.Close();

            pictureBox1.Load(textBox5.Text);

          



        }
    }
}
