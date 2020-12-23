using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;

using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;

namespace LuggageMonitor.TestPrint
{
    public partial class TestPrint : CCSkinMain
    {
        string printName = "";
        string configFineName = "";
        string sheetName = "";
        public TestPrint()
        {

            InitializeComponent();
            configFineName = System.Configuration.ConfigurationSettings
                                 .AppSettings["ConfigFineName"];
            sheetName = System.Configuration.ConfigurationSettings.AppSettings["ConfigSheetName"];
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            BarCodePrint print = new BarCodePrint();
            DataTable config = print.getPrintConfig(configFineName, sheetName);
            if (config != null)
            {
                //ZPL头部内容
                string ZPLStart = config.Rows[0]["ZPLStart"].ToString();
                //打印内容
                string PrintContent = config.Rows[0]["PrintContent"].ToString();
                //字体名称
                string FontName = config.Rows[0]["FontName"].ToString();
                //字体大小
                float FontSize = float.Parse(config.Rows[0]["FontSize"].ToString());
                //ZPL结束内容
                string ZPLEnd = config.Rows[0]["ZPLEnd"].ToString();
                //打印机名称
                printName = config.Rows[0]["PrintName"].ToString();
                StringBuilder builder = print.AppendZPL(ZPLStart, PrintContent, FontName, FontSize, ZPLEnd);

                txtZpl.Text = builder.ToString();
              
            }


        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            ZebraPrintHelper.SendStringToPrinter(printName, txtZpl.Text);
        }
    }
}
