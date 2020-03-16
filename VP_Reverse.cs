using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    class VP_Reverse:VisionTestCase
    {
        public VP_Reverse():base()
        {
            TestName = "reverse";
        }
        public override bool run()
        {
            dst = new Mat(src.Size(), src.Type(), new Scalar(255,255,255));
            dst = dst - src;
            return true;
        }
    }
}
