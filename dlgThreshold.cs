using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace VisionProcessor
{
    public partial class dlgThreshold : DialogBase
    {
        public dlgThreshold()
        {
            InitializeComponent();
            testcase = new VP_Threshold();
        }
        private void dlgThreshold_Load(object sender, System.EventArgs e)
        {
            int idx = 0, aidx = 0;
            foreach(String n in Enum.GetNames(typeof(ThresholdTypes)))
            {
                int v = listTypes.Items.Add(n);
                if (n == "Binary")
                    idx = v;
                v = listATypes.Items.Add(n);
                if (n == "Mean")
                    aidx = v;
            }
            listTypes.SelectedIndex = idx;
            listATypes.SelectedIndex = aidx;
            txtTheshold.Text = "128";
            txtMaxValue.Text = "255";
            txtAMaxValue.Text = "255";
            txtABlockSize.Text = "20";
            txtAC.Text = "0";
            radAMean.Checked = true;
        }
        public override void runTest()
        {
            if (tab_TH.SelectedTab == pageTH)
            {
                testcase.setValue("method", VP_Threshold.Method.Threshold);
                testcase.setValue("threshold", double.Parse(txtTheshold.Text));
                testcase.setValue("maxvalue", double.Parse(txtMaxValue.Text));
                testcase.setValue("thresholdType", Enum.Parse(typeof(ThresholdTypes), (string)listTypes.SelectedItem));
            }
            else
            {
                testcase.setValue("method", VP_Threshold.Method.AdaptiveThreshold);
                testcase.setValue("maxvalue", double.Parse(txtAMaxValue.Text));
                if(radAMean.Checked)
                    testcase.setValue("adaptiveType", AdaptiveThresholdTypes.MeanC);
                else
                    testcase.setValue("adaptiveType", AdaptiveThresholdTypes.GaussianC);
                testcase.setValue("thresholdType", Enum.Parse(typeof(ThresholdTypes), (string)listATypes.SelectedItem));
                testcase.setValue("blocksize", int.Parse(txtABlockSize.Text));
                testcase.setValue("C", double.Parse(txtAC.Text));
            }
            testcase.run();
        }
    }
}
