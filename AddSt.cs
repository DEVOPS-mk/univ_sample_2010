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
using System.IO;

namespace Univer
{
    public partial class AddSt : Form
    {
        public class SQLCON
        {
            public string strCon = "Data Source=.;Initial Catalog=Univ;Integrated Security=True";

            public SqlConnection SQLcon = new SqlConnection();

            public void ConnectS(string st)
            {
                SqlConnection SQLcon = new SqlConnection(st);
                
            }


        }
 
        
        
        public AddSt()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Connect

            string strCon = "Data Source=.;Initial Catalog=Univ;Integrated Security=True";
            string strcmd = "select * from Student where SID='"+ textBox1.Text +"'";
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strcmd,con);
            DataSet ds=new DataSet();
            try {
                con.Open();

                SqlDataAdapter sqda = new SqlDataAdapter(strcmd, con);
                sqda.Fill(ds, "student");
            }
            catch
            {
                MessageBox.Show("خطا در اتصال پایگاه داده ");
            }
            try
            {

                DataRow dr = ds.Tables[0].Rows[0];
                textBox2.Text = dr["sname"].ToString();
                textBox3.Text = dr["Scity"].ToString();
                textBox4.Text = dr["Entrance_Year"].ToString();

                FileStream fll=new FileStream(@"d:\112.jpg",FileMode.Create);
              

               Byte[] v = (Byte[]) dr["Image_st"]; 

                

                fll.Write(v, 0, v.Length);

                fll.Close();

                ///////*********************************//////////

                MemoryStream ms = new MemoryStream(v);
                Image im = Image.FromStream(ms);

                pictureBox1.Image = im;
                
              



            }
            catch
            {
                MessageBox.Show("شماره دانشجویی وجود ندارد ");
            }

            con.Close();
           


            #endregion
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
