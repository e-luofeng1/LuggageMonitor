using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Windows.Forms;
using NPOI.SS.Formula.Eval;
using System.Text.RegularExpressions;
using NPOI.SS.Util;
using NPOI.SS.UserModel;
using System.Xml;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace LuggageMonitor
{
  public  class PLCConn
    {

        private string ip;


        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }private short rack;

        public short Rack
        {
            get { return rack; }
            set { rack = value; }
        }
        private short slot;

        public short Slot
        {
            get { return slot; }
            set { slot = value; }
        }
    }
    public class ComBasic
    {
        public static Font GetFont(string CurrentCulture, float fontSize)
        {
            Font newFont = CurrentCulture == "zh-CN" ? new System.Drawing.Font("华文细黑", fontSize)
                : new System.Drawing.Font("Arial", fontSize);
            return newFont;
        }
        /// <summary>
        /// 设置前行李箱PLC信息
        /// </summary>
        /// <returns></returns>
        public static PLCConn SetForePLC()
        {
            PLCConn plc = new PLCConn();
            plc.Ip = ConfigurationManager.AppSettings["foreBootPlcIP"];
            plc.Rack = short.Parse(ConfigurationManager.AppSettings["foreBootRack"]);
            plc.Slot = short.Parse(ConfigurationManager.AppSettings["foreBootSolt"]);
            return plc;
        }
        /// <summary>
        /// 设置前行李箱PLC信息
        /// </summary>
        /// <returns></returns>
        public static PLCConn SetRealPLC()
        {
            PLCConn plc = new PLCConn();
            plc.Ip = ConfigurationManager.AppSettings["rearBootPlcIP"];
            plc.Rack = short.Parse(ConfigurationManager.AppSettings["rearBootRack"]);
            plc.Slot = short.Parse(ConfigurationManager.AppSettings["rearBootSolt"]);
            return plc;
        }
        public static bool ChangeConfig(string AppKey, string AppValue)
        {
            bool result = true;
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //获取App.config文件绝对路径
                String basePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                basePath = basePath.Substring(0, basePath.Length - 10);
                String path = basePath + "App.config";
                xDoc.Load(path);

                XmlNode xNode;
                XmlElement xElem1;
                XmlElement xElem2;
                //修改完文件内容，还需要修改缓存里面的配置内容，使得刚修改完即可用
                //如果不修改缓存，需要等到关闭程序，在启动，才可使用修改后的配置信息
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                xNode = xDoc.SelectSingleNode("//appSettings");
                xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
                if (xElem1 != null)
                {
                    xElem1.SetAttribute("value", AppValue);
                    cfa.AppSettings.Settings[AppKey].Value = AppValue;
                }
                else
                {
                    xElem2 = xDoc.CreateElement("add");
                    xElem2.SetAttribute("key", AppKey);
                    xElem2.SetAttribute("value", AppValue);
                    xNode.AppendChild(xElem2);
                    cfa.AppSettings.Settings.Add(AppKey, AppValue);
                }
                //改变缓存中的配置文件信息（读取出来才会是最新的配置）
                cfa.Save();
                ConfigurationManager.RefreshSection("appSettings");
                xDoc.Save(path);
            }
            catch (Exception ex)
            {
                //_log.Error("修改App.config文件出错：" + ex.Message);
                result = false;
            }
            return result;
        }
        /// <summary>
        /// 获取配置数据
        /// </summary>
        /// <returns></returns>
        public static ISheet ReadExcelSheet(string fileName, string sheetName, bool isCloumnName)
        {
            try
            {
                //string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
                //fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\Config\\" + fileName;
                return ExcelHelper.GetSheet(fileName, sheetName, isCloumnName);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string formtMes(string mes)
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + mes;
        }
        /// <summary>
        /// 删除文件夹以及文件
        /// </summary>
        /// <param name="directoryPath"> 文件夹路径 </param>
        /// <param name="fileName"> 文件名称 </param>
        public static void DeleteDirectory(string directoryPath, string fileName)
        {

            //删除文件
            for (int i = 0; i < Directory.GetFiles(directoryPath).ToList().Count; i++)
            {
                if (Directory.GetFiles(directoryPath)[i] == fileName)
                {
                    File.Delete(fileName);
                }
            }

            //删除文件夹
            for (int i = 0; i < Directory.GetDirectories(directoryPath).ToList().Count; i++)
            {
                if (Directory.GetDirectories(directoryPath)[i] == fileName)
                {
                    Directory.Delete(fileName, true);
                }
            }
        }
        /// <summary>    

        /// Creating a Watermarked Photograph with GDI+ for .NET    

        /// </summary>    

        /// <param name="rSrcImgPath">原始图片的物理路径</param>    

        /// <param name="rMarkImgPath">水印图片的物理路径</param>    

        /// <param name="rMarkText">水印文字（不显示水印文字设为空串）</param>    

        /// <param name="rDstImgPath">输出合成后的图片的物理路径</param>    

        public static void BuildWatermark(string rSrcImgPath, string rMarkImgPath, string rMarkText, string rDstImgPath)
        {

            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。    

            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。    

            Image imgPhoto = Image.FromFile(rSrcImgPath);

            int phWidth = imgPhoto.Width;

            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);
            
            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。    

            //再一次，会为它的Width 和Height定义一个变量。    

            Image imgWatermark = new Bitmap(rMarkImgPath);

            int wmWidth = imgWatermark.Width;

            int wmHeight = imgWatermark.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。    

            //以后所有的绘图都将发生在原来照片的顶部。    

            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;

            grPhoto.DrawImage(

                 imgPhoto,

                 new Rectangle(0, 0, phWidth, phHeight),

                 0,

                 0,

                 phWidth,

                 phHeight,

                 GraphicsUnit.Pixel);

            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。    

            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。    

            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本    

            int[] sizes = new int[] { 16, 14, 12, 10, 8, 6, 4 };

            Font crFont = null;

            SizeF crSize = new SizeF();

            for (int i = 0; i < 7; i++)
            {

                crFont = new Font("arial", sizes[i],

                      FontStyle.Bold);

                crSize = grPhoto.MeasureString(rMarkText,

                      crFont);

                if ((ushort)crSize.Width < (ushort)phWidth)

                    break;

            }

            //因为所有的照片都有各种各样的高度，所以就决定了从图象底部开始的5%的位置开始。    

            //使用rMarkText字符串的高度来决定绘制字符串合适的Y坐标轴。    

            //通过计算图像的中心来决定X轴，然后定义一个StringFormat 对象，设置StringAlignment 为Center。    

            int yPixlesFromBottom = (int)(phHeight * .05);

            float yPosFromBottom = ((phHeight -

                 yPixlesFromBottom) - (crSize.Height / 2));

            float xCenterOfImg = (phWidth / 2);

            StringFormat StrFormat = new StringFormat();

            StrFormat.Alignment = StringAlignment.Center;

            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。    

            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。    

            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。    

            SolidBrush semiTransBrush2 =

                 new SolidBrush(Color.FromArgb(153, 0, 0, 0));

            grPhoto.DrawString(rMarkText,

                 crFont,

                 semiTransBrush2,

                 new PointF(xCenterOfImg + 1, yPosFromBottom + 1),

                 StrFormat);

            SolidBrush semiTransBrush = new SolidBrush(

                 Color.FromArgb(153, 255, 255, 255));

            grPhoto.DrawString(rMarkText,

                 crFont,

                 semiTransBrush,

                 new PointF(xCenterOfImg, yPosFromBottom),

                 StrFormat);

            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。    

            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(

                 imgPhoto.HorizontalResolution,

                 imgPhoto.VerticalResolution);

            Graphics grWatermark =

                 Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。    

            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。    

            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。    

            ImageAttributes imageAttributes =

                 new ImageAttributes();

            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);

            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);

            ColorMap[] remapTable = { colorMap };

            //第二个颜色处理用来改变水印的不透明性。    

            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。    

            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。    

            imageAttributes.SetRemapTable(remapTable,

                 ColorAdjustType.Bitmap);

            float[][] colorMatrixElements = {     

                                             new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},    

                                             new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},    

                                             new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},    

                                             new float[] {0.0f,  0.0f,  0.0f,  0.3f, 0.0f},    

                                             new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}    

                                        };

            ColorMatrix wmColorMatrix = new

                 ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,

                 ColorMatrixFlag.Default,

                 ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。    

            //我们会偏离10像素到底部，10像素到左边。    

            int markWidth;

            int markHeight;

            //mark比原来的图宽    

            if (phWidth <= wmWidth)
            {

                markWidth = phWidth - 10;

                markHeight = (markWidth * wmHeight) / wmWidth;

            }

            else if (phHeight <= wmHeight)
            {

                markHeight = phHeight - 10;

                markWidth = (markHeight * wmWidth) / wmHeight;

            }

            else
            {

                markWidth = wmWidth;

                markHeight = wmHeight;

            }

            int xPosOfWm = ((phWidth - markWidth) - 10);

            int yPosOfWm = 10;

            grWatermark.DrawImage(imgWatermark,

                 new Rectangle(xPosOfWm, yPosOfWm, markWidth,

                 markHeight),

                 0,

                 0,

                 wmWidth,

                 wmHeight,

                 GraphicsUnit.Pixel,

                 imageAttributes);

            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。    

            imgPhoto = bmWatermark;

            grPhoto.Dispose();

            grWatermark.Dispose();

            imgPhoto.Save(rDstImgPath, ImageFormat.Jpeg);

            imgPhoto.Dispose();

            imgWatermark.Dispose();

            File.Delete(rSrcImgPath);

        }
        public static void BuildWatermark(string rSrcImgPath, string rMarkText, string rDstImgPath)
        {
            var img = Bitmap.FromFile(rSrcImgPath);
            var g = Graphics.FromImage(img);
            //设置画布平滑性
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //填充半透明三角形
            var triggleLeg = (img.Width > img.Height ? img.Height : img.Width) / 3;
            var path = new GraphicsPath();
            path.AddLine(img.Width - triggleLeg, img.Height, img.Width, img.Height - triggleLeg);
            path.AddLine(img.Width, img.Height - triggleLeg, img.Width, img.Height);
            path.AddLine(img.Width, img.Height, img.Width - triggleLeg, img.Height);

            g.FillPath(new SolidBrush(Color.FromArgb(120, Color.Black)), path);

            //将原点移动到三角形斜边的中间位置
            g.TranslateTransform(img.Width - triggleLeg / 2, img.Height - triggleLeg / 2);
            //旋转45度
            g.RotateTransform(-45);

            ////Math.Acos返回值是相对PI的值，因此需要转换为度数
            //var angle = Math.Acos(a / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) / Math.PI * 180;
            //g.RotateTransform((float)-angle);

            //绘制水印文字
            var font = new Font("Arial", 9, FontStyle.Regular);
            //string text = rMarkText;
            //测量文字长度
            var size = g.MeasureString(rMarkText, font);
            //绘制文字时，以文字长度的中间位置为中心，因此绘制的起点为：0-长度/2；并设置高度距离原点半行高
            g.DrawString(rMarkText, font,rMarkText =="OK" ? Brushes.Green:Brushes.Red, -size.Width / 2, size.Height / 2);
            size = g.MeasureString(DateTime.Now.ToString("yyyy-MM-dd"), font);
            g.DrawString(DateTime.Now.ToString("yyyy-MM-dd"), font, rMarkText == "OK" ? Brushes.Green : Brushes.Red, -size.Width / 2, size.Height * 3 / 2);

            
            img.Save(rDstImgPath, ImageFormat.Jpeg);

            img.Dispose();

          

        }

    }
}
