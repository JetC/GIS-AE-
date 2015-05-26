using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Extensions;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.NetworkAnalysis;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Controls;
using System.Net;
using System.IO;
using SpfAE;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace whu084
{
    public partial class MainForm : Form
    {
        private AxMapControl mMapControl;
       

        public MainForm(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mMapControl = mapControl;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://api.wunderground.com/api/f43a2d3eaa085044/conditions/q/CA/San_Francisco.json");
            myRequest.Method = "GET";
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            string tempStr = Regex.Match(content, "\\weather\":\"[^\"]*").Value;
            tempStr = tempStr.Replace("\":\"", ":");
            label1.Text = tempStr;
       }
     
 
        }
    }

