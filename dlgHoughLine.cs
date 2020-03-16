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
    public partial class dlgHoughLine : DialogBase
    {
        public dlgHoughLine()
        {
            InitializeComponent();
            testcase = new VP_HoughLine();
        }
        private void dlgHoughtLine_Load(object sender, EventArgs e)
        {
            listMethod.SelectedIndex = 0;
            txtRho.Text = "10";
            txtTheta.Text = "0.018";
            txtThreshold.Text = "80";
            txtSrn.Text = "0";
            txtStn.Text = "0";
            txtMinLength.Text = "0";
            txtMaxGap.Text = "0";
        }
        public override void runTest()
        {
            testcase.setValue("method", Enum.Parse(typeof(VP_HoughLine.Method), listMethod.SelectedItem.ToString()));
            testcase.setValue("rho", double.Parse(txtRho.Text));
            testcase.setValue("theta", double.Parse(txtTheta.Text));
            testcase.setValue("threshold", int.Parse(txtThreshold.Text));
            testcase.setValue("srn", double.Parse(txtSrn.Text));
            testcase.setValue("stn", double.Parse(txtStn.Text));
            testcase.setValue("minLineLength", double.Parse(txtSrn.Text));
            testcase.setValue("maxLineGap", double.Parse(txtStn.Text));
            testcase.run();
        }
        public LineSegmentPoint[] getLines()
        {
            VP_HoughLine houghLine = (VP_HoughLine)testcase;
            return houghLine.result;
        }

        private void listMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listMethod.SelectedItem.ToString())
            {
                case "SHT":
                    txtSrn.Enabled = false;
                    txtStn.Enabled = false;
                    txtMinLength.Enabled = false;
                    txtMaxGap.Enabled = false;
                    break;
                case "MHT":
                    txtSrn.Enabled = true;
                    txtStn.Enabled = true;
                    txtMinLength.Enabled = false;
                    txtMaxGap.Enabled = false;
                    break;
                case "PPHT":
                    txtSrn.Enabled = false;
                    txtStn.Enabled = false;
                    txtMinLength.Enabled = true;
                    txtMaxGap.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
