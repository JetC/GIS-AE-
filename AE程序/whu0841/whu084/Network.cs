﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.NetworkAnalysis;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Controls;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace whu084
{
    public partial class MainForm : Form
    {
        //地图数据 
        private AxMapControl mMapControl;
        /*//几何网络 
        private IGeometricNetwork mGeometricNetwork;
        //给定点的集合 
        private IPointCollection mPointCollection;
        //获取给定点最近的Network元素 
        private IPointToEID mPointToEID;

        //返回结果变量 
        private IEnumNetEID mEnumNetEID_Junctions;
        private IEnumNetEID mEnumNetEID_Edges;
        private double mdblPathCost;

        //地图数据 
        private AxMapControl mMapControl;
        //选中图层 
        private IFeatureLayer mFeatureLayer;
        //根据所选择的图层查询得到的特征类
        private IFeatureClass pFeatureClass = null;
 
        private void SolvePath(string weightName) 
        { 
            //创建ITraceFlowSolverGEN 
            ITraceFlowSolverGEN pTraceFlowSolverGEN = new TraceFlowSolverClass(); 
            INetSolver pNetSolver = pTraceFlowSolverGEN as INetSolver; 
            //初始化用于路径计算的Network 
            INetwork pNetWork = mGeometricNetwork.Network; 
            pNetSolver.SourceNetwork = pNetWork; 
 
            //获取分析经过的点的个数 
            int intCount = mPointCollection.PointCount; 
            if (intCount < 1) 
                return; 
 
             
            INetFlag pNetFlag; 
            //用于存储路径计算得到的边 
            IEdgeFlag[] pEdgeFlags = new IEdgeFlag[intCount]; 
 
             
            IPoint pEdgePoint = new PointClass(); 
            int intEdgeEID; 
            IPoint pFoundEdgePoint; 
            double dblEdgePercent; 
 
            //用于获取几何网络元素的UserID, UserClassID,UserSubID 
            INetElements pNetElements = pNetWork as INetElements; 
            int intEdgeUserClassID; 
            int intEdgeUserID; 
            int intEdgeUserSubID; 
            for (int i = 0; i < intCount; i++) 
            { 
                pNetFlag = new EdgeFlagClass(); 
                //获取用户点击点 
                pEdgePoint = mPointCollection.get_Point(i); 
                //获取距离用户点击点最近的边 
                mPointToEID.GetNearestEdge(pEdgePoint, out intEdgeEID, out pFoundEdgePoint, 
out dblEdgePercent); 
                if (intEdgeEID <= 0) 
                    continue; 
                //根据得到的边查询对应的几何网络中的元素UserID, UserClassID,UserSubID 
                pNetElements.QueryIDs(intEdgeEID, esriElementType.esriETEdge,
                out intEdgeUserClassID, out intEdgeUserID, out intEdgeUserSubID);
                if (intEdgeUserClassID <= 0 || intEdgeUserID <= 0)
                    continue;

                pNetFlag.UserClassID = intEdgeUserClassID;
                pNetFlag.UserID = intEdgeUserID;
                pNetFlag.UserSubID = intEdgeUserSubID;
                pEdgeFlags[i] = pNetFlag as IEdgeFlag;
            }
            //设置路径求解的边 
            pTraceFlowSolverGEN.PutEdgeOrigins(ref pEdgeFlags);

            //路径计算权重 
            INetSchema pNetSchema = pNetWork as INetSchema;
            INetWeight pNetWeight = pNetSchema.get_WeightByName(weightName);
            if (pNetWeight == null)
                return;

            //设置权重，这里双向的权重设为一致 
            INetSolverWeights pNetSolverWeights = pTraceFlowSolverGEN as INetSolverWeights;
            pNetSolverWeights.ToFromEdgeWeight = pNetWeight;
            pNetSolverWeights.FromToEdgeWeight = pNetWeight;

            object[] arrResults = new object[intCount - 1];
            //执行路径计算 
            pTraceFlowSolverGEN.FindPath(esriFlowMethod.esriFMConnected,
esriShortestPathObjFn.esriSPObjFnMinSum,
                out mEnumNetEID_Junctions, out mEnumNetEID_Edges, intCount - 1, ref arrResults);

            //获取路径计算总代价（cost） 
            mdblPathCost = 0;
            for (int i = 0; i < intCount - 1; i++)
                mdblPathCost += (double)arrResults[i];
        }
        private IPolyline PathToPolyLine() 
        { 
            IPolyline pPolyLine = new PolylineClass(); 
            IGeometryCollection pNewGeometryCollection = pPolyLine as IGeometryCollection; 
            if (mEnumNetEID_Edges == null) 
                return null; 
 
            IEIDHelper pEIDHelper = new EIDHelperClass(); 
            //获取几何网络 
            pEIDHelper.GeometricNetwork = mGeometricNetwork; 
            //获取地图空间参考 
            ISpatialReference pSpatialReference = this.axMapControl1.Map.SpatialReference; 
            pEIDHelper.OutputSpatialReference = pSpatialReference; 
            pEIDHelper.ReturnGeometries = true; 
            //根据边的ID获取边的信息 
            IEnumEIDInfo pEnumEIDInfo = pEIDHelper.CreateEnumEIDInfo(mEnumNetEID_Edges); 
            int intCount = pEnumEIDInfo.Count; 
            pEnumEIDInfo.Reset(); 
 
            IEIDInfo pEIDInfo; 
            IGeometry pGeometry; 
            for (int i = 0; i < intCount;i++ ) 
            { 
                pEIDInfo = pEnumEIDInfo.Next(); 
                //获取边的几何要素 
                pGeometry = pEIDInfo.Geometry; 
                pNewGeometryCollection.AddGeometryCollection((IGeometryCollection)pGeometry); 
            } 
            return pPolyLine; 
        }*/

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

        

        /*private void MainForm_Load(object sender, EventArgs e)
        {
            //获取几何网络文件路径 
            //注意修改此路径为当前存储路径 
            string strPath = @"E:/大三下/GIS工程/zhou digital map/ditu_daolu_Network_GDB.mdb";
            //打开工作空间 
            IWorkspaceFactory pWorkspaceFactory = new AccessWorkspaceFactory();
            IFeatureWorkspace pFeatureWorkspace = pWorkspaceFactory.OpenFromFile(strPath, 0)
as IFeatureWorkspace; 
            //获取要素数据集 
            //注意名称的设置要与上面创建保持一致 
            IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset("daolu"); 
 
            //获取network集合 
            INetworkCollection pNetWorkCollection = pFeatureDataset as INetworkCollection; 
            //获取network的数量,为零时返回 
            int intNetworkCount = pNetWorkCollection.GeometricNetworkCount; 
            if (intNetworkCount < 1) 
                return; 
            //FeatureDataset可能包含多个network，我们获取指定的network 
            //注意network的名称的设置要与上面创建保持一致 
            mGeometricNetwork = pNetWorkCollection.get_GeometricNetworkByName("daolu_Net"); 
 
            //将Network中的每个要素类作为一个图层加入地图控件 
            IFeatureClassContainer pFeatClsContainer = mGeometricNetwork as 
IFeatureClassContainer; 
            //获取要素类数量，为零时返回 
            int intFeatClsCount=pFeatClsContainer.ClassCount; 
            if (intFeatClsCount < 1) 
                return; 
            IFeatureClass pFeatureClass; 
            IFeatureLayer pFeatureLayer; 
            for (int i = 0; i < intFeatClsCount;i++ ) 
            { 
                //获取要素类 
                pFeatureClass = pFeatClsContainer.get_Class(i); 
                pFeatureLayer = new FeatureLayerClass(); 
                pFeatureLayer.FeatureClass = pFeatureClass; 
                pFeatureLayer.Name = pFeatureClass.AliasName; 
                //加入地图控件 
                this.axMapControl1.AddLayer((ILayer)pFeatureLayer, 0); 
            } 
 
            //计算snap tolerance为图层最大宽度的1/100 
            //获取图层数量 
            int intLayerCount=this.axMapControl1.LayerCount; 
            IGeoDataset pGeoDataset;   
            IEnvelope pMaxEnvelope=new EnvelopeClass(); 
            for (int i = 0; i < intLayerCount;i++ ) 
            { 
                //获取图层 
                pFeatureLayer = this.axMapControl1.get_Layer(i) as IFeatureLayer; 
                pGeoDataset = pFeatureLayer as IGeoDataset;
                //通过Union获得较大图层范围 
                pMaxEnvelope.Union(pGeoDataset.Extent); 
            } 
            double dblWidth = pMaxEnvelope.Width; 
            double dblHeight = pMaxEnvelope.Height; 
            double dblSnapTol; 
            if (dblHeight < dblWidth) 
                dblSnapTol = dblWidth * 0.01; 
            else 
                dblSnapTol = dblHeight * 0.01; 
 
            //设置源地图，几何网络以及捕捉容差 
            mPointToEID = new PointToEIDClass(); 
            mPointToEID.SourceMap = this.axMapControl1.Map; 
            mPointToEID.GeometricNetwork = mGeometricNetwork; 
            mPointToEID.SnapTolerance = dblSnapTol; 
             
        

        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            //记录鼠标点击的点 
            IPoint pNewPoint = new PointClass();
            pNewPoint.PutCoords(e.mapX, e.mapY);

            if (mPointCollection == null)
                mPointCollection = new MultipointClass();
            //添加点，before和after标记添加点的索引，这里不定义 
            object before = Type.Missing;
            object after = Type.Missing;
            mPointCollection.AddPoint(pNewPoint, ref before, ref after);
        }

        private void axMapControl1_OnDoubleClick(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnDoubleClickEvent e)
        {
             try 
                { 
                //路径计算 
                //注意权重名称与设置保持一致 
                SolvePath("Shape_Length"); 
                //路径转换为几何要素 
                IPolyline pPolyLineResult = PathToPolyLine(); 
                //获取屏幕显示 
                IActiveView pActiveView = this.axMapControl1.ActiveView; 
                IScreenDisplay pScreenDisplay = pActiveView.ScreenDisplay; 
                //设置显示符号 
                ILineSymbol pLineSymbol = new CartographicLineSymbolClass(); 
                IRgbColor pColor = new RgbColorClass(); 
                pColor.Red = 255; 
                pColor.Green = 0; 
                pColor.Blue = 0; 
                //设置线宽 
                pLineSymbol.Width =4; 
                //设置颜色 
                pLineSymbol.Color = pColor as IColor; 
                //绘制线型符号 
                pScreenDisplay.StartDrawing(0, 0); 
                pScreenDisplay.SetSymbol((ISymbol)pLineSymbol); 
                pScreenDisplay.DrawPolyline(pPolyLineResult); 
                pScreenDisplay.FinishDrawing(); 
            } 
            catch (System.Exception ex) 
            { 
                MessageBox.Show("路径分析出现错误:" + "\r\n" + ex.Message); 
            } 
            //点集设为空 
            mPointCollection = null; 
        }*/

        
 
        }
    }

