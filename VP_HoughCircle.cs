using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// dp: double, The inverse ratio of the accumulator resolution to the image resolution.
    /// minDist: double, Minimum distance between the centers of the detected circles.
    /// param1: double, The first method-specific parameter. [By default this is 100]
    /// param2: double, The second method-specific parameter. [By default this is 100]
    /// minRadius: int, Minimum circle radius. [By default this is 0]
    /// maxRadius: int, Maximum circle radius. [By default this is 0]
    /// </summary>
    class VP_HoughCircle :VisionTestCase
    {
        double dp;
        double minDist;
        double param1;
        double param2;
        int minRadius;
        int maxRadius;
        public CircleSegment[] circles;
        public VP_HoughCircle():base()
        {
            TestName = "houghcircle";
            circles = null;
        }
        public override bool run()
        {
            dp = (double)getValue("dp");
            minDist = (double)getValue("minDist");
            param1 = (double)getValue("param1");
            param2 = (double)getValue("param2");
            minRadius = (int)getValue("minRadius");
            maxRadius = (int)getValue("maxRadius");
            circles = src.HoughCircles(OpenCvSharp.HoughMethods.Gradient, dp, minDist, param1, param2, minRadius, maxRadius);
            return true;
        }
    }
}
