using OpenCvSharp;
using QGR.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// method: enum Method
    /// Method.Blur
    ///     ksize: Size
    ///     anchor: Point
    ///     borderType: BorderTypes
    /// Method.Bilateral
    ///     d: int
    ///     sigmacolor: double
    ///     sigmaspace: double
    ///     borderType: BorderTypes
    /// Method.Gaussian
    ///     ksize: Size
    ///     sigmax: double
    ///     sigmay: double
    ///     borderType: BorderTypes
    /// Method.Median
    ///     ksize: int
    /// </summary>
    public class VP_Blur : VisionTestCase
    {
        Size ksize;
        int m_ksize;
        Point anchor;
        int d;
        double sigmacolor;
        double sigmaspace;
        double sigmax;
        double sigmay;
        BorderTypes borderType;
        public enum Method
        {
            Blur,
            Bilateral,
            Gaussian,
            Median
        }
        public VP_Blur():base()
        {
            TestName = "blur";
        }
        public override bool run()
        {
            try
            {
                switch((Method)getValue("method"))
                {
                    case Method.Blur:
                        ksize = (Size)getValue("ksize");
                        anchor = (Point)getValue("anchor");
                        borderType = (BorderTypes)getValue("borderType");
                        dst = src.Blur(ksize, anchor, borderType);
                        break;
                    case Method.Bilateral:
                        d = (int)getValue("d");
                        sigmacolor = (double)getValue("sigmacolor");
                        sigmaspace = (double)getValue("sigmaspace");
                        borderType = (BorderTypes)getValue("borderType");
                        dst = src.BilateralFilter(d, sigmacolor, sigmaspace, borderType);
                        break;
                    case Method.Gaussian:
                        ksize = (Size)getValue("ksize");
                        sigmax = (double)getValue("sigmax");
                        sigmay = (double)getValue("sigmay");
                        borderType = (BorderTypes)getValue("borderType");
                        dst = src.GaussianBlur(ksize, sigmax, sigmay, borderType);
                        break;
                    case Method.Median:
                        m_ksize = (int)getValue("ksize");
                        dst = src.MedianBlur(m_ksize);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
