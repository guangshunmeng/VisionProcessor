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
    public partial class dlgMatchShape : DialogBase
    {
        Mat temp;
        double result;
        public dlgMatchShape()
        {
            InitializeComponent();
        }

        private void dlgMatchShape_Load(object sender, EventArgs e)
        {
            int idx = 0;
            foreach (String m in Enum.GetNames(typeof(ShapeMatchModes)))
            {
                int v = listMode.Items.Add(m);
                if (m == "I1")
                    idx = v;
            }
            listMode.SelectedIndex = idx;
        }
        public override void runTest()
        {
            //result = Cv2.MatchShapes()
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
    }
}
