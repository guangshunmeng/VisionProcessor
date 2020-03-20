using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// mode : TemplateMatchModes
    /// </summary>
    public class VP_MatchTemplate : VisionTestCase
    {
        TemplateMatchModes mode;
        Mat templ;
        public Point Loc;
        public double Val;
        public VP_MatchTemplate() : base()
        {
            TestName = "matchtemplate";
        }
        public override bool run()
        {
            Point minLoc, maxLoc;
            double minVal, maxVal;
            templ = (Mat)getValue("templ");
            mode = (TemplateMatchModes)getValue("mode");
            Mat t = src.MatchTemplate(templ, mode);
            t.MinMaxLoc(out minLoc, out maxLoc);
            t.MinMaxLoc(out minVal, out maxVal);
            switch (mode)
            {
                case TemplateMatchModes.CCoeff:
                case TemplateMatchModes.CCoeffNormed:
                case TemplateMatchModes.CCorr:
                case TemplateMatchModes.CCorrNormed:
                    Loc = maxLoc;
                    Val = maxVal;
                    break;
                case TemplateMatchModes.SqDiff:
                case TemplateMatchModes.SqDiffNormed:
                    Val = minVal;
                    Loc = minLoc;
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
