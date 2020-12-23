using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCWin;
using S7.Net;
using LBSoft.IndustrialCtrls.Buttons;
using System.Threading;
using System.Configuration;

namespace LuggageMonitor
{
    public partial class RealSignMonitor :CCSkinMain
    {
        //PLC连接信息
        //PLC连接信息
        PLCConn plcconn;
        S7NetPLC plc;
        //电源控制开关
        bool PowerOnOff;
        //自动手动
        bool ManualAuto;
        //急停
        bool QuickStop;
        //光幕正常
        bool ScreenOK;

        //进气气压
        bool gasOK;

        //电磁阀打开故障
        bool OpenLight1;
        //电磁阀关闭故障
        bool CloseLight1;

        //电磁阀打开故障
        bool OpenLight2;
        //电磁阀关闭故障
        bool CloseLight2;
        //报警复位
        bool WarnState;

        //是否可以拍照
        bool isCanCremea;


        //垫片信号
        bool ForceGasket1, ForceGasket2, ForceGasket3, ForceGasket4, ForceGasket5, ForceGasket6, ForceGasket7, ForceGasket8, ForceGasket9,
            Cylinder1, Cylinder2, Cylinder3, Cylinder4, Cylinder5, Cylinder6;
        //电源控制开关PLC地址
        string PowerOnOffPlcAdrStr;
        //自动手动
        string ManualAutoPlcAdrStr;

        //急停
        string QuickStopPlcAdrStr;


        //光幕
        string ScreenOKPlcAdrStr;
        //进气气压
        string GasOKPlcAdrStr;
        //电磁阀1打开故障
        string OpenLightPlcAdrStr1;
        //电磁阀1关闭故障
        string CloseLightPlcAdrStr1;

        //电磁阀2打开故障
        string OpenLightPlcAdrStr2;
        //电磁阀2关闭故障
        string CloseLightPlcAdrStr2;
        string CurrentCulture = "";
        //报警复位
        string WarnStatePlcAdrStr;
        //垫片信号
        string ForceGasket1Str, ForceGasket2Str, ForceGasket3Str, ForceGasket4Str, ForceGasket5Str, ForceGasket6Str, ForceGasket7Str, ForceGasket8Str, ForceGasket9Str,
            Cylinder1Str, Cylinder2Str, Cylinder3Str, Cylinder4Str, Cylinder5Str, Cylinder6Str, CanCremeaStr, CanCremeaDoneStr;
      
        int ioRefreshDelayTime = 1000;
        public RealSignMonitor()
        {
            InitializeComponent();
        }
        public RealSignMonitor(string PowerOnOffPlcAdrStr, string ManualAutoPlcAdrStr, string QuickStopPlcAdrStr
            , string ScreenOKPlcAdrStr, string GasOKPlcAdrStr, string OpenLightPlcAdrStr1, string CloseLightPlcAdrStr1,
            string OpenLightPlcAdrStr2, string CloseLightPlcAdrStr2, string WarnStatePlcAdrStr, string Cylinder1Str,
            string Cylinder2Str, string Cylinder3Str, string Cylinder4Str, string Cylinder5Str, string Cylinder6Str, string CurrentCulture)
        {
            Cylinder1Str = "DB2.DBX2.6";
            Cylinder2Str = "DB2.DBX2.7";
            Cylinder3Str = "DB2.DBX3.0";
            Cylinder4Str = "DB2.DBX3.1";
            Cylinder5Str = "DB2.DBX3.2";
            Cylinder6Str = "DB2.DBX3.3";
            this.PowerOnOffPlcAdrStr = PowerOnOffPlcAdrStr;
            this.ManualAutoPlcAdrStr = ManualAutoPlcAdrStr;
            this.QuickStopPlcAdrStr = QuickStopPlcAdrStr;
            this.ScreenOKPlcAdrStr = ScreenOKPlcAdrStr;
            this.GasOKPlcAdrStr = GasOKPlcAdrStr;
            this.OpenLightPlcAdrStr1 = OpenLightPlcAdrStr1;
            this.CloseLightPlcAdrStr1 = CloseLightPlcAdrStr1;
            this.OpenLightPlcAdrStr2 = OpenLightPlcAdrStr2;
            this.CloseLightPlcAdrStr2 = CloseLightPlcAdrStr2;
            this.WarnStatePlcAdrStr = WarnStatePlcAdrStr;
            this.Cylinder1Str = Cylinder1Str;
            this.Cylinder2Str = Cylinder2Str;
            this.Cylinder3Str = Cylinder3Str;
            this.Cylinder4Str = Cylinder4Str;
            this.Cylinder5Str = Cylinder5Str;
            this.Cylinder6Str = Cylinder6Str;

            this.CurrentCulture = CurrentCulture;
            InitializeComponent();
        }
        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            this.Text = ResourceCulture.GetString("RealSignMonitor_Text");
            this.pnlSignMonitor.Text = ResourceCulture.GetString("RealSignMonitor_pnlSignMonitor_Text");
            this.lblPowerSwitch.Text = ResourceCulture.GetString("RealSignMonitor_lblPowerSwitch_Text");
            this.lblQuickStop.Text = ResourceCulture.GetString("RealSignMonitor_lblQuickStop_Text");
            this.lblScreem.Text = ResourceCulture.GetString("RealSignMonitor_lblScreem_Text");
            this.lblAuto.Text = ResourceCulture.GetString("RealSignMonitor_lblAuto_Text");
            this.lblAirPressure.Text = ResourceCulture.GetString("RealSignMonitor_lblAirPressure_Text");

            this.lblloosenFault1.Text = ResourceCulture.GetString("RealSignMonitor_lblloosenFault1_Text");
            this.lblComPressionFault1.Text = ResourceCulture.GetString("RealSignMonitor_lblComPressionFault1_Text");
            this.lblloosenFault2.Text = ResourceCulture.GetString("RealSignMonitor_lblloosenFault2_Text");
            this.lblComPressionFault2.Text = ResourceCulture.GetString("RealSignMonitor_lblComPressionFault2_Text");
            this.lblWarn.Text = ResourceCulture.GetString("RealSignMonitor_lblWarn_Text");

            this.lblSiwth1.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth1_Text");
            this.lblSiwth2.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth2_Text");
            this.lblSiwth3.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth3_Text");
            this.lblSiwth4.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth4_Text");
            this.lblSiwth5.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth5_Text");
            this.lblSiwth6.Text = ResourceCulture.GetString("RealSignMonitor_lblSiwth6_Text");
        }
        ///// <summary>
        ///// 重置
        ///// </summary>
        //private void reSet()
        //{
        //    //电源开关
        //    btnPanel_PowerOnOff.ButtonColor = Color.WhiteSmoke;
        //    btnPanel_PowerOnOff.Label = "关闭";


        //    //1自动，0手动
        //    btnAuto.ButtonColor = Color.WhiteSmoke;
        //    btnAuto.Label = "手动";

        //    //急停正常
        //    btnEmergency_OK.ButtonColor = Color.Lime;
        //    btnEmergency_OK.Label = "正常";


        //    //光幕正常
        //    btnScreen_OK.ButtonColor = Color.WhiteSmoke;
        //    btnScreen_OK.Label = "不正常";

        //    //进气气压正常
        //    btnGas_OK.ButtonColor = Color.Lime;
        //    btnGas_OK.Label = "正常";

        //    //电磁阀1打开故障
        //    btnOpenLight1.ButtonColor = Color.Lime;
        //    btnOpenLight1.Label = "正常";

        //    //电磁阀1关闭故障
        //    btnCloseLight1.ButtonColor = Color.Lime;
        //    btnCloseLight1.Label = "正常";

        //    //电磁阀2打开故障
        //    btnOpenLight2.ButtonColor = Color.Lime;
        //    btnOpenLight2.Label = "正常";

        //    //电磁阀2关闭故障
        //    btnCloseLight2.ButtonColor = Color.Lime;
        //    btnOpenLight2.Label = "正常";

        //    //总报警
        //    this.btnAlarm.ButtonColor = Color.Lime;
        //    btnAlarm.Label = "正常";

        //    btnCylinder1.ButtonColor = Color.WhiteSmoke;
        //    btnCylinder2.ButtonColor = Color.WhiteSmoke;
        //    btnCylinder3.ButtonColor = Color.WhiteSmoke;
        //    btnCylinder4.ButtonColor = Color.WhiteSmoke;
        //    btnCylinder5.ButtonColor = Color.WhiteSmoke;
        //    btnCylinder6.ButtonColor = Color.WhiteSmoke;

        //}

        bool isIoRead = false;
        private Thread IOReadThread = null;
        /// <summary>
        /// 
        /// </summary>
        private void IoReadFun()
        {
            while (true)
            {
                if (isIoRead)
                {
                    ReadIOSign();
                }
                Thread.Sleep(ioRefreshDelayTime);
            }

        }

        /// <summary>
        /// 读取信号
        /// </summary>
        public void ReadIOSign()
        {
            //电源控制开关
            PowerOnOff = plc.readBoolen(PowerOnOffPlcAdrStr);
            ShowLabelOfIOState(PowerOnOff, btnPanel_PowerOnOff, PowerOnOff ? "打开" : "关闭");
            //自动手动
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            ShowLabelOfIOState(ManualAuto, btnAuto, ManualAuto ? "自动" : "手动");

            //急停正常
            QuickStop = plc.readBoolen(QuickStopPlcAdrStr);
            ShowLabelOfIOState(QuickStop, btnEmergency_OK, QuickStop ? "正常" : "不正常");
            //光幕正常
            ScreenOK = plc.readBoolen(ScreenOKPlcAdrStr);
            ShowLabelOfIOState(ScreenOK, btnScreen_OK, ScreenOK ? "正常" : "不正常");
            //进气气压正常
            gasOK = plc.readBoolen(GasOKPlcAdrStr);
            ShowLabelOfIOState(!gasOK, btnGas_OK, gasOK ? "故障" : "正常");
            //电磁阀1打开故障
            OpenLight1 = plc.readBoolen(OpenLightPlcAdrStr1);
            ShowLabelOfIOState(!OpenLight1, btnOpenLight1, OpenLight1 ? "故障" : "正常");

            //电磁阀1关闭故障
            CloseLight1 = plc.readBoolen(CloseLightPlcAdrStr1);
            ShowLabelOfIOState(!CloseLight1, btnCloseLight1, CloseLight1 ? "故障" : "正常");

            //电磁阀2打开故障
            OpenLight2 = plc.readBoolen(OpenLightPlcAdrStr2);
            ShowLabelOfIOState(!OpenLight2, btnOpenLight2, OpenLight2 ? "故障" : "正常");

            //电磁阀2关闭故障
            CloseLight2 = plc.readBoolen(CloseLightPlcAdrStr2);
            ShowLabelOfIOState(!CloseLight2, btnCloseLight2, CloseLight2 ? "故障" : "正常");

            //报警复位
            WarnState = plc.readBoolen(WarnStatePlcAdrStr);
            ShowLabelOfIOState(!WarnState, btnAlarm, WarnState ? "报警" : "复位");

            Cylinder1 = plc.readBoolen(Cylinder1Str);
            ShowLabelOfIOState(Cylinder1, btnCylinder1, string.Empty);
            //txtContent.Text += "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "气缸接近开关#1:" + Cylinder1Str + "/" + Cylinder1;

            Cylinder2 = plc.readBoolen(Cylinder2Str);
            ShowLabelOfIOState(Cylinder2, btnCylinder2, string.Empty);
            // txtContent.Text += "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "气缸接近开关#2:" +Cylinder2Str+"/"+ Cylinder2;

            Cylinder3 = plc.readBoolen(Cylinder3Str);
            ShowLabelOfIOState(Cylinder3, btnCylinder3, string.Empty);

            Cylinder4 = plc.readBoolen(Cylinder4Str);
            ShowLabelOfIOState(Cylinder4, btnCylinder4, string.Empty);

            Cylinder5 = plc.readBoolen(Cylinder5Str);
            ShowLabelOfIOState(Cylinder5, btnCylinder5, string.Empty);


            Cylinder6 = plc.readBoolen(Cylinder6Str);
            ShowLabelOfIOState(Cylinder6, btnCylinder6, string.Empty);

        }

        /// <summary>
        /// 显示读取信号值
        /// </summary>
        /// <param name="Signal"></param>
        /// <param name="btn"></param>
        /// <param name="lbl"></param>
        private void ShowLabelOfIOState(bool Signal, LBButton btn, string lbl)
        {
            if (Signal)
            {
                ShowSignBtton(btn, Color.Lime, lbl);
            }
            else
            {
                ShowSignBtton(btn, Color.WhiteSmoke, lbl);
            }
        }
        private delegate void mDelegateShowBasicSign(LBButton btn, Color mColor, string lbl);
        /// <summary>
        /// 刷新信号按钮
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="mColor"></param>
        /// <param name="lbl"></param>
        private void ShowSignBtton(LBButton btn, Color mColor, string lbl)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new mDelegateShowBasicSign(ShowSignBtton), btn, mColor, lbl);
                return;
            }
            btn.ButtonColor = mColor;
            if (!string.IsNullOrEmpty(lbl))
            {
                btn.Label = lbl;
            }
        }

        private void RealSignMonitor_Load(object sender, EventArgs e)
        {
           // reSet();

            //PLC初始化
            plcconn = ComBasic.SetRealPLC();
            plc = new S7NetPLC(CpuType.S71200, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();

            //IO信号刷新
            ioRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["ioRefreshDelayTime"]);
            IOReadThread = new Thread(IoReadFun);
            IOReadThread.Start();
            isIoRead = true;
        }
    }
}
