using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessor
{
    /// <summary>
    /// matrix: double[3][3]
    /// </summary>
    public class VP_TransformAffine : VisionTestCase
    {
        public double[,] matrix;
        public VP_TransformAffine():base()
        {
            TestName = "affinetransform";
            matrix = new double[2,3] { { 1, 0, 0 }, { 0, 1, 0 } };
        }
        public void setMatrix(Point2f[] src, Point2f[] dst)
        {
            Mat m = Cv2.GetAffineTransform(src, dst);
            for(int row = 0;row<2;row++)
                for(int col = 0;col<3;col++)
                {
                    matrix[row, col] = m.Get<double>(row, col);
                }
        }
        public void setMatrix(Point2f center, double angle, double scale)
        {
            Mat m = Cv2.GetRotationMatrix2D(center, angle, scale);
            for(int row = 0;row<2;row++)
                for(int col = 0;col<3;col++)
                {
                    matrix[row, col] = m.Get<double>(row, col);
                }
        }
        public void setMatrix(Mat m)
        {
            for(int row = 0;row<2;row++)
                for(int col = 0;col<3;col++)
                {
                    matrix[row, col] = m.Get<double>(row, col);
                }
        }
        /// <summary>
        /// 根据仿射矩阵评估图像的变形情况
        /// </summary>
        /// <param name="affineMatrix">格式为CV_64FC1的row=2,col=3矩阵，可通过仿射矩阵计算函数GetRotationMatrix2D()或GetAffineTransform()得到</param>
        /// <param name="XMove">X方向平移距离</param>
        /// <param name="YMove">Y方向平移距离</param>
        /// <param name="scaleX">X方向缩放系数</param>
        /// <param name="scaleY">Y方向缩放系数</param>
        /// <param name="rotateAngle">图像旋转角度</param>
        /// <param name="shearAngle">图像剪切变形角度</param>

        public void evaluateMatrix(Mat affineMatrix, out double moveX, out double moveY, out double scaleX, out double scaleY, out double rotateAngle, out double shearAngle)
        {
            double[,] mat = new double[2, 3];
            for (int row = 0; row < 2; row++)
                for (int col = 0; col < 3; col++)
                {
                    mat[row, col] = affineMatrix.Get<double>(row, col);
                }
            moveX = mat[0, 2];
            moveY = mat[1, 2];
            scaleX = mat[0, 0];
            scaleY = mat[1, 1];
            double a1 = Math.Atan2(mat[0, 1], mat[0, 0]);
            double a2 = Math.Atan2(mat[1, 0], mat[1, 1]);
            rotateAngle = (a1 - a2) / 2;
            shearAngle = Math.Abs(a1 + a2) ;
        }
        public override bool run()
        {
            InputArray m = InputArray.Create<double>(matrix, MatType.CV_64FC1);
            double d1, d2, d3, d4, d5, d6;
            evaluateMatrix(m.GetMat(), out d1, out d2, out d3, out d4, out d5, out d6);
            dst = src.WarpAffine(m, src.Size(), InterpolationFlags.Lanczos4, BorderTypes.Constant);
            return true;
        }
    }
}
