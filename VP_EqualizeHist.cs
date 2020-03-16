using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    class VP_EqualizeHist:VisionTestCase
    {
        public VP_EqualizeHist():base()
        {
            TestName = "equalizehistogram";
        }
        public override bool run()
        {
            dst = src.EqualizeHist();
            return true;
        }
    }
}
