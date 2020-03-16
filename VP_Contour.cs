using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// mode: RetrievalModes, Contour retrieval mode
    /// method: ContourApproximationModes, Contour approximation method
    /// offset: Optional offset by which every contour point is shifted.
    ///     This is useful if the contours are extracted from the image ROI and then they should be analyzed in the whole image context.
    /// </summary>
    class VP_Contour :VisionTestCase
    {
        RetrievalModes mode;
        ContourApproximationModes method;
        public Point[][] contours;
        public HierarchyIndex[] hierarchies;
        Point offset;
        public VP_Contour() : base()
        {
            TestName = "findcontour";
        }
        public override bool run()
        {
            mode = (RetrievalModes)getValue("mode");
            method = (ContourApproximationModes)getValue("method");
            Cv2.FindContours(src, out contours, out hierarchies, mode, method);
            return true;
        }
    }
}
