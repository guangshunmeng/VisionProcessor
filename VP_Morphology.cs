using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using QGR.Utility;

namespace VisionProcessor
{
    /// <summary>
    /// method: MorphTypes
    /// shape: MorphShapes
    /// ksize: Size
    /// anchor: Point
    /// iterations: int
    /// borderType: BorderTypes
    /// </summary>
    public class VP_Morphology:VisionTestCase
    {
        public MorphTypes method;
        public MorphShapes shape;
        public Size ksize;
        public Point anchor;
        public int iterations;
        public BorderTypes borderType;
        public VP_Morphology():base()
        {
            TestName = "morphology";
        }
        public override bool run()
        {
            try
            {
                method = (MorphTypes)getValue("method");
                shape = (MorphShapes)getValue("shape");
                ksize = (Size)getValue("ksize");
                anchor = (Point)getValue("anchor");
                iterations = (int)getValue("iterations");
                borderType = (BorderTypes)getValue("borderType");
                Mat element = Cv2.GetStructuringElement(shape, ksize);
                switch (method)
                {
                    case MorphTypes.Dilate:
                        dst = src.Dilate(element, anchor, iterations, borderType, null);
                        break;
                    case MorphTypes.Erode:
                        dst = src.Erode(element, anchor, iterations, borderType, null);
                        break;
                    default:
                        dst = src.MorphologyEx(method, element, anchor, iterations, borderType, null);
                        break;
                }
                TestName = method.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
