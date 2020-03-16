using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// threshold1: double
    /// threshold2: double
    /// apertureSize: int
    /// l2gradient: bool
    /// </summary>
    public class VP_Canny : VisionTestCase
    {
        double threshold1;
        double threshold2;
        int apertureSize;
        bool l2gradient;
        public VP_Canny():base()
        {
            TestName = "canny";
        }
        public override bool run()
        {
            try
            {
                threshold1 = (double)getValue("threshold1");
                threshold2 = (double)getValue("threshold2");
                apertureSize = (int)getValue("apertureSize");
                l2gradient = (bool)getValue("l2gradient");
                dst = src.Canny(threshold1, threshold2, apertureSize, l2gradient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
