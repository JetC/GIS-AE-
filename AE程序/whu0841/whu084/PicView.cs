using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ESRI.ArcGIS.Controls;
using System.IO;


namespace whu084
{
    public partial class PicView : Form
    {
        Bitmap myBitmap;
        
        private int index = -1;
        
        private ArrayList arrPath = new ArrayList();
        private int width = 800;
        private int height = 300;
        private AxMapControl mMapControl;
        public PicView(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mMapControl = mapControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.jpg;*.bmp|*.jpg;*.bmp;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap srcBitmap = new Bitmap(openFile.FileName);
                myBitmap = new Bitmap(srcBitmap, this.pictureBox1.Width, this.pictureBox1.Height);
                this.pictureBox1.Image = myBitmap;
                //this.pictureBox1.Image = Image.FromFile(openFile.FileName);
                if (openFile.FileNames.Length != -1)
                {
                    foreach (string s in openFile.FileNames)
                    {
                        arrPath.Add(s);
                    }
                    index = 0;
                    pictureBox1.Load(arrPath[index].ToString());
                }
            button1_Click(sender,e);

           }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < arrPath.Count - 1)
            {
                pictureBox1.Load(arrPath[++index].ToString());
            }
            else
            {
                index = 0;
                pictureBox1.Load(arrPath[index].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                index = (index == 0) ? (arrPath.Count - 1) : (--index);
                for (int i = 0; i <= index; i++)
                {
                    pictureBox1.Load(arrPath[i].ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (index < arrPath.Count - 1)
                {
                    pictureBox1.Load(arrPath[++index].ToString());
                }
                else { index = 0; pictureBox1.Load(arrPath[index].ToString()); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                timer1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                timer1.Enabled = false;
            } 
        }
    }
}
