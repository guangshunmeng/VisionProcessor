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
    public partial class dlgAffineTransform : DialogBase
    {
        public Form1 parent;
        public dlgAffineTransform()
        {
            InitializeComponent();
            testcase = new VP_TransformAffine();
            parent = null;
        }
         
        private void dlgAffineTransform_Load(object sender, EventArgs e)
        {
            VP_TransformAffine affine = (VP_TransformAffine)testcase;
            txt_0_0.Text = affine.matrix[0, 0].ToString("0.0000");               
            txt_0_1.Text = affine.matrix[0, 1].ToString("0.0000");               
            txt_0_2.Text = affine.matrix[0, 2].ToString("0.0000");               
            txt_1_0.Text = affine.matrix[1, 0].ToString("0.0000");               
            txt_1_1.Text = affine.matrix[1, 1].ToString("0.0000");               
            txt_1_2.Text = affine.matrix[1, 2].ToString("0.0000");               
            //txt_2_0.Text = affine.matrix[2, 0].ToString("0.0000");               
            //txt_2_1.Text = affine.matrix[2, 1].ToString("0.0000");               
            //txt_2_2.Text = affine.matrix[2, 2].ToString("0.0000");

        }
        public override void runTest()
        {
            VP_TransformAffine affine = (VP_TransformAffine)testcase;
            affine.matrix[0, 0] = double.Parse(txt_0_0.Text);
            affine.matrix[0, 1] = double.Parse(txt_0_1.Text);
            affine.matrix[0, 2] = double.Parse(txt_0_2.Text);
            affine.matrix[1, 0] = double.Parse(txt_1_0.Text);
            affine.matrix[1, 1] = double.Parse(txt_1_1.Text);
            affine.matrix[1, 2] = double.Parse(txt_1_2.Text);
            //affine.matrix[2, 0] = double.Parse(txt_2_0.Text);
            //affine.matrix[2, 1] = double.Parse(txt_2_1.Text);
            //affine.matrix[2, 2] = double.Parse(txt_2_2.Text);
            testcase.run();
            btnCancel.DialogResult = DialogResult.OK;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            runTest();
            if(parent!=null)
            {
                testcase.dst.CopyTo(testcase.src);
                parent.refreshImage();
            }
        }

    }
}
