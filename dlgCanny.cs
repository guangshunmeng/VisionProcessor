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
    public partial class dlgCanny : DialogBase
    {
        public VP_Canny Canny;
        public dlgCanny()
        {
            InitializeComponent();
            Canny = new VP_Canny();
            testcase = Canny;
        }
        private void dlgCanny_Load(object sender, EventArgs e)
        {
            txtThreshold1.Text = "128";
            txtThreshold2.Text = "64";
            txtApertureSize.Text = "3";
            chkL2gradient.Checked = true;
        }
        public override void runTest()
        {
            Canny.setValue("threshold1", double.Parse(txtThreshold1.Text));
            Canny.setValue("threshold2", double.Parse(txtThreshold2.Text));
            Canny.setValue("apertureSize", int.Parse(txtApertureSize.Text));
            Canny.setValue("l2gradient", chkL2gradient.Checked);
            Canny.run();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            runTest();
        }
    }
}
