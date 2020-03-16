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
    public partial class dlgContour : DialogBase
    {
        public dlgContour()
        {
            InitializeComponent();
            testcase = new VP_Contour();
        }

        private void dlgContour_Load(object sender, EventArgs e)
        {
            int idx = 0;
            foreach(String mode in Enum.GetNames(typeof(RetrievalModes)))
            {
                int v = listMode.Items.Add(mode);
                if(mode == "Tree")
                {
                    idx = v;
                }
            }
            listMode.SelectedIndex = idx;
            foreach(String method in Enum.GetNames(typeof(ContourApproximationModes)))
            {
                int v = listMethod.Items.Add(method);
                if(method == "ApproxSimple")
                {
                    idx = v;
                }
            }
            listMethod.SelectedIndex = idx;
        }
        public override void runTest()
        {
            testcase.setValue("mode", Enum.Parse(typeof(RetrievalModes), listMode.SelectedItem.ToString()));
            testcase.setValue("method", Enum.Parse(typeof(ContourApproximationModes), listMethod.SelectedItem.ToString()));
            testcase.run();
        }
        public OpenCvSharp.Point[][] getContours()
        {
            VP_Contour contour = (VP_Contour)testcase;
            return contour.contours;
        }
        public HierarchyIndex[] getHierarchy()
        {
            VP_Contour contour = (VP_Contour)testcase;
            return contour.hierarchies;
        }
    }
}
