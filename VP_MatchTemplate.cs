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
        public double Angle;
        public VP_MatchTemplate() : base()
        {
            TestName = "matchtemplate";
        }
        public override bool run()
        {
            Point minLoc, maxLoc;
            double minVal, maxVal;
            Angle = 0;
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
        public bool runRotate(double start, double end, double inteval)
        {
            Point minLoc, maxLoc;
            double minVal, maxVal;
            templ = (Mat)getValue("templ");
            mode = (TemplateMatchModes)getValue("mode");
            bool bFirst = true;
            for(double angle = start; angle < end; angle +=inteval)
            {
                Mat result=new Mat();
                // rotate the template and mask Mat
                Mat r = Cv2.GetRotationMatrix2D(new Point2f(templ.Width / 2, templ.Height / 2), angle, 1.0);
                Mat t = templ.WarpAffine(r, templ.Size());
                Mat mask = new Mat(templ.Size(), MatType.CV_8UC1, new Scalar(255)).WarpAffine(r, templ.Size(), InterpolationFlags.Linear, BorderTypes.Constant);

                //Cv2.ImShow("match", src);Cv2.WaitKey();
                //Cv2.ImShow("match", t); Cv2.WaitKey();
                //Cv2.ImShow("match", mask); Cv2.WaitKey();

                Cv2.MatchTemplate(src, t, result, mode, null);
                result.MinMaxLoc(out minLoc, out maxLoc);
                result.MinMaxLoc(out minVal, out maxVal);
                switch (mode)
                {
                    case TemplateMatchModes.CCoeff:
                    case TemplateMatchModes.CCoeffNormed:
                    case TemplateMatchModes.CCorr:
                    case TemplateMatchModes.CCorrNormed:
                        if(bFirst || Val < maxVal)
                        {
                            Loc = maxLoc;
                            Val = maxVal;
                            Angle = angle;
                            bFirst = false;
                        }
                        break;
                    case TemplateMatchModes.SqDiff:
                    case TemplateMatchModes.SqDiffNormed:
                        if (bFirst || Val > minVal)
                        {
                            Val = minVal;
                            Loc = minLoc;
                            Angle = angle;
                            bFirst = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            return true;
        }
    }
}
