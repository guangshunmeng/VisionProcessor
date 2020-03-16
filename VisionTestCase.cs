using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using QGR.Utility;

namespace VisionProcessor
{
    public class VisionTestCase : TestCase
    {
        public Mat src { get; set; }
        public Mat dst { get; protected set; }
        public VisionTestCase():base()
        {
            TestName = "visiontestbase";
        }
    }
}
