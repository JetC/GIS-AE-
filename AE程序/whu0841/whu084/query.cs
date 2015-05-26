using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using System.Collections;
using System.Data.OleDb;

namespace whu084
{
    public partial class query : Form
    {
        private AxMapControl mMapControl;
        public query(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mMapControl = mapControl;
        }
        ArrayList arr = new ArrayList(); 
         private void query_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("学号", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("姓名", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("性别", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("住址", 50, HorizontalAlignment.Center);

        }
        private void button1_Click(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            //string mm = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Windows.Forms.Application.StartupPath + @"\\实验.mdb;Password=;";
             OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\863\\实验.mdb");
            //OleDbConnection conn = new OleDbConnection(mm);
            //MessageBox.Show("ok");
            conn.Open();
            string strsql = "select * from [Table] where [姓名]='" + textBox1.Text + "'";//或者like语句           
            OleDbCommand cmd = new OleDbCommand(strsql, conn);           
            OleDbDataAdapter ad = new OleDbDataAdapter();           
            ad.SelectCommand = cmd;           
            DataTable dt = new DataTable();            
            ad.Fill(dt);            
            for (int i = 0; i < dt.Rows.Count; i++)           
            {               
                if (!arr.Contains(dt.Rows[i]))                
                {                   
                    arr.Add(dt.Rows[i]);               
                }               
                ListViewItem li = new ListViewItem();               
                li.SubItems[0].Text = dt.Rows[i][0].ToString();               
                li.SubItems.Add(dt.Rows[i][1].ToString());                
                li.SubItems.Add(dt.Rows[i][2].ToString());
                li.SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items.Add(li);           
            } 
        }

        }

       
    }
