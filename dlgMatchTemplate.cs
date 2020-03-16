using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionProcessor
{
    public partial class dlgMatchTemplate : DialogBase
    {
        Mat temp;
        public dlgMatchTemplate()
        {
            InitializeComponent();
            testcase = new VP_MatchTemplate();
            temp = null;
        }
        private void dlgMatchTemplate_Load(object sender, EventArgs e)
        {
            int idx=0;
            foreach(String m in Enum.GetNames(typeof(TemplateMatchModes)))
            {
                int v = listMode.Items.Add(m);
                if (m == "CCorrNormed")
                    idx = v;
            }
            listMode.SelectedIndex = idx;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "请指定一个图像文件",
                Filter = "图像文件（*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = dlg.FileName;
                temp = new Mat(dlg.FileName, ImreadModes.Grayscale);
                picTempl.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(temp);
            }
        }
        public override void runTest()
        {
            testcase.setValue("templ", temp);
            testcase.setValue("mode", Enum.Parse(typeof(TemplateMatchModes), listMode.SelectedItem.ToString()));
            testcase.run();
        }
        public double getResult(out OpenCvSharp.Rect location)
        {
            VP_MatchTemplate m = (VP_MatchTemplate)testcase;
            location = new Rect(m.Loc, temp.Size());
            return m.Val;
        }
    }
}
