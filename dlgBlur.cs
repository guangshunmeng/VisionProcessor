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
    public partial class dlgBlur : DialogBase
    {
        public dlgBlur()
        {
            InitializeComponent();
            testcase = new VP_Blur();
        }

        private void dlgBlur_Load(object sender, EventArgs e)
        {
            int idx = 0;
            foreach (String n in Enum.GetNames(typeof(BorderTypes)))
            {
                int v = listBorderTypes.Items.Add(n);
                if (n == "Default")
                    idx = v;
                listBBorderTypes.Items.Add(n);
                listGBorderTypes.Items.Add(n);
            }
            listBorderTypes.SelectedIndex = idx;
            txtKSize_Width.Text = "7";
            txtKSize_Height.Text = "7";
            txtAnchor_X.Text = "-1";
            txtAnchor_Y.Text = "-1";

            listBBorderTypes.SelectedIndex = idx;
            txtB_d.Text = "9";
            txtB_SigmaColor.Text = "30";
            txtB_SigmaSpace.Text = "50";
            
            listGBorderTypes.SelectedIndex = idx;
            txtGKSize_Width.Text = "7";
            txtGKSize_Height.Text = "7";
            txtGSigmaX.Text = "0";
            txtGSigmaY.Text = "0";

            txtMKSize.Text = "7";
        }
        public override void runTest()
        {
            switch(tab_Blur.SelectedTab.Text)
            {
                case "均值":
                    testcase.setValue("method", VP_Blur.Method.Blur);
                    testcase.setValue("ksize", new OpenCvSharp.Size(
                        int.Parse(txtKSize_Width.Text),
                        int.Parse(txtKSize_Height.Text)));
                    testcase.setValue("anchor", new OpenCvSharp.Point(
                        int.Parse(txtAnchor_X.Text),
                        int.Parse(txtAnchor_Y.Text)));
                    testcase.setValue("borderType", (BorderTypes)Enum.Parse(typeof(BorderTypes),listBorderTypes.SelectedItem.ToString()));
                    break;
                case "双边":
                    testcase.setValue("method", VP_Blur.Method.Bilateral);
                    testcase.setValue("d", int.Parse(txtB_d.Text));
                    testcase.setValue("sigmacolor", double.Parse(txtB_SigmaColor.Text));
                    testcase.setValue("sigmaspace", double.Parse(txtB_SigmaSpace.Text));
                    testcase.setValue("borderType", (BorderTypes)Enum.Parse(typeof(BorderTypes),listBBorderTypes.SelectedItem.ToString()));
                    break;
                case "高斯":
                    testcase.setValue("method", VP_Blur.Method.Gaussian);
                    testcase.setValue("ksize", new OpenCvSharp.Size(
                        int.Parse(txtGKSize_Width.Text),
                        int.Parse(txtGKSize_Height.Text)));
                    testcase.setValue("sigmax", double.Parse(txtGSigmaX.Text));
                    testcase.setValue("sigmay", double.Parse(txtGSigmaY.Text));
                    testcase.setValue("borderType", (BorderTypes)Enum.Parse(typeof(BorderTypes),listGBorderTypes.SelectedItem.ToString()));
                    break;
                case "中值":
                    testcase.setValue("method", VP_Blur.Method.Median);
                    testcase.setValue("ksize", int.Parse(txtMKSize.Text));
                    break;
                default:
                    break;
            }
            testcase.run();
        }
    }
}
