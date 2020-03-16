using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace VisionProcessor
{
    public partial class dlgNormalize : DialogBase
    {
        public dlgNormalize()
        {
            InitializeComponent();
            testcase = new VP_Normalize();
        }
        private void dlgNormalize_Load(object sender, EventArgs e)
        {
            int idx = 0;
            foreach (String n in Enum.GetNames(typeof(NormTypes)))
            {
                int v = listTypes.Items.Add(n);
                if (n == "MinMax")
                    idx = v;
            }
            txtAlpha.Text = "0";
            txtBeta.Text = "255";
            listTypes.SelectedIndex = idx;
        }
        public override void runTest()
        {
            testcase.setValue("alpha", double.Parse(txtAlpha.Text));
            testcase.setValue("beta", double.Parse(txtBeta.Text));
            testcase.setValue("normType", Enum.Parse(typeof(NormTypes), (string)listTypes.SelectedItem));
            testcase.run();
        }
    }
}
