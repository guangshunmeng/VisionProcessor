using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QGR.Utility;

namespace VisionProcessor
{
    /// <summary>
    /// parameters:
    /// method: Threshold 常规二值化
    ///         AdaptiveThreshold 局部二值化
    /// threshold
    /// maxvalue
    /// blocksize
    /// C
    /// thresholdType
    /// adaptiveType
    /// </summary>
    public class VP_Threshold : VisionTestCase
    {
        // threshold parameters
        double threshold;
        double maxvalue;
        ThresholdTypes thresholdType;
        // adaptive threshold parameters
        AdaptiveThresholdTypes adaptiveType;
        int blocksize;
        double C;
        public enum Method
            { Threshold = 0, AdaptiveThreshold = 1}
        public VP_Threshold():base()
        {
            TestName = "threshold";
        }
        public override bool run()
        {
            object v;
            bool ret;
            try
            {
                v = getValue("method");
                switch ((Method)v)
                {
                    case Method.Threshold:
                        threshold = (double)getValue("threshold");
                        maxvalue = (double)getValue("maxvalue");
                        thresholdType = (ThresholdTypes)getValue("thresholdType");
                        dst = src.Threshold(threshold, maxvalue, thresholdType);
                        break;
                    case Method.AdaptiveThreshold:
                        maxvalue = (double)getValue("maxvalue");
                        adaptiveType = (AdaptiveThresholdTypes)getValue("adaptiveType");
                        thresholdType = (ThresholdTypes)getValue("thresholdType");
                        blocksize = (int)getValue("blocksize");
                        if (blocksize % 2 == 0)
                            blocksize++;
                        C = (double)getValue("C");
                        dst = src.AdaptiveThreshold(maxvalue, adaptiveType, thresholdType, blocksize, C);
                        break;
                    default:
                        break;
                }
                ret = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
