using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace VisionProcessor
{
    class VP_Denoise : VisionTestCase
    {
        float h;
        float hColor;
        int templateWindowSize;
        int searchWindowSize;
        public VP_Denoise() : base()
        {
            TestName = "去噪";
        }
        public override bool run()
        {
            Mat res = new Mat();
            h = (float)getValue("h");
            hColor = (float)getValue("hColor");
            templateWindowSize = (int)getValue("templateWindowSize");
            searchWindowSize = (int)getValue("templateWindowSize");
            switch (src.Channels())
            {
                case 1:
                    Cv2.FastNlMeansDenoising(src, res, h, templateWindowSize, searchWindowSize);
                    break;
                case 3:
                    Cv2.FastNlMeansDenoisingColored(src, res, h, hColor, templateWindowSize, searchWindowSize);
                    break;
                default:
                    break;
            }
            dst = res;
            return true;
        }
    }
}
