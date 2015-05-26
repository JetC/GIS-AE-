using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;






namespace whu084
{
    public partial class Form1 : Form
    {
        ILayer pLayer;
        private int mMouseFlag;
        public Form1()
        {
            InitializeComponent();
        }

        private double ConvertPixelToMapUnits(IActiveView activeView, double pixelUnits)
        {

            double realWorldDiaplayExtent;

            int pixelExtent;

            double sizeOfOnePixel;

            double mapUnits;

            //获取设备中视图显示宽度，即像素个数 

            pixelExtent = activeView.ScreenDisplay.DisplayTransformation.get_DeviceFrame().right -

activeView.ScreenDisplay.DisplayTransformation.get_DeviceFrame().left;

            //获取地图坐标系中地图显示范围 

            realWorldDiaplayExtent =

activeView.ScreenDisplay.DisplayTransformation.VisibleBounds.Width;

            //每个像素大小代表的实际距离 

            sizeOfOnePixel = realWorldDiaplayExtent / pixelExtent;

            //地理距离 

            mapUnits = pixelUnits * sizeOfOnePixel;

            return mapUnits;

        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenMxd_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenMXD = new OpenFileDialog(); //可实例化类
            // Gets or sets the file dialog box title. (Inherited from FileDialog.)
            OpenMXD.Title = "打开地图"; // OpenFileDialog类的属性Title
            // Gets or sets the initial directory displayed by the file dialog box. 
            OpenMXD.InitialDirectory = "C:";
            // Gets or sets the current file name filter string ,Save as file type
            OpenMXD.Filter = "Map Documents (*.mxd)|*.mxd";
            if (OpenMXD.ShowDialog() == DialogResult.OK) //ShowDialog是类的方法
            {
                //FileName:Gets or sets a string containing the file name selected in the file dialog box
                string MxdPath = OpenMXD.FileName;
                axMapControl1.LoadMxFile(MxdPath); //IMapControl2的方法
            }


        }

        private void MenuAddSHP_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenShpFile = new OpenFileDialog();
            OpenShpFile.Title = "打开Shape文件";
            OpenShpFile.InitialDirectory = "C:";
            OpenShpFile.Filter = "Shape文件(*.shp)|*.shp";
            if (OpenShpFile.ShowDialog() == DialogResult.OK)
            {
                string ShapPath = OpenShpFile.FileName;
                int Position = ShapPath.LastIndexOf("\\"); //利用"\\"将文件路径分成两部分
                string FilePath = ShapPath.Substring(0, Position);
                string ShpName = ShapPath.Substring(Position + 1);
                axMapControl1.AddShapeFile(FilePath, ShpName);
            }


        }

        private void MenuAddLyr_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenLyrFile = new OpenFileDialog();
            OpenLyrFile.Title = "打开Lyr";
            OpenLyrFile.InitialDirectory = "C:";
            OpenLyrFile.Filter = "lyr文件(*.lyr)|*.lyr";
            if (OpenLyrFile.ShowDialog() == DialogResult.OK)
            {
                string LayPath = OpenLyrFile.FileName;
                axMapControl1.AddLayerFromFile(LayPath);
            }

        }

        private void axMapControl1_OnExtentUpdated(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            // 得到新范围
            IEnvelope pEnvelope = (IEnvelope)e.newEnvelope;
            IGraphicsContainer pGraphicsContainer = axMapControl2.Map as IGraphicsContainer;
            IActiveView pActiveView = pGraphicsContainer as IActiveView;
            //在绘制前，清除axMapControl2中的任何图形元素
            pGraphicsContainer.DeleteAllElements();
            IRectangleElement pRectangleEle = new RectangleElementClass();
            IElement pElement = pRectangleEle as IElement;
            pElement.Geometry = pEnvelope;
            //设置鹰眼图中的红线框
            IRgbColor pColor = new RgbColorClass();
            pColor.Red = 255; pColor.Green = 0; pColor.Blue = 0; pColor.Transparency = 255;
            //产生一个线符号对象
            ILineSymbol pOutline = new SimpleLineSymbolClass();
            pOutline.Width = 3; pOutline.Color = pColor;
            //设置颜色属性
            pColor = new RgbColorClass();
            pColor.Red = 255; pColor.Green = 0; pColor.Blue = 0; pColor.Transparency = 0;
            //设置填充符号的属性
            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = pColor; pFillSymbol.Outline = pOutline;
            IFillShapeElement pFillShapeEle = pElement as IFillShapeElement;
            pFillShapeEle.Symbol = pFillSymbol;
            pGraphicsContainer.AddElement((IElement)pFillShapeEle, 0);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);//部分刷新


        }


        private void axMapControl1_OnMapReplaced(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMapReplacedEvent e)
        {
            if (axMapControl1.LayerCount > 0)
            {
                axMapControl2.Map = new MapClass();
                for (int i = 0; i <= axMapControl1.Map.LayerCount - 1; i++)
                {
                    axMapControl2.AddLayer(axMapControl1.get_Layer(i));
                }
                axMapControl2.Extent = axMapControl1.Extent;
                axMapControl2.Refresh();
            }
        }

        private void axMapControl2_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 1)
            {
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                axMapControl1.CenterAt(pPoint);
                axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
            }

        }

        private void axMapControl2_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (axMapControl2.Map.LayerCount > 0)
            {
                if (e.button == 1)
                {
                    IPoint pPoint = new PointClass();
                    pPoint.PutCoords(e.mapX, e.mapY);
                    axMapControl1.CenterAt(pPoint);
                    axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                }
                else if (e.button == 2)
                {
                    IEnvelope pEnv = axMapControl2.TrackRectangle();
                    axMapControl1.Extent = pEnv;
                    axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                }
            }


        }

       private void axTOCControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {
            if (axMapControl1.LayerCount > 0)
            {
                esriTOCControlItem pItem = new esriTOCControlItem();
                pLayer = new FeatureLayerClass();
                IBasicMap pBasicMap = new MapClass();
                object pOther = new object();
                object pIndex = new object();
                // Returns the item in the TOCControl at the specified coordinates.
                axTOCControl1.HitTest(e.x, e.y, ref pItem, ref pBasicMap, ref pLayer , ref pOther, ref pIndex);
            }//TOCControl类的ITOCControl接口的HitTest方法
            if (e.button == 2)
            {
                context.Show(axTOCControl1, e.x, e.y);
            }

        }


  /*     private void MenuOpenAttr_Click(object sender, EventArgs e)
        {
            //传入图层，在右击事件里返回的图层
            pLayer = new FeatureLayerClass();
            FrmAttribute frm1 = new FrmAttribute(pLayer as IFeatureLayer);
            frm1.Show();


        }*/

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
           /* if (axMapControl1.LayerCount > 0)
            {
                esriTOCControlItem pItem = new esriTOCControlItem();
                pLayer = new FeatureLayerClass();
                IBasicMap pBasicMap = new MapClass();
                object pOther = new object();
                object pIndex = new object();
                // Returns the item in the TOCControl at the specified coordinates.
                axTOCControl1.HitTest(e.x, e.y, ref pItem, ref pBasicMap, ref pLayer, ref pOther, ref pIndex);
            }//TOCControl类的ITOCControl接口的HitTest方法
            if (e.button == 2)
            {
                context.Show(axTOCControl1, e.x, e.y);
            }*/
            
            if (mMouseFlag==1) 

              { 
                IFeatureLayer pFeatureLayer; 

                IFeatureClass pFeatureClass ; 

                //获取图层和要素类，为空时返回 

                pFeatureLayer = this .axMapControl1 .Map.get_Layer(1) as IFeatureLayer ; 

                if (pFeatureLayer.Name != "xian") 

                  return;
                this.axMapControl1.Map.ClearSelection(); 

                pFeatureClass = pFeatureLayer.FeatureClass ; 

                if (pFeatureClass == null) 

                    return; 

                  IActiveView pActiveView; 

                 IPoint pPoint; 

                 double length; 

                 //获取视图范围 

                 pActiveView = this .axMapControl1 .ActiveView ; 

                //获取鼠标点击屏幕坐标 

                 pPoint = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y); 

               //2个像素大小的屏幕距离转换为地图距离 

                 length = ConvertPixelToMapUnits (pActiveView, 2); 

                 ITopologicalOperator pTopoOperator; 

                 IGeometry pGeoBuffer; 

                 ISpatialFilter pSpatialFilter; 

                 //根据缓冲半径生成空间过滤器 

                 pTopoOperator = pPoint as ITopologicalOperator; 

                 pGeoBuffer = pTopoOperator.Buffer(length); 

                 pSpatialFilter = new SpatialFilterClass (); 

                 pSpatialFilter.Geometry = pGeoBuffer; 

                 //根据图层类型选择缓冲方式 

                switch (pFeatureClass .ShapeType) 

                 { 

                     case esriGeometryType .esriGeometryPoint: 

                     pSpatialFilter.SpatialRel = esriSpatialRelEnum .esriSpatialRelContains ; 

                     break; 

                     case esriGeometryType .esriGeometryPolyline : 

                     pSpatialFilter.SpatialRel = esriSpatialRelEnum .esriSpatialRelCrosses ; 

                     break; 

                     case esriGeometryType .esriGeometryPolygon : 

                     pSpatialFilter.SpatialRel = esriSpatialRelEnum .esriSpatialRelIntersects ; 

                     break; 

                  } 

                //定义空间过滤器的空间字段 

                pSpatialFilter.GeometryField = pFeatureClass .ShapeFieldName; 
                  IQueryFilter pQueryFilter; 

                  IFeatureCursor pFeatureCursor; 

                  IFeature pFeature; 

                  //利用要素过滤器查询要素 

                  pQueryFilter = pSpatialFilter as IQueryFilter; 

                  pFeatureCursor = pFeatureLayer.Search(pQueryFilter, true); 

                  pFeature = pFeatureCursor.NextFeature(); 

                  int fieldIndex; 

                  if(pFeature!=null) 

                  { 

                       //选择指定要素 

                       this .axMapControl1 .Map.ClearSelection(); 

                       this .axMapControl1 .Map.SelectFeature((ILayer)pFeatureLayer, pFeature); 

                       this .axMapControl1 .Refresh(); 

                       fieldIndex = pFeature.Fields .FindField("属性"); 

                       MessageBox.Show("查找到“" + pFeature.get_Value(fieldIndex) + "”", "提示"); 

                  } 

              }
        
        }

       
        private void MenuOpenAttr_Click_1(object sender, EventArgs e)
        {
            //传入图层，在右击事件里返回的图层
           
            FrmAttribute frm1 = new FrmAttribute(pLayer as IFeatureLayer);
            frm1.Show();

        }

        private void menuAttributeQuery_Click(object sender, EventArgs e)
        {
            AttributeQueryForm frmattributequery = new AttributeQueryForm(this.axMapControl1);
            frmattributequery.Show(); 
        }

       

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys .Enter) 

         { 

              //定义图层，要素游标，查询过滤器，要素 

              IFeatureLayer pFeatureLayer; 

              IFeatureCursor pFeatureCursor; 

              IQueryFilter pQueryFilter; 

              IFeature pFeature; 

              //获取图层 

              pFeatureLayer = this .axMapControl1 .Map.get_Layer(2) as IFeatureLayer; 

              //如果图层名称不是states ，程序退出 

              if (pFeatureLayer.Name != "sushe") 

                   return; 

              //清除上次查询结果 

              this .axMapControl1 .Map.ClearSelection(); 

              //pQueryFilter 的实例化 

              pQueryFilter = new QueryFilterClass (); 

              //设置查询过滤条件 

              pQueryFilter.WhereClause = "属性='" + txtName .Text + "'" ; 

              //查询 

              pFeatureCursor = pFeatureLayer.Search(pQueryFilter, true); 

              //获取查询到的要素 

              pFeature = pFeatureCursor.NextFeature(); 

              //判断是否获取到要素 

              if (pFeature!=null) 

              { 

                   //选择要素 

                   this .axMapControl1 .Map.SelectFeature(pFeatureLayer, pFeature); 

                   //放大到要素 

                   this .axMapControl1 .Extent = pFeature.Shape.Envelope; 

              } 

              else 

              { 

                   //没有得到pFeature 的提示 

                   MessageBox.Show("没有找到" + txtName .Text , "提示"); 

              } 

         } 

    }

        private void btnPointQuery_Click(object sender, EventArgs e)
        {
            //标记点查询 

            mMouseFlag = 1;

            //设置鼠标形状 

            this.axMapControl1.MousePointer =

            ESRI.ArcGIS.Controls.esriControlsMousePointer.esriPointerCrosshair; 

        }

        private void infrQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfrQuery infr = new InfrQuery(this.axMapControl1);
            infr.Show(); 
        }

        private void menuNetwork_Click(object sender, EventArgs e)
        {
            MainForm infr = new MainForm(this.axMapControl1);
            infr.Show(); 
        }

        private void PicViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicView frmattributequery = new PicView(this.axMapControl1);
            frmattributequery.Show();
        }

        private void 信息查询2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query frm = new query(this.axMapControl1);
            frm.Show();
        }

        private void 天气查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm infr = new MainForm(this.axMapControl1);
            infr.Show(); 
        }

        

        
        

      /*  private void MenuOpenAttr_Click(object sender, EventArgs e)
        {
            //传入图层，在右击事件里返回的图层
            FrmAttribute frm1 = new FrmAttribute(pLayer as IFeatureLayer);
            frm1.Show();

        }*/


        


       

       
    }
}

        
    

