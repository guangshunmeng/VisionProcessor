using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// method: enum Method
    ///     SHT,
    ///     MHT,
    ///     PPHT
    /// rho: double, Distance resolution of the accumulator in pixels
    /// theta: theta, Angle resolution of the accumulator in radians
    /// threshold: int, The accumulator threshold parameter.Only those lines are returned that get enough votes ( > threshold )
    /// minLineLength: double, The minimum line length.Line segments shorter than that will be rejected. [By default this is 0]
    /// maxLineGap: double, The maximum allowed gap between points on the same line to link them. [By default this is 0]
    /// </summary>
    public class VP_HoughLine:VisionTestCase
    {
        double rho;
        double theta;
        int threshold;
        double srn;
        double stn;
        double minLineLength;
        double maxLineGap;
        public LineSegmentPoint[] result;
        public enum Method { SHT, MHT, PPHT};
        Method method;
        public VP_HoughLine():base()
        {
            TestName = "houghline";
            result = null;
        }
        public override bool run()
        {
            try
            {
                method = (Method)getValue("method");
                rho = (double)getValue("rho");
                theta = (double)getValue("theta");
                threshold = (int)getValue("threshold");
                switch(method)
                {
                    case Method.SHT:
                        LineSegmentPolar[] polars = src.HoughLines(rho, theta, threshold, 0, 0);
                        result = new LineSegmentPoint[polars.Length];
                        for(int i = 0;i< polars.Length;i++)
                        {
                            LineSegmentPolar p = polars[i];
                            result[i] = p.ToSegmentPoint(src.Width);
                        }
                        break;
                    case Method.MHT:
                        srn = (double)getValue("srn");
                        stn = (double)getValue("stn");
                        LineSegmentPolar[] m_polars = src.HoughLines(rho, theta, threshold, srn, stn);
                        result = new LineSegmentPoint[m_polars.Length];
                        for(int i = 0;i< m_polars.Length;i++)
                        {
                            LineSegmentPolar p = m_polars[i];
                            result[i] = p.ToSegmentPoint(1.0);
                        }
                        break;
                    case Method.PPHT:
                        minLineLength = (double)getValue("minLineLength");
                        maxLineGap = (double)getValue("maxLineGap");
                        result = src.HoughLinesP(rho, theta, threshold, minLineLength, maxLineGap);
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
