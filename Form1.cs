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
using Microsoft.Win32;
using MS.Internal;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using WIA;




namespace Univer
{
   
        
    
    public partial class Form1 : Form
    {


        
        
        public Form1()
        {
            InitializeComponent();
        }

       
        private void AddsMenuItem_Click(object sender, EventArgs e)
        {

            

            AddSt frm2 = new AddSt();
            frm2.Show();


        }

        private void StMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            InsertFrm frm3 = new InsertFrm();
            frm3.Show();
        }

        private void CapMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void SysMenuItem_Click(object sender, EventArgs e)
        {
            sysINFO frm = new sysINFO();
            frm.Show();




        }

        private void AddPMenuItem1_Click(object sender, EventArgs e)
        {
            AdProf frm = new AdProf();
            frm.Show();
        }

        private void ShowMenuItem1_Click(object sender, EventArgs e)
        {
            profShow ps = new profShow();
            ps.Show();
        }

        private void mYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
