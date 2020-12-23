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
    public partial class ForceSignMonitor : CCSkinMain
    {
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
        bool OpenLight;

        //电磁阀关闭故障
        bool CloseLight;

        //报警复位
        bool WarnState;
        //电源控制开关PLC地址
        string PowerOnOffPlcAdrStr = "DB2.DBX0.0";
        //自动手动
        string ManualAutoPlcAdrStr = "DB2.DBX0.2";
        //急停
        string QuickStopPlcAdrStr = "DB2.DBX1.2";
        //光幕
        string ScreenOKPlcAdrStr = "DB2.DBX1.3";
        //进气气压
        string GasOKPlcAdrStr = "DB2.DBX6.0";
        //电磁阀打开故障
        string OpenLightPlcAdrStr = "DB2.DBX7.1";
        //电磁阀关闭故障
        string CloseLightPlcAdrStr = "DB2.DBX7.3";
        //报警复位
        string WarnStatePlcAdrStr = "DB2.DBX6.1";

        int ioRefreshDelayTime = 1000;

        string CurrentCulture;

        public ForceSignMonitor()
        {
            InitializeComponent();
        }
        public ForceSignMonitor(string PowerOnOffPlcAdrStr, string ManualAutoPlcAdrStr, string QuickStopPlcAdrStr
            , string ScreenOKPlcAdrStr, string GasOKPlcAdrStr, string OpenLightPlcAdrStr, string CloseLightPlcAdrStr, 
            string WarnStatePlcAdrStr, string CurrentCulture)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.PowerOnOffPlcAdrStr = PowerOnOffPlcAdrStr;
            this.ManualAutoPlcAdrStr = ManualAutoPlcAdrStr;
            this.QuickStopPlcAdrStr = QuickStopPlcAdrStr;
            this.ScreenOKPlcAdrStr = ScreenOKPlcAdrStr;
            this.GasOKPlcAdrStr = GasOKPlcAdrStr;
            this.OpenLightPlcAdrStr = OpenLightPlcAdrStr;
            this.CloseLightPlcAdrStr = CloseLightPlcAdrStr;
            this.WarnStatePlcAdrStr = WarnStatePlcAdrStr;
            this.CurrentCulture = CurrentCulture;
            InitializeComponent();
           
        }
        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            this.Text = ResourceCulture.GetString("ForceSignMonitor_Text");
            this.pnlSignMonitor.Text = ResourceCulture.GetString("ForceSignMonitor_pnlSignMonitor_Text");
            this.lblPowerSwitch.Text = ResourceCulture.GetString("ForceSignMonitor_lblPowerSwitch_Text");
            this.lblQuickStop.Text = ResourceCulture.GetString("ForceSignMonitor_lblQuickStop_Text");
            this.lblScreem.Text = ResourceCulture.GetString("ForceSignMonitor_lblScreem_Text");
            this.lblAuto.Text = ResourceCulture.GetString("ForceSignMonitor_lblAuto_Text");
            this.lblAirPressure.Text = ResourceCulture.GetString("ForceSignMonitor_lblAirPressure_Text");
            this.lblloosenFault.Text = ResourceCulture.GetString("ForceSignMonitor_lblloosenFault_Text");
            this.lblComPressionFault.Text = ResourceCulture.GetString("ForceSignMonitor_lblComPressionFault_Text");
            this.lblWarn.Text = ResourceCulture.GetString("ForceSignMonitor_lblWarn_Text");

        }
        private void SignMonitor_Load(object sender, EventArgs e)
        {
           
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            SetResourceCulture();
            //reSet();
            //PLC初始化
            plcconn = ComBasic.SetForePLC();
            plc = new S7NetPLC(CpuType.S71200, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();

            //IO信号刷新
            ioRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["ioRefreshDelayTime"]);
            IOReadThread = new Thread(IoReadFun);
            IOReadThread.Start();
            isIoRead = true;


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
        //    btnGas_OK.ButtonColor = Color.WhiteSmoke;
        //    btnGas_OK.Label = "不正常";

        //    //电磁阀打开故障
        //    btnOpenLight.ButtonColor = Color.WhiteSmoke;
        //    btnOpenLight.Label = "不正常";

        //    //电磁阀关闭故障
        //    btnCloseLight.ButtonColor = Color.WhiteSmoke;
        //    btnCloseLight.Label = "不正常";

        //    //总报警
        //    this.btnAlarm.ButtonColor = Color.WhiteSmoke;
        //    btnAlarm.Label = "不正常";


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
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            //电源控制开关
            PowerOnOff = plc.readBoolen(PowerOnOffPlcAdrStr);
            ShowLabelOfIOState(PowerOnOff, btnPanel_PowerOnOff, PowerOnOff 
                ? ResourceCulture.GetString("10012") : ResourceCulture.GetString("10013"));
            //自动手动
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            ShowLabelOfIOState(ManualAuto, btnAuto, ManualAuto
                ? ResourceCulture.GetString("10016") : ResourceCulture.GetString("10017"));
            //急停正常
            QuickStop = plc.readBoolen(QuickStopPlcAdrStr);
            ShowLabelOfIOState(QuickStop, btnEmergency_OK, QuickStop ? 
                ResourceCulture.GetString("10012") : ResourceCulture.GetString("10013"));
            //光幕正常
            ScreenOK = plc.readBoolen(ScreenOKPlcAdrStr);
            ShowLabelOfIOState(ScreenOK, btnScreen_OK, ScreenOK ? 
                ResourceCulture.GetString("10014") : ResourceCulture.GetString("10015"));
            //进气气压正常
            gasOK = plc.readBoolen(GasOKPlcAdrStr);
            ShowLabelOfIOState(!gasOK, btnGas_OK, gasOK ? 
                ResourceCulture.GetString("10014") : ResourceCulture.GetString("10015"));
            //电磁阀打开故障
            OpenLight = plc.readBoolen(OpenLightPlcAdrStr);
            ShowLabelOfIOState(!OpenLight, btnOpenLight, OpenLight ? 
                ResourceCulture.GetString("10014") : ResourceCulture.GetString("10015"));

            //电磁阀关闭故障
            CloseLight = plc.readBoolen(CloseLightPlcAdrStr);
            ShowLabelOfIOState(!CloseLight, btnCloseLight, CloseLight ? 
                ResourceCulture.GetString("10014") : ResourceCulture.GetString("10015"));

            //报警复位
            WarnState = plc.readBoolen(WarnStatePlcAdrStr);
            ShowLabelOfIOState(!WarnState, btnAlarm, WarnState ? 
                ResourceCulture.GetString("10014") : ResourceCulture.GetString("10015"));

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
            //if (this.InvokeRequired)
            //{
            //    this.BeginInvoke(new mDelegateShowBasicSign(ShowSignBtton), btn, mColor, lbl);
            //    return;
            //}
            btn.ButtonColor = mColor;
            if (!string.IsNullOrEmpty(lbl))
            {
                btn.Label = lbl;
            }
        }

        private void ForceSignMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


    }
}
