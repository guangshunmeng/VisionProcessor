namespace VisionProcessor
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "格式",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "宽度",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "高度",
            ""}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_OpenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_History = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Edit_Rollback = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Edit_ClearSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Edit_SaveROI = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_View_Entire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_View_Origin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_View_ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_View_ZoonOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.视觉算法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像增强ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_EqualizeHist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Normalize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Blur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Reverse = new System.Windows.Forms.ToolStripMenuItem();
            this.几何变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像分割ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Segmentation_Theshold = new System.Windows.Forms.ToolStripMenuItem();
            this.形态学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Dilate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Erode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Morphology = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Skeleton = new System.Windows.Forms.ToolStripMenuItem();
            this.边缘提取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Canny = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Contour = new System.Windows.Forms.ToolStripMenuItem();
            this.几何拟合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_HoughLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_HoughCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_Match = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_MatchTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Match_Shapes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Vision_OCR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_txtCursorValue = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listOverlay = new System.Windows.Forms.ListView();
            this.colSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstProperties = new System.Windows.Forms.ListView();
            this.propName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.mnu_Vision_Affine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnu_History,
            this.视图ToolStripMenuItem,
            this.视觉算法ToolStripMenuItem,
            this.mnu_txtCursorValue});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File_Open,
            this.mnu_File_OpenColor,
            this.mnu_File_Save,
            this.mnu_File_SaveAs,
            this.mnu_File_Setting,
            this.toolStripSeparator1,
            this.mnu_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // mnu_File_Open
            // 
            this.mnu_File_Open.Name = "mnu_File_Open";
            this.mnu_File_Open.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_Open.Text = "打开灰度...";
            this.mnu_File_Open.Click += new System.EventHandler(this.mnu_File_Open_Click);
            // 
            // mnu_File_OpenColor
            // 
            this.mnu_File_OpenColor.Name = "mnu_File_OpenColor";
            this.mnu_File_OpenColor.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_OpenColor.Text = "打开彩色...";
            this.mnu_File_OpenColor.Click += new System.EventHandler(this.mnu_File_OpenColor_Click);
            // 
            // mnu_File_Save
            // 
            this.mnu_File_Save.Name = "mnu_File_Save";
            this.mnu_File_Save.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_Save.Text = "保存";
            // 
            // mnu_File_SaveAs
            // 
            this.mnu_File_SaveAs.Name = "mnu_File_SaveAs";
            this.mnu_File_SaveAs.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_SaveAs.Text = "另存为...";
            // 
            // mnu_File_Setting
            // 
            this.mnu_File_Setting.Name = "mnu_File_Setting";
            this.mnu_File_Setting.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_Setting.Text = "选项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // mnu_File_Exit
            // 
            this.mnu_File_Exit.Name = "mnu_File_Exit";
            this.mnu_File_Exit.Size = new System.Drawing.Size(133, 22);
            this.mnu_File_Exit.Text = "退出";
            this.mnu_File_Exit.Click += new System.EventHandler(this.mnu_File_Exit_Click);
            // 
            // mnu_History
            // 
            this.mnu_History.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Edit_Rollback,
            this.mnu_Edit_ClearSelect,
            this.mnu_Edit_SaveROI});
            this.mnu_History.Name = "mnu_History";
            this.mnu_History.Size = new System.Drawing.Size(44, 23);
            this.mnu_History.Text = "编辑";
            this.mnu_History.DropDownOpening += new System.EventHandler(this.mnu_History_DropDownOpening);
            // 
            // mnu_Edit_Rollback
            // 
            this.mnu_Edit_Rollback.Name = "mnu_Edit_Rollback";
            this.mnu_Edit_Rollback.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnu_Edit_Rollback.Size = new System.Drawing.Size(204, 22);
            this.mnu_Edit_Rollback.Text = "取消上一次操作";
            this.mnu_Edit_Rollback.Click += new System.EventHandler(this.mnu_Edit_Rollback_Click);
            // 
            // mnu_Edit_ClearSelect
            // 
            this.mnu_Edit_ClearSelect.Name = "mnu_Edit_ClearSelect";
            this.mnu_Edit_ClearSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnu_Edit_ClearSelect.Size = new System.Drawing.Size(204, 22);
            this.mnu_Edit_ClearSelect.Text = "清除选择";
            this.mnu_Edit_ClearSelect.Click += new System.EventHandler(this.mnu_Edit_ClearSelect_Click);
            // 
            // mnu_Edit_SaveROI
            // 
            this.mnu_Edit_SaveROI.Name = "mnu_Edit_SaveROI";
            this.mnu_Edit_SaveROI.Size = new System.Drawing.Size(204, 22);
            this.mnu_Edit_SaveROI.Text = "保存选择区域...";
            this.mnu_Edit_SaveROI.Click += new System.EventHandler(this.mnu_Edit_SaveROI_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_View_Entire,
            this.mnu_View_Origin,
            this.mnu_View_ZoomIn,
            this.mnu_View_ZoonOut,
            this.toolStripSeparator2});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // mnu_View_Entire
            // 
            this.mnu_View_Entire.Name = "mnu_View_Entire";
            this.mnu_View_Entire.Size = new System.Drawing.Size(180, 22);
            this.mnu_View_Entire.Text = "完整";
            this.mnu_View_Entire.Click += new System.EventHandler(this.mnu_View_Entire_Click);
            // 
            // mnu_View_Origin
            // 
            this.mnu_View_Origin.Name = "mnu_View_Origin";
            this.mnu_View_Origin.Size = new System.Drawing.Size(180, 22);
            this.mnu_View_Origin.Text = "原图";
            this.mnu_View_Origin.Click += new System.EventHandler(this.mnu_View_Origin_Click);
            // 
            // mnu_View_ZoomIn
            // 
            this.mnu_View_ZoomIn.Name = "mnu_View_ZoomIn";
            this.mnu_View_ZoomIn.Size = new System.Drawing.Size(180, 22);
            this.mnu_View_ZoomIn.Text = "放大";
            this.mnu_View_ZoomIn.Click += new System.EventHandler(this.mnu_View_ZoomIn_Click);
            // 
            // mnu_View_ZoonOut
            // 
            this.mnu_View_ZoonOut.Name = "mnu_View_ZoonOut";
            this.mnu_View_ZoonOut.Size = new System.Drawing.Size(180, 22);
            this.mnu_View_ZoonOut.Text = "缩小";
            this.mnu_View_ZoonOut.Click += new System.EventHandler(this.mnu_View_ZoonOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 视觉算法ToolStripMenuItem
            // 
            this.视觉算法ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图像增强ToolStripMenuItem,
            this.几何变换ToolStripMenuItem,
            this.图像分割ToolStripMenuItem,
            this.形态学ToolStripMenuItem,
            this.边缘提取ToolStripMenuItem,
            this.几何拟合ToolStripMenuItem,
            this.mnu_Vision_Match,
            this.mnu_Vision_OCR});
            this.视觉算法ToolStripMenuItem.Name = "视觉算法ToolStripMenuItem";
            this.视觉算法ToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.视觉算法ToolStripMenuItem.Text = "视觉算法";
            // 
            // 图像增强ToolStripMenuItem
            // 
            this.图像增强ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_EqualizeHist,
            this.mnu_Vision_Normalize,
            this.mnu_Vision_Blur,
            this.mnu_Vision_Reverse});
            this.图像增强ToolStripMenuItem.Name = "图像增强ToolStripMenuItem";
            this.图像增强ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.图像增强ToolStripMenuItem.Text = "图像增强";
            // 
            // mnu_Vision_EqualizeHist
            // 
            this.mnu_Vision_EqualizeHist.Name = "mnu_Vision_EqualizeHist";
            this.mnu_Vision_EqualizeHist.Size = new System.Drawing.Size(136, 22);
            this.mnu_Vision_EqualizeHist.Text = "直方图均衡";
            this.mnu_Vision_EqualizeHist.Click += new System.EventHandler(this.mnu_Vision_EqualizeHist_Click);
            // 
            // mnu_Vision_Normalize
            // 
            this.mnu_Vision_Normalize.Name = "mnu_Vision_Normalize";
            this.mnu_Vision_Normalize.Size = new System.Drawing.Size(136, 22);
            this.mnu_Vision_Normalize.Text = "归一化";
            this.mnu_Vision_Normalize.Click += new System.EventHandler(this.mnu_Vision_Normalize_Click);
            // 
            // mnu_Vision_Blur
            // 
            this.mnu_Vision_Blur.Name = "mnu_Vision_Blur";
            this.mnu_Vision_Blur.Size = new System.Drawing.Size(136, 22);
            this.mnu_Vision_Blur.Text = "滤波";
            this.mnu_Vision_Blur.Click += new System.EventHandler(this.mnu_Vision_Blur_Click);
            // 
            // mnu_Vision_Reverse
            // 
            this.mnu_Vision_Reverse.Name = "mnu_Vision_Reverse";
            this.mnu_Vision_Reverse.Size = new System.Drawing.Size(136, 22);
            this.mnu_Vision_Reverse.Text = "反相";
            this.mnu_Vision_Reverse.Click += new System.EventHandler(this.mnu_Vision_Reverse_Click);
            // 
            // 几何变换ToolStripMenuItem
            // 
            this.几何变换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_Affine});
            this.几何变换ToolStripMenuItem.Name = "几何变换ToolStripMenuItem";
            this.几何变换ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.几何变换ToolStripMenuItem.Text = "图像变换";
            // 
            // 图像分割ToolStripMenuItem
            // 
            this.图像分割ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_Segmentation_Theshold});
            this.图像分割ToolStripMenuItem.Name = "图像分割ToolStripMenuItem";
            this.图像分割ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.图像分割ToolStripMenuItem.Text = "图像分割";
            // 
            // mnu_Vision_Segmentation_Theshold
            // 
            this.mnu_Vision_Segmentation_Theshold.Name = "mnu_Vision_Segmentation_Theshold";
            this.mnu_Vision_Segmentation_Theshold.Size = new System.Drawing.Size(112, 22);
            this.mnu_Vision_Segmentation_Theshold.Text = "二值化";
            this.mnu_Vision_Segmentation_Theshold.Click += new System.EventHandler(this.mnu_Vision_Segmentation_Theshold_Click);
            // 
            // 形态学ToolStripMenuItem
            // 
            this.形态学ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_Dilate,
            this.mnu_Vision_Erode,
            this.mnu_Vision_Morphology,
            this.mnu_Vision_Skeleton});
            this.形态学ToolStripMenuItem.Name = "形态学ToolStripMenuItem";
            this.形态学ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.形态学ToolStripMenuItem.Text = "形态学";
            // 
            // mnu_Vision_Dilate
            // 
            this.mnu_Vision_Dilate.Name = "mnu_Vision_Dilate";
            this.mnu_Vision_Dilate.Size = new System.Drawing.Size(160, 22);
            this.mnu_Vision_Dilate.Text = "膨胀";
            this.mnu_Vision_Dilate.Click += new System.EventHandler(this.mnu_Vision_Dilate_Click);
            // 
            // mnu_Vision_Erode
            // 
            this.mnu_Vision_Erode.Name = "mnu_Vision_Erode";
            this.mnu_Vision_Erode.Size = new System.Drawing.Size(160, 22);
            this.mnu_Vision_Erode.Text = "腐蚀";
            this.mnu_Vision_Erode.Click += new System.EventHandler(this.mnu_Vision_Erode_Click);
            // 
            // mnu_Vision_Morphology
            // 
            this.mnu_Vision_Morphology.Name = "mnu_Vision_Morphology";
            this.mnu_Vision_Morphology.Size = new System.Drawing.Size(160, 22);
            this.mnu_Vision_Morphology.Text = "通用形态学操作";
            this.mnu_Vision_Morphology.Click += new System.EventHandler(this.mnu_Vision_Morphology_Click);
            // 
            // mnu_Vision_Skeleton
            // 
            this.mnu_Vision_Skeleton.Name = "mnu_Vision_Skeleton";
            this.mnu_Vision_Skeleton.Size = new System.Drawing.Size(160, 22);
            this.mnu_Vision_Skeleton.Text = "骨骼化";
            this.mnu_Vision_Skeleton.Click += new System.EventHandler(this.mnu_Vision_Skeleton_Click);
            // 
            // 边缘提取ToolStripMenuItem
            // 
            this.边缘提取ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_Canny,
            this.mnu_Vision_Contour});
            this.边缘提取ToolStripMenuItem.Name = "边缘提取ToolStripMenuItem";
            this.边缘提取ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.边缘提取ToolStripMenuItem.Text = "边缘提取";
            // 
            // mnu_Vision_Canny
            // 
            this.mnu_Vision_Canny.Name = "mnu_Vision_Canny";
            this.mnu_Vision_Canny.Size = new System.Drawing.Size(124, 22);
            this.mnu_Vision_Canny.Text = "Canny";
            this.mnu_Vision_Canny.Click += new System.EventHandler(this.mnu_Vision_Canny_Click);
            // 
            // mnu_Vision_Contour
            // 
            this.mnu_Vision_Contour.Name = "mnu_Vision_Contour";
            this.mnu_Vision_Contour.Size = new System.Drawing.Size(124, 22);
            this.mnu_Vision_Contour.Text = "轮廓检测";
            this.mnu_Vision_Contour.Click += new System.EventHandler(this.mnu_Vision_Contour_Click);
            // 
            // 几何拟合ToolStripMenuItem
            // 
            this.几何拟合ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_HoughLine,
            this.mnu_Vision_HoughCircle});
            this.几何拟合ToolStripMenuItem.Name = "几何拟合ToolStripMenuItem";
            this.几何拟合ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.几何拟合ToolStripMenuItem.Text = "几何拟合";
            // 
            // mnu_Vision_HoughLine
            // 
            this.mnu_Vision_HoughLine.Name = "mnu_Vision_HoughLine";
            this.mnu_Vision_HoughLine.Size = new System.Drawing.Size(100, 22);
            this.mnu_Vision_HoughLine.Text = "直线";
            this.mnu_Vision_HoughLine.Click += new System.EventHandler(this.mnu_Vision_HoughLine_Click);
            // 
            // mnu_Vision_HoughCircle
            // 
            this.mnu_Vision_HoughCircle.Name = "mnu_Vision_HoughCircle";
            this.mnu_Vision_HoughCircle.Size = new System.Drawing.Size(100, 22);
            this.mnu_Vision_HoughCircle.Text = "圆";
            this.mnu_Vision_HoughCircle.Click += new System.EventHandler(this.mnu_Vision_HoughCircle_Click);
            // 
            // mnu_Vision_Match
            // 
            this.mnu_Vision_Match.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Vision_MatchTemplate,
            this.mnu_Match_Shapes});
            this.mnu_Vision_Match.Name = "mnu_Vision_Match";
            this.mnu_Vision_Match.Size = new System.Drawing.Size(180, 22);
            this.mnu_Vision_Match.Text = "模板匹配";
            // 
            // mnu_Vision_MatchTemplate
            // 
            this.mnu_Vision_MatchTemplate.Name = "mnu_Vision_MatchTemplate";
            this.mnu_Vision_MatchTemplate.Size = new System.Drawing.Size(124, 22);
            this.mnu_Vision_MatchTemplate.Text = "模板匹配";
            this.mnu_Vision_MatchTemplate.Click += new System.EventHandler(this.mnu_Vision_MatchTemplate_Click);
            // 
            // mnu_Match_Shapes
            // 
            this.mnu_Match_Shapes.Name = "mnu_Match_Shapes";
            this.mnu_Match_Shapes.Size = new System.Drawing.Size(124, 22);
            this.mnu_Match_Shapes.Text = "形状匹配";
            // 
            // mnu_Vision_OCR
            // 
            this.mnu_Vision_OCR.Name = "mnu_Vision_OCR";
            this.mnu_Vision_OCR.Size = new System.Drawing.Size(180, 22);
            this.mnu_Vision_OCR.Text = "字符识别";
            // 
            // mnu_txtCursorValue
            // 
            this.mnu_txtCursorValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.mnu_txtCursorValue.Name = "mnu_txtCursorValue";
            this.mnu_txtCursorValue.Size = new System.Drawing.Size(100, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panelImage);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 716);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listOverlay);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstProperties);
            this.splitContainer2.Size = new System.Drawing.Size(202, 716);
            this.splitContainer2.SplitterDistance = 588;
            this.splitContainer2.TabIndex = 0;
            // 
            // listOverlay
            // 
            this.listOverlay.CheckBoxes = true;
            this.listOverlay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSN,
            this.colType,
            this.colData});
            this.listOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOverlay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOverlay.HideSelection = false;
            this.listOverlay.Location = new System.Drawing.Point(0, 0);
            this.listOverlay.Name = "listOverlay";
            this.listOverlay.Size = new System.Drawing.Size(202, 588);
            this.listOverlay.TabIndex = 0;
            this.listOverlay.UseCompatibleStateImageBehavior = false;
            this.listOverlay.View = System.Windows.Forms.View.Details;
            this.listOverlay.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listOverlay_ItemChecked);
            // 
            // colSN
            // 
            this.colSN.Text = "序号";
            this.colSN.Width = 38;
            // 
            // colType
            // 
            this.colType.Text = "类型";
            // 
            // colData
            // 
            this.colData.Text = "数据";
            this.colData.Width = 86;
            // 
            // lstProperties
            // 
            this.lstProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propName,
            this.propValue});
            this.lstProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProperties.HideSelection = false;
            this.lstProperties.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lstProperties.Location = new System.Drawing.Point(0, 0);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(202, 124);
            this.lstProperties.TabIndex = 0;
            this.lstProperties.UseCompatibleStateImageBehavior = false;
            this.lstProperties.View = System.Windows.Forms.View.Details;
            // 
            // propName
            // 
            this.propName.Text = "名称";
            // 
            // propValue
            // 
            this.propValue.Text = "内容";
            this.propValue.Width = 119;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureMain);
            this.panelImage.Location = new System.Drawing.Point(78, 97);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(805, 523);
            this.panelImage.TabIndex = 0;
            this.panelImage.SizeChanged += new System.EventHandler(this.panelImage_SizeChanged);
            // 
            // pictureMain
            // 
            this.pictureMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureMain.Location = new System.Drawing.Point(0, 0);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(805, 523);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMain.TabIndex = 1;
            this.pictureMain.TabStop = false;
            this.pictureMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureMain_Paint);
            this.pictureMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseClick);
            this.pictureMain.MouseLeave += new System.EventHandler(this.pictureMain_MouseLeave);
            this.pictureMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseMove);
            this.pictureMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseUp);
            // 
            // mnu_Vision_Affine
            // 
            this.mnu_Vision_Affine.Name = "mnu_Vision_Affine";
            this.mnu_Vision_Affine.Size = new System.Drawing.Size(180, 22);
            this.mnu_Vision_Affine.Text = "仿射变换";
            this.mnu_Vision_Affine.Click += new System.EventHandler(this.mnu_Vision_Affine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 743);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "图像处理工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lstProperties;
        private System.Windows.Forms.ColumnHeader propName;
        private System.Windows.Forms.ColumnHeader propValue;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_View_Entire;
        private System.Windows.Forms.ToolStripMenuItem mnu_View_Origin;
        private System.Windows.Forms.ToolStripMenuItem mnu_View_ZoomIn;
        private System.Windows.Forms.ToolStripMenuItem mnu_View_ZoonOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu_History;
        private System.Windows.Forms.ToolStripMenuItem 视觉算法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像增强ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 几何变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像分割ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 形态学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 边缘提取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 几何拟合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Match;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_OCR;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_EqualizeHist;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Segmentation_Theshold;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_OpenColor;
        private System.Windows.Forms.ToolStripMenuItem mnu_Edit_Rollback;
        private System.Windows.Forms.ToolStripMenuItem mnu_Edit_ClearSelect;
        private System.Windows.Forms.ToolStripMenuItem mnu_Edit_SaveROI;
        private System.Windows.Forms.ToolStripTextBox mnu_txtCursorValue;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Normalize;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Blur;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Dilate;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Erode;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Morphology;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Skeleton;
        private System.Windows.Forms.ListView listOverlay;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Canny;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_HoughLine;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_HoughCircle;
        private System.Windows.Forms.ColumnHeader colSN;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Contour;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_MatchTemplate;
        private System.Windows.Forms.ToolStripMenuItem mnu_Match_Shapes;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Reverse;
        private System.Windows.Forms.ToolStripMenuItem mnu_Vision_Affine;
        internal System.Windows.Forms.PictureBox pictureMain;
    }
}

