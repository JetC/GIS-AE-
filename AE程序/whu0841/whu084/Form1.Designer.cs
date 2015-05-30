namespace whu084
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMxd = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuAddSHP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddLyr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttributeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.PicViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPP下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.微博分享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天气查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuOpenAttr = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(685, 108);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 0;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(12, 27);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(792, 28);
            this.axToolbarControl1.TabIndex = 1;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(12, 75);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(162, 199);
            this.axTOCControl1.TabIndex = 2;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(205, 75);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(599, 427);
            this.axMapControl1.TabIndex = 3;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuAttributeQuery,
            this.PicViewToolStripMenuItem,
            this.aPP下载ToolStripMenuItem,
            this.微博分享ToolStripMenuItem,
            this.天气查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMxd,
            this.ManuAddSHP,
            this.MenuAddLyr});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // OpenMxd
            // 
            this.OpenMxd.Name = "OpenMxd";
            this.OpenMxd.Size = new System.Drawing.Size(122, 22);
            this.OpenMxd.Text = "&Open";
            this.OpenMxd.Click += new System.EventHandler(this.OpenMxd_Click);
            // 
            // ManuAddSHP
            // 
            this.ManuAddSHP.Name = "ManuAddSHP";
            this.ManuAddSHP.Size = new System.Drawing.Size(122, 22);
            this.ManuAddSHP.Text = "&AddShp";
            this.ManuAddSHP.Click += new System.EventHandler(this.MenuAddSHP_Click);
            // 
            // MenuAddLyr
            // 
            this.MenuAddLyr.Name = "MenuAddLyr";
            this.MenuAddLyr.Size = new System.Drawing.Size(122, 22);
            this.MenuAddLyr.Text = "AddLyr";
            this.MenuAddLyr.Click += new System.EventHandler(this.MenuAddLyr_Click);
            // 
            // menuAttributeQuery
            // 
            this.menuAttributeQuery.Name = "menuAttributeQuery";
            this.menuAttributeQuery.Size = new System.Drawing.Size(68, 21);
            this.menuAttributeQuery.Text = "属性查询";
            this.menuAttributeQuery.Click += new System.EventHandler(this.menuAttributeQuery_Click);
            // 
            // PicViewToolStripMenuItem
            // 
            this.PicViewToolStripMenuItem.Name = "PicViewToolStripMenuItem";
            this.PicViewToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.PicViewToolStripMenuItem.Text = "校园图景";
            this.PicViewToolStripMenuItem.Click += new System.EventHandler(this.PicViewToolStripMenuItem_Click);
            // 
            // aPP下载ToolStripMenuItem
            // 
            this.aPP下载ToolStripMenuItem.Name = "aPP下载ToolStripMenuItem";
            this.aPP下载ToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.aPP下载ToolStripMenuItem.Text = "APP下载";
            this.aPP下载ToolStripMenuItem.Click += new System.EventHandler(this.aPP下载ToolStripMenuItem_Click);
            // 
            // 微博分享ToolStripMenuItem
            // 
            this.微博分享ToolStripMenuItem.Name = "微博分享ToolStripMenuItem";
            this.微博分享ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.微博分享ToolStripMenuItem.Text = "微博分享";
            this.微博分享ToolStripMenuItem.Click += new System.EventHandler(this.微博分享ToolStripMenuItem_Click);
            // 
            // 天气查询ToolStripMenuItem
            // 
            this.天气查询ToolStripMenuItem.Name = "天气查询ToolStripMenuItem";
            this.天气查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.天气查询ToolStripMenuItem.Text = "天气查询";
            this.天气查询ToolStripMenuItem.Click += new System.EventHandler(this.天气查询ToolStripMenuItem_Click);
            // 
            // axMapControl2
            // 
            this.axMapControl2.Location = new System.Drawing.Point(12, 281);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(162, 221);
            this.axMapControl2.TabIndex = 5;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            this.axMapControl2.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl2_OnMouseMove);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpenAttr,
            this.删除ToolStripMenuItem});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(137, 48);
            // 
            // MenuOpenAttr
            // 
            this.MenuOpenAttr.Name = "MenuOpenAttr";
            this.MenuOpenAttr.Size = new System.Drawing.Size(136, 22);
            this.MenuOpenAttr.Text = "打开属性表";
            this.MenuOpenAttr.Click += new System.EventHandler(this.MenuOpenAttr_Click_1);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(380, 472);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 21);
            this.txtName.TabIndex = 7;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 543);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.txtName);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SakuraWHU游客信息查询系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMxd;
        private System.Windows.Forms.ToolStripMenuItem ManuAddSHP;
        private System.Windows.Forms.ToolStripMenuItem MenuAddLyr;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenAttr;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAttributeQuery;
        private System.Windows.Forms.ToolStripMenuItem PicViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPP下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 微博分享ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem 天气查询ToolStripMenuItem;
    }
}

