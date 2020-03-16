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
    public partial class dlgHoughCircle : DialogBase
    {
        public dlgHoughCircle()
        {
            InitializeComponent();
            testcase = new VP_HoughCircle();
        }
        private void dlgHoughCircle_Load(object sender, EventArgs e)
        {
            txtDp.Text = "2";
            txtMinDist.Text = "1";
            txtParam1.Text = "100";
            txtParam2.Text = "100";
            txtMinRadius.Text = "0";
            txtMaxRadius.Text = "0";
        }
        public override void runTest()
        {
            testcase.setValue("dp", double.Parse(txtDp.Text));
            testcase.setValue("minDist", double.Parse(txtMinDist.Text));
            testcase.setValue("param1", double.Parse(txtParam1.Text));
            testcase.setValue("param2", double.Parse(txtParam2.Text));
            testcase.setValue("minRadius", int.Parse(txtMinRadius.Text));
            testcase.setValue("maxRadius", int.Parse(txtMaxRadius.Text));
            testcase.run();
        }
        public CircleSegment[] getCircles()
        {
            VP_HoughCircle houghCircle = (VP_HoughCircle)testcase;
            return houghCircle.circles;
        }
    }
}
