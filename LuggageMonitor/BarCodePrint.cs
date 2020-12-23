using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Trace.Common.UnicodeToZPL;
using System.Drawing;
using System.Configuration;

namespace LuggageMonitor
{
    /// <summary>
    /// 条码打印
    /// </summary>
    public class BarCodePrint
    {
        public BarCodePrint()
        {
        }
        /// <summary>
        /// 根据模板构造打印ZPL
        /// </summary>
        /// <returns></returns>
        public string PrintBarCode(string itemName, string partNo, string ZPLStart, string PrintContent, string FontName
            , float FontSize, string ZPLEnd, string PrinterName)
        {
            try
            {
                PrintContent = PrintContent.Replace("[ItemName]", itemName)
                    .Replace("[PartNo]", partNo).Replace("[DateTime]", string.Format("{0:F}", DateTime.Now));
                StringBuilder builder = AppendZPL(ZPLStart, PrintContent, FontName, FontSize, ZPLEnd);
                ZebraPrintHelper.writeFile("print.txt", builder.ToString());
                ZebraPrintHelper.SendFileToPrinter(PrinterName, "print.txt");

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return "";
        }
        /// <summary>
        /// 组织ZPL
        /// </summary>
        /// <param name="ZPLStart"></param>
        /// <param name="PrintContent"></param>
        /// <param name="FontName"></param>
        /// <param name="FontSize"></param>
        /// <param name="ZPLEnd"></param>
        /// <returns></returns>
        public StringBuilder AppendZPL(string ZPLStart, string PrintContent, string FontName, float FontSize, string ZPLEnd)
        {
            System.Text.StringBuilder builder = new StringBuilder();
            builder.AppendLine(ZPLStart);
            builder.Append(chagePrintContent(PrintContent, FontName, FontSize));
            builder.AppendLine(ZPLEnd);
            return builder;
        }

        /// <summary>
        /// 转换打印内容为图像
        /// </summary>
        /// <param name="PrintContent"></param>
        /// <param name="FontName"></param>
        /// <param name="FontSize"></param>
        /// <returns></returns>
        public string chagePrintContent(string PrintContent, string FontName, float FontSize)
        {
            try
            {
                Font font = new Font(FontName, FontSize);
                TextDirection textDirection = TextDirection.零度;
                string result = UnicodeToZPL.CompressZPL(PrintContent, "name", font, textDirection);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取打印配置数据
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintConfig(string fileName, string sheetName)
        {
            try
            {
                string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
                fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\Config\\" + fileName;
                DataTable table = ExcelHelper.ExcelToDataTable(fullName, sheetName, true);
                return table;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
