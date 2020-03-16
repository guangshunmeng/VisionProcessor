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
    /// alpha: double
    /// beta: double
    /// normType: NormTypes
    /// </summary>
    public class VP_Normalize:VisionTestCase
    {
        double alpha;
        double beta;
        NormTypes normType;
        public VP_Normalize():base()
        {
            TestName = "normalize";
        }
        public override bool run()
        {
            bool ret = false;
            try
            {
                alpha = (double)getValue("alpha");
                beta = (double)getValue("beta");
                normType = (NormTypes)getValue("normType");
                dst = src.Normalize(alpha, beta, normType, -1, null);
                ret = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
    }
}
