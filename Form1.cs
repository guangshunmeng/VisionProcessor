using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OpenCvSharp;
using QGR.Utility;

namespace VisionProcessor
{
    public partial class Form1 : Form
    {
        Pen roiPen;
        Dictionary<int, object> overlayShapes;
        Pen[] shapeColors;
        public Form1()
        {
            QGR.Utility.Splash.Show();
            InitializeComponent();
            roiPen = new Pen(Color.White);
            roiPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            overlayShapes = new Dictionary<int, object>();
            shapeColors = new Pen[] {
                // main color
                Pens.Yellow,   Pens.LightGreen,Pens.Blue, Pens.Red, Pens.Cyan, Pens.Pink, Pens.LightBlue,    Pens.Orange,
                // 2nd level Pens
                Pens.Green, Pens.Purple, Pens.Lime,Pens.Navy, Pens.Tomato,Pens.Violet,Pens.Brown,Pens.LightCyan, Pens.Wheat,
                Pens.Gold,Pens.Aqua,Pens.GreenYellow,Pens.Magenta,Pens.Coral,Pens.Olive,Pens.Ivory,
                // colors else
                Pens.AliceBlue, Pens.AntiqueWhite,  Pens.Aquamarine,   Pens.Azure,   Pens.Beige,
                Pens.Bisque,   Pens.BlanchedAlmond,   Pens.BlueViolet,       Pens.BurlyWood,
                Pens.CadetBlue,Pens.Chartreuse,   Pens.Chocolate,    Pens.CornflowerBlue,
                Pens.Cornsilk, Pens.Crimson,  Pens.DarkBlue, Pens.DarkCyan, Pens.DarkGoldenrod,
                Pens.DarkGray, Pens.DarkGreen,Pens.DarkKhaki,Pens.DarkMagenta,Pens.DarkOliveGreen,Pens.DarkOrange,
                Pens.DarkOrchid,Pens.DarkRed,Pens.DarkSalmon,Pens.DarkSeaGreen,Pens.DarkSlateBlue,
                Pens.DarkSlateGray,Pens.DarkTurquoise,Pens.DarkViolet,Pens.DeepPink,Pens.DeepSkyBlue,Pens.DimGray,
                Pens.DodgerBlue,Pens.Firebrick,Pens.FloralWhite,Pens.ForestGreen,Pens.Fuchsia,
                Pens.Gainsboro,Pens.GhostWhite,Pens.Goldenrod,
                Pens.Honeydew,Pens.HotPink,Pens.IndianRed,Pens.Indigo,Pens.Khaki,Pens.Lavender,
                Pens.LavenderBlush,Pens.LawnGreen,Pens.LemonChiffon,Pens.LightCoral,
                Pens.LightGoldenrodYellow,Pens.LightGray,Pens.LightPink,Pens.LightSalmon,
                Pens.LightSeaGreen,Pens.LightSkyBlue,Pens.LightSlateGray,Pens.LightSteelBlue,Pens.LightYellow,
                Pens.LimeGreen,Pens.Linen,Pens.Maroon,Pens.MediumAquamarine,
                Pens.MediumBlue,Pens.MediumOrchid,Pens.MediumPurple,Pens.MediumSeaGreen,Pens.MediumSlateBlue,
                Pens.MediumSpringGreen,Pens.MediumTurquoise,Pens.MediumVioletRed,Pens.MidnightBlue,Pens.MintCream,
                Pens.MistyRose,Pens.Moccasin,Pens.NavajoWhite,Pens.OldLace,Pens.OliveDrab,
                Pens.OrangeRed,Pens.Orchid,Pens.PaleGoldenrod,Pens.PaleGreen,Pens.PaleTurquoise,
                Pens.PaleVioletRed,Pens.PapayaWhip,Pens.PeachPuff,Pens.Peru,Pens.Plum,Pens.PowderBlue,
                Pens.RosyBrown,Pens.RoyalBlue,Pens.SaddleBrown,Pens.Salmon,Pens.SandyBrown,
                Pens.SeaGreen,Pens.SeaShell,Pens.Sienna,Pens.Silver,Pens.SkyBlue,Pens.SlateBlue,Pens.SlateGray,
                Pens.Snow,Pens.SpringGreen,Pens.SteelBlue,Pens.Tan,Pens.Teal,Pens.Thistle,
                Pens.Turquoise,Pens.WhiteSmoke,Pens.YellowGreen
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            QGR.Utility.Splash.Destroy();
        }
        private void pictureMain_Paint(object sender, PaintEventArgs e)
        {
            if(scale>0)
                e.Graphics.ScaleTransform(1/(float)scale, 1/(float)scale);
            // overlay shapes
            foreach (ListViewItem it in listOverlay.CheckedItems)
            {
                int sn = int.Parse(it.Text);
                object o = overlayShapes[sn];
                switch(o.GetType().Name)
                {
                    case "LineSegmentPoint":
                        LineSegmentPoint line = (LineSegmentPoint)o;
                        e.Graphics.DrawLine(shapeColors[sn % shapeColors.Length], line.P1.X, line.P1.Y, line.P2.X,line.P2.Y);
                        break;
                    case "CircleSegment":
                        CircleSegment circle = (CircleSegment)o;
                        e.Graphics.DrawEllipse(
                            shapeColors[sn % shapeColors.Length],
                            circle.Center.X - circle.Radius,
                            circle.Center.Y - circle.Radius,
                            circle.Radius * 2,
                            circle.Radius * 2);
                        break;
                    case "Point[]":
                        // polygon contour
                        System.Drawing.Point[] pts = (System.Drawing.Point[])o;
                        if(pts.Length>2)
                            e.Graphics.DrawPolygon(shapeColors[sn % shapeColors.Length], (System.Drawing.Point[])o);
                        break;
                    case "Rectangle":
                        e.Graphics.DrawRectangle(shapeColors[sn % shapeColors.Length], (Rectangle)o);
                        break;
                    default:
                        break;
                }
            }
            // ROI display
            if (selectROI.X >= 0 || selectROI.Y >= 0 || selectROI.Width > 0 || selectROI.Height > 0)
            {
                e.Graphics.DrawRectangle(roiPen, selectROI.X, selectROI.Y, selectROI.Width, selectROI.Height);
            }
        }
        private void listOverlay_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            pictureMain.Invalidate();
        }
        private void clearOverlay()
        {
            overlayShapes.Clear();
            refreshOverlayListview();
            pictureMain.Invalidate();
        }
        private void refreshOverlayListview()
        {
            listOverlay.Items.Clear();
            foreach(int key in overlayShapes.Keys)
            {
                ListViewItem it = listOverlay.Items.Add(key.ToString());
                it.Checked = true;
                it.BackColor = shapeColors[key % shapeColors.Length].Color;
                object o = overlayShapes[key];
                switch(o.GetType().Name)
                {
                    case "LineSegmentPoint":
                        it.SubItems.Add("直线");
                        LineSegmentPoint line = (LineSegmentPoint)o;
                        it.SubItems.Add(line.P1.DistanceTo(line.P2).ToString("0.00"));
                        break;
                    case "CircleSegment":
                        it.SubItems.Add("圆");
                        CircleSegment circle = (CircleSegment)o;
                        it.SubItems.Add(circle.Radius.ToString("0"));
                        break;
                    case "Point[]":
                        it.SubItems.Add("轮廓");
                        it.SubItems.Add("");
                        break;
                    case "Rectangle":
                        it.SubItems.Add("矩形");
                        it.SubItems.Add("");
                        break;
                    default:
                        break;
                }
            }
        }
        #region File Operation
        private void mnu_File_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mnu_File_Open_Click(object sender, EventArgs e)
        {
            openFile(true);
        }
        private void mnu_File_OpenColor_Click(object sender, EventArgs e)
        {
            openFile(false);
        }
        private void openFile(bool bGray)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "请指定一个图像文件",
                Filter = "图像文件（*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StaticObj.LoadFile(dlg.FileName, bGray);
                clearROI();
                clearOverlay();
                refreshImage(true);
            }
        }
        public void refreshImage(bool bReset = false)
        { 
            pictureMain.Image = StaticObj.getBitmap();
            if (bReset)
            {
                if (mnu_View_Entire.Checked)
                {
                    setViewEntire();
                }
                else
                {
                    setViewOrigin(new System.Drawing.Point(
                        0,
                        0
                        ));
                }
                lstProperties.Items[0].SubItems[1].Text = StaticObj.mainPic.Type().ToString();
                lstProperties.Items[1].SubItems[1].Text = StaticObj.mainPic.Width.ToString();
                lstProperties.Items[2].SubItems[1].Text = StaticObj.mainPic.Height.ToString();
            }
        }
        #endregion
        #region View Operation
        double scale;
        private void mnu_View_Entire_Click(object sender, EventArgs e)
        {
            setViewEntire();
        }
        private void setViewEntire()
        {
            double r = (double)splitContainer1.Panel2.ClientSize.Width/splitContainer1.Panel2.ClientSize.Height;
            double r0 = (double)StaticObj.mainPic.Width / StaticObj.mainPic.Height;
            if(r0>r)
            {
                panelImage.Width = splitContainer1.Panel2.ClientSize.Width;
                panelImage.Height = (int)(splitContainer1.Panel2.ClientSize.Width / r0);

            }
            else
            {
                panelImage.Height = splitContainer1.Panel2.ClientSize.Height;
                panelImage.Width = (int)(splitContainer1.Panel2.ClientSize.Height * r0);

            }
            panelImage.Left = 0;
            panelImage.Top = 0;
            mnu_View_Entire.Checked = true;
            updateScale();
        }
        private void mnu_View_Origin_Click(object sender, EventArgs e)
        {
            setViewOrigin(new System.Drawing.Point(panelImage.Width / 2, panelImage.Height / 2));
        }
        /// <summary>
        /// center is the point of the image to move to center of the view
        /// </summary>
        /// <param name="center"></param>
        private void setViewOrigin(System.Drawing.Point UpLeft)
        {
            panelImage.Height = StaticObj.mainPic.Height;
            panelImage.Width = StaticObj.mainPic.Width;
            panelImage.Left = -splitContainer1.Panel2.HorizontalScroll.Value;
            panelImage.Top = -splitContainer1.Panel2.VerticalScroll.Value;
            if (panelImage.Width > splitContainer1.Panel2.Width)
            {
                splitContainer1.Panel2.HorizontalScroll.Value = UpLeft.X;
            }
            else
            {
                panelImage.Left =  - UpLeft.X;
            }
            if (panelImage.Height > splitContainer1.Panel2.Height)
            {
                splitContainer1.Panel2.VerticalScroll.Value = UpLeft.Y;
            }
            else
            {
                panelImage.Top =  - UpLeft.Y;
            }
            mnu_View_Entire.Checked = false;
            updateScale();
        }
        private void mnu_View_ZoomIn_Click(object sender, EventArgs e)
        {
            mnu_View_Entire.Checked = false;
            panelImage.Width += panelImage.Width / 10;
            panelImage.Height += panelImage.Height / 10;
            updateScale();
        }
        private void mnu_View_ZoonOut_Click(object sender, EventArgs e)
        {
            mnu_View_Entire.Checked = false;
            panelImage.Height -= panelImage.Height / 10;
            panelImage.Width -= panelImage.Width / 10;
            updateScale();
        }
        private void panelImage_SizeChanged(object sender, EventArgs e)
        {
            pictureMain.Invalidate();
        }
        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if(mnu_View_Entire.Checked)
                setViewEntire();
        }
        private void updateScale()
        {
            scale = (double)StaticObj.mainPic.Width / panelImage.Width;
            selectROI.X = (int)(Math.Min(start.X, end.X)/scale);
            selectROI.Y = (int)(Math.Min(start.Y, end.Y)/scale);
            selectROI.Width = (int)(Math.Abs(start.X - end.X)/scale);
            selectROI.Height = (int)(Math.Abs(start.Y - end.Y)/scale);
            pictureMain.Invalidate();
        }
        #endregion
        #region ROI
        System.Drawing.Point start, end;
        Rectangle selectROI;
        bool bSelect;

        private void pictureMain_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!bSelect)
                    {
                        start = new System.Drawing.Point((int)(e.Location.X * scale), (int)(e.Location.Y * scale));
                        bSelect = true;
                    }
                    else
                    {
                        bSelect = false;
                    }
                    break;
                case MouseButtons.Right:
                    if (bSelect)
                    {
                        selectROI.Width = 0;
                        bSelect = false;
                    }
                    break;
                default:
                    break;
            }
        }
        private void pictureMain_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)(e.X * scale);
            int y = (int)(e.Y * scale);
            if (!StaticObj.mainPic.Empty())
            {
                Byte c = StaticObj.mainPic.Get<Byte>(y, x);
                mnu_txtCursorValue.Text = String.Format("{0},{1} - ({2})", x, y, c.ToString());
            }
            else
            {
                mnu_txtCursorValue.Text = "";
            }
            if (bSelect)
            {
                end = new System.Drawing.Point((int)(e.Location.X * scale), (int)(e.Location.Y*scale));
                updateScale();
                //selectROI.X = (int)(Math.Min(start.X, end.X)/scale);
                //selectROI.Y = (int)(Math.Min(start.Y, end.Y)/scale);
                //selectROI.Width = (int)(Math.Abs(start.X - end.X)/scale);
                //selectROI.Height = (int)(Math.Abs(start.Y - end.Y)/scale);
            }
        }
        private void pictureMain_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void pictureMain_MouseLeave(object sender, EventArgs e)
        {
//            bSelect = false;
        }
        private void mnu_Edit_ClearSelect_Click(object sender, EventArgs e)
        {
            clearROI();
        }
        public void clearROI()
        {
            end = start;
            bSelect = false;
            updateScale();
        }
        #endregion
        #region Edit
        private void mnu_Edit_Rollback_Click(object sender, EventArgs e)
        {
            Rollback();
        }
        public void Rollback()
        {
            if (StaticObj.HistoryLenth > 0)
            {
                StaticObj.mainPic = StaticObj.PopHistory().Value;
                refreshImage();
            }
        }
        private void mnu_History_DropDownOpening(object sender, EventArgs e)
        {
            if(StaticObj.HistoryLenth>0)
            {
                mnu_Edit_Rollback.Enabled = true;
            }
            else
            {
                mnu_Edit_Rollback.Enabled = false;
            }
            if(selectROI.Width>0)
            {
                mnu_Edit_SaveROI.Enabled = true;
            }
            else
            {
                mnu_Edit_SaveROI.Enabled = false;
            }
        }
        private void mnu_Edit_SaveROI_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog()
            {
                Title = "请指定一个图像文件",
                Filter = "BMP文件（*.bmp)|*.bmp|PNG文件(*.png)|*.png|JPG文件(*.jpg)|*.jpg"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Mat s = new Mat(StaticObj.mainPic, new OpenCvSharp.Rect(
                        (int)(selectROI.X * scale),
                        (int)(selectROI.Y * scale),
                        (int)(selectROI.Width * scale),
                        (int)(selectROI.Height * scale)
                        ));
                s.ImWrite(dlg.FileName);
            }
        }
        #endregion
        #region Utility
        private System.Drawing.Point[] convertPointArray(OpenCvSharp.Point[] src)
        {
            System.Drawing.Point[] res = new System.Drawing.Point[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                res[i].X = src[i].X;
                res[i].Y = src[i].Y;
            }
            return res;
        }

        private OpenCvSharp.Point[] convertPointArray(System.Drawing.Point[] src)
        {
            OpenCvSharp.Point[] res = new OpenCvSharp.Point[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                res[i].X = src[i].X;
                res[i].Y = src[i].Y;
            }
            return res;
        }
        #endregion
        #region Vision
        private bool GetGrayscale(bool bConfirm=true)
        {
            bool ret = true;
            if (StaticObj.mainPic.Type() != MatType.CV_8UC1)
            {
                if (!bConfirm || MessageBox.Show("图像不是灰度图像，是否要转成灰度图像继续？", "图像转换确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StaticObj.PushHistory("grayscale");
                    StaticObj.mainPic = StaticObj.mainPic.CvtColor(ColorConversionCodes.RGB2GRAY);
                }
                else
                    ret =  false;
            }
            return ret;
        }
        private bool GetBinary()
        {
            bool ret = false;
            if (StaticObj.mainPic.Type() != MatType.CV_8UC1)
            {
                if (MessageBox.Show("图像不是灰度图像，是否要转成灰度图像继续？", "图像转换确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GetGrayscale(false);
                    ret = true;
                }
                else
                    return false;
            }
            // tell if it's binary
            bool isBinary = true;
            for(int row = 0; row<StaticObj.mainPic.Rows; row++)
                for(int col = 0;col<StaticObj.mainPic.Cols;col++)
                {
                    byte b = StaticObj.mainPic.Get<byte>(row, col);
                    if (b > 0 && b < 255)
                    {
                        isBinary = false;
                        break;
                    }
                }
            if (!isBinary && !ret)
            {
                if (MessageBox.Show("图像有多个灰度，是否要转成二值化图像继续？", "图像转换确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mat t = StaticObj.mainPic.Threshold(128, 255, ThresholdTypes.Otsu);
                    StaticObj.PushHistory("threshold");
                    StaticObj.mainPic = t;
                    ret = true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private bool runVisionCommand(DialogBase dlg, bool requireGrayscale)
        {
            try
            {
                if (requireGrayscale && !GetGrayscale()) return false;
                Mat s;
                if (selectROI.Width > 0)
                {
                    s = new Mat(StaticObj.mainPic, new OpenCvSharp.Rect(
                        (int)(selectROI.X * scale),
                        (int)(selectROI.Y * scale),
                        (int)(selectROI.Width * scale),
                        (int)(selectROI.Height * scale)
                        ));
                }
                else
                    s = StaticObj.mainPic;
                dlg.setSourceMat(s);
                    StaticObj.PushHistory(dlg.Text);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Mat d = dlg.getDestMat();
                    if (d != null)
                        d.CopyTo(s);
                    refreshImage();
                    return true;
                }
                else
                {
                    Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                SysLog.Error(ex.Message, ex);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool runVisionCommand(VisionTestCase testcase, bool requireGrayscale)
        {
            Mat s;
            try
            {
                if (requireGrayscale && !GetGrayscale()) return false ;
                if (selectROI.Width > 0)
                {
                    s = new Mat(StaticObj.mainPic, new OpenCvSharp.Rect(
                        (int)(selectROI.X * scale),
                        (int)(selectROI.Y * scale),
                        (int)(selectROI.Width * scale),
                        (int)(selectROI.Height * scale)
                        ));
                }
                else
                    s = StaticObj.mainPic;
                testcase.src = s;
                StaticObj.PushHistory(testcase.TestName);
                if (testcase.run())
                {
                    testcase.dst.CopyTo(s);
                    refreshImage();
                    return true;
                }
                else
                {
                    Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                SysLog.Error(ex.Message, ex);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void mnu_Vision_Segmentation_Theshold_Click(object sender, EventArgs e)
        {
            runVisionCommand(new dlgThreshold(), true);
        }
        private void mnu_Vision_Blur_Click(object sender, EventArgs e)
        {
            runVisionCommand(new dlgBlur(), false);
        }
        private void mnu_Vision_EqualizeHist_Click(object sender, EventArgs e)
        {
            runVisionCommand(new VP_EqualizeHist(), true);
        }
        private void mnu_Vision_Normalize_Click(object sender, EventArgs e)
        {
            runVisionCommand(new dlgNormalize(), true);
        }
        private void mnu_Vision_Dilate_Click(object sender, EventArgs e)
        {
            dlgMorphology dlg = new dlgMorphology();
            dlg.setMethod(MorphTypes.Dilate);
            runVisionCommand(dlg, false);
        }
        private void mnu_Vision_Erode_Click(object sender, EventArgs e)
        {
            dlgMorphology dlg = new dlgMorphology();
            dlg.setMethod(MorphTypes.Erode);
            runVisionCommand(dlg, false);
        }
        private void mnu_Vision_Morphology_Click(object sender, EventArgs e)
        {
            runVisionCommand(new dlgMorphology(), false);
        }
        private void mnu_Vision_Skeleton_Click(object sender, EventArgs e)
        {
            runVisionCommand(new VP_Skeleton(), true);
        }
        private void mnu_Vision_Canny_Click(object sender, EventArgs e)
        {
            runVisionCommand(new dlgCanny(), true);
        }
        private void mnu_Vision_HoughLine_Click(object sender, EventArgs e)
        {
            if (!GetBinary()) return;
            dlgHoughLine dlg = new dlgHoughLine();
            runVisionCommand(dlg, false);
            LineSegmentPoint[] res = dlg.getLines();
            overlayShapes.Clear();
            if (res!=null && res.Length>0)
            {
                for(int i = 0;i<res.Length;i++)
                {
                    LineSegmentPoint l = res[i];
                    overlayShapes[i] = l;
                }
            }
            refreshOverlayListview();
        }
        private void mnu_Vision_Contour_Click(object sender, EventArgs e)
        {
            if (!GetBinary()) return;
            dlgContour dlg = new dlgContour();
            runVisionCommand(dlg, false);
            OpenCvSharp.Point[][] res = dlg.getContours();
            HierarchyIndex[] hierarchies = dlg.getHierarchy();
            overlayShapes.Clear();
            if (res!=null && res.Length>0)
            {
                for(int i = 0;i<res.Length;i++)
                {
                    OpenCvSharp.Point[] l = res[i];
                    overlayShapes[i] = convertPointArray(l);
                }
            }
            refreshOverlayListview();
            foreach(ListViewItem it in listOverlay.Items)
            {
                it.SubItems[2].Text = hierarchies[int.Parse(it.Text)].Parent.ToString();
            }
        }
        private void mnu_Vision_HoughCircle_Click(object sender, EventArgs e)
        {
            dlgHoughCircle dlg = new dlgHoughCircle();
            runVisionCommand(dlg, true);
            CircleSegment[] res = dlg.getCircles();
            overlayShapes.Clear();
            if (res!=null && res.Length>0)
            {
                for(int i = 0;i<res.Length;i++)
                {
                    CircleSegment l = res[i];
                    overlayShapes[i] = l;
                }
            }
            refreshOverlayListview();
        }
        private void mnu_Vision_Reverse_Click(object sender, EventArgs e)
        {
            runVisionCommand(new VP_Reverse(), false);
        }

        private void mnu_Vision_Affine_Click(object sender, EventArgs e)
        {
            dlgAffineTransform dlg = new dlgAffineTransform();
            dlg.parent = this;
            runVisionCommand(dlg, false);
        }

        private void mnu_Vision_MatchTemplate_Click(object sender, EventArgs e)
        {
            Rect res;
            dlgMatchTemplate dlg = new dlgMatchTemplate();
            if (runVisionCommand(dlg, true))
            {
                overlayShapes.Clear();
                double v = dlg.getResult(out res);
                overlayShapes[0] = new Rectangle(res.X, res.Y, res.Width, res.Height);
                refreshOverlayListview();
                listOverlay.Items[0].SubItems[2].Text = v.ToString("0.000");
            }
        }

        #endregion
    }
}