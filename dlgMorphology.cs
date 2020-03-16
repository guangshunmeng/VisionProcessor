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
    public partial class dlgMorphology : DialogBase
    {
        bool bMethodFreezed;
        public dlgMorphology()
        {
            InitializeComponent();
            testcase = new VP_Morphology();
            bMethodFreezed = false;
        }
        public void setMethod(MorphTypes op)
        {
            VP_Morphology Morphology = (VP_Morphology)testcase;
            Morphology.method = op;
            bMethodFreezed = true;
        }
        private void dlgMorphology_Load(object sender, EventArgs e)
        {
            int idx = 0;
            if (bMethodFreezed)
            {
                VP_Morphology Morphology = (VP_Morphology)testcase;
                listOP.Items.Add(Enum.GetName(typeof(MorphTypes), Morphology.method));
                listOP.Enabled = false;
            }
            else
            {
                foreach (String n in Enum.GetNames(typeof(MorphTypes)))
                {
                    int v = listOP.Items.Add(n);
                    if (n == "Open")
                        idx = v;
                }
            }
            listOP.SelectedIndex = idx;
            foreach (String n in Enum.GetNames(typeof(MorphShapes)))
            {
                int v = listMorphShape.Items.Add(n);
                if (n == "Rect")
                    idx = v;
            }
            listMorphShape.SelectedIndex = idx;
            foreach (String n in Enum.GetNames(typeof(BorderTypes)))
            {
                int v = listBorderType.Items.Add(n);
                if (n == "Constant")
                    idx = v;
            }
            listBorderType.SelectedIndex = idx;
            txtKSize_Width.Text = "3";
            txtKSize_Height.Text = "3";
            txtAnchor_X.Text = "-1";
            txtAnchor_Y.Text = "-1";
            txtIteration.Text = "1";
        }
        public override void runTest()
        {
            testcase.setValue("method", Enum.Parse(typeof(MorphTypes), listOP.SelectedItem.ToString()));
            testcase.setValue("shape", Enum.Parse(typeof(MorphShapes), listMorphShape.SelectedItem.ToString()));
            testcase.setValue("ksize", new OpenCvSharp.Size(
                int.Parse(txtKSize_Width.Text),
                int.Parse(txtKSize_Height.Text)));
            testcase.setValue("anchor", new OpenCvSharp.Point(
                int.Parse(txtAnchor_X.Text),
                int.Parse(txtAnchor_Y.Text)));
            testcase.setValue("iterations", int.Parse(txtIteration.Text));
            testcase.setValue("borderType", (BorderTypes)Enum.Parse(typeof(BorderTypes), listBorderType.SelectedItem.ToString()));
            testcase.run();
        }
    }
}
