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
    public partial class dlgDenoise : DialogBase
    {
        public dlgDenoise()
        {
            testcase = new VP_Denoise();
            InitializeComponent();
        }

        private void dlgDenoise_Load(object sender, EventArgs e)
        {
            txtH.Text = "3";
            txtHColor.Text = "3";
            txtTemplateWindowSize.Text = "7";
            txtSearchWindowSize.Text = "21";
        }
        public override void runTest()
        {
            testcase.setValue("h", float.Parse(txtH.Text));
            testcase.setValue("hColor", float.Parse(txtHColor.Text));
            testcase.setValue("templateWindowSize", int.Parse(txtTemplateWindowSize.Text));
            testcase.setValue("searchWindowSize", int.Parse(txtSearchWindowSize.Text));
            testcase.run();
        }
    }
}
