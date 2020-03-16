using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    class VP_Skeleton:VisionTestCase
    {
        public VP_Skeleton():base()
        {
            TestName = "skeleton";
        }
        public override bool run()
        {
            Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, new Size(3, 3));
            Mat skel = Mat.Zeros(src.Size(), MatType.CV_8UC1);
            Mat erode = Mat.Zeros(src.Size(), MatType.CV_8UC1);
            Mat temp = Mat.Zeros(src.Size(), MatType.CV_8UC1);

            int i = 0;
            Mat im = src.Clone();
            int noneZero;
            do
            {
                noneZero = im.CountNonZero();
                erode = im.Erode(element);
                temp = erode.Dilate(element);
                Cv2.Subtract(im, temp, temp);
                Cv2.BitwiseOr(skel, temp, skel);
                erode.CopyTo(im);
                //                Cv2.ImShow("erode", erode); Cv2.WaitKey();
                i += 1;
            } while (im.CountNonZero() > 0 && im.CountNonZero() != noneZero);
            dst = skel;
            return true;
        }
    }
}
