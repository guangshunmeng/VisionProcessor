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
    public partial class DialogBase : Form
    {
        public VisionTestCase testcase;
        public double elapsedMilliseconds { get; protected set; }
        public DialogBase()
        {
            InitializeComponent();
        }
        public virtual void setSourceMat(Mat src)
        {
            testcase.src = src;
        }
        public virtual Mat getDestMat()
        {
            return testcase.dst;
        }
        public virtual void runTest()
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            runTest();
            TimeSpan ts = DateTime.Now - start;
            elapsedMilliseconds = ts.TotalMilliseconds;
        }
    }
}
