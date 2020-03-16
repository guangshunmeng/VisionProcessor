using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using QGR.Utility;

namespace VisionProcessor
{
    public class StaticObj : ModuleBase
    {
        public static Mat mainPic;
        public static String picturePath;
        public static Stack<KeyValuePair<String, Mat>> History;
        static StaticObj()
        {
            mainPic = new Mat();
            picturePath = "";
            History = new Stack<KeyValuePair<string, Mat>>();
        }
        public static void LoadFile(string filename, bool bGrayScale = true)
        {
            try
            {
                mainPic = new Mat(filename, bGrayScale ? ImreadModes.Grayscale : ImreadModes.Color);
                picturePath = filename;
            }
            catch(Exception ex)
            {
                SysLog.Error(ex.Message, ex);
            }
        }
        public static Bitmap getBitmap()
        {
            return BitmapConverter.ToBitmap(mainPic);
        }
        public static void PushHistory(String operation)
        {
            History.Push(new KeyValuePair<string, Mat>(operation, mainPic.Clone()));
        }
        public static KeyValuePair<string, Mat> PopHistory()
        {
            if (History.Count > 0)
                return History.Pop();
            else
                throw new Exception("操作历史为空");
        }
        public static int HistoryLenth { get { return History.Count; } private set { } }
        public static void clearHistory()
        {
            History.Clear();
        }
        
    }
}
