using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.IO;
using S7.Net;
using System.Threading;
using System.Net;
using System.Net.Sockets;

using LBSoft.IndustrialCtrls.Buttons;
using System.Text.RegularExpressions;
using System;

namespace LuggageMonitor
{
    public partial class FrmRealBootMonitor : CCSkinMain
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
        bool OpenLight1;
        //电磁阀关闭故障
        bool CloseLight1;

        //电磁阀打开故障
        bool OpenLight2;
        //电磁阀关闭故障
        bool CloseLight2;
        //报警复位
        bool WarnState;


        //垫片信号
        bool ForceGasket1, ForceGasket2, ForceGasket3, ForceGasket4, ForceGasket5, ForceGasket6, ForceGasket7, ForceGasket8, ForceGasket9,
            Cylinder1, Cylinder2, Cylinder3, Cylinder4, Cylinder5, Cylinder6;
        ////传感器屏蔽
        //bool isValidGasket1, isValidGasket2, isValidGasket3, isValidGasket4;

        //是否可以拍照
        bool isCanCremea;
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

        //报警复位
        string WarnStatePlcAdrStr;


        //垫片信号
        string ForceGasket1Str, ForceGasket2Str, ForceGasket3Str, ForceGasket4Str, ForceGasket5Str, ForceGasket6Str, ForceGasket7Str, ForceGasket8Str, ForceGasket9Str,
            Cylinder1Str, Cylinder2Str, Cylinder3Str, Cylinder4Str, Cylinder5Str, Cylinder6Str, CanCremeaStr, CanCremeaDoneStr;
        //电磁阀打开关闭
        string openActionStr1, closeActionStr1, openActionStr2, closeActionStr2;

        string itemName = "";
        string partNo = "";
        string barCode, subBarCode = "";
        string isScanFormPart;
        string foarmPartNo = "";
        public static string CurrentCulture = ConfigurationManager.AppSettings["currentCulture"];
        //配置文件名称
        string realConfigFileName = ConfigurationManager.AppSettings["ConfigFineName"];
        //配置文件Sheet
        string realConfigSheetName = ConfigurationManager.AppSettings["ConfigRealSheetName"];
        /// <summary>
        /// PLC状态刷新时间
        /// </summary>
        int plcRefreshDelayTime = 1000;
        int ioRefreshDelayTime = 1000;
        int gasketRefreshDelayTime = 1000;
        int okCount, ngCount = 0;

        System.Threading.CancellationTokenSource cancel = new System.Threading.CancellationTokenSource();

        RefreshText txtrefre;
        string signMsg = "";
        public FrmRealBootMonitor()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            txtrefre = new RefreshText(RefreTextBox);
          
        }
        bool resfresh = true;
        /// <summary>
        /// 时间刷新
        /// </summary>
        public void refreshTime()
        {
            new System.Threading.Thread(() =>
            {
                while (resfresh)
                {
                    IntPtr i = this.Handle;
                    try { lblTime.BeginInvoke(new MethodInvoker(() => lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))); }
                    catch { }
                    System.Threading.Thread.Sleep(1000);
                }
            }) { IsBackground = true }.Start();
        }
        /// <summary>
        /// 设置国际化资源
        /// </summary>
        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            realConfigFileName = CurrentCulture == "zh-CN" ?
            ConfigurationManager.AppSettings["ConfigFineName"] : ConfigurationManager.AppSettings["ConfigFineNameUS"];
            this.Text = ResourceCulture.GetString("FrmRealBootMonitor_Text");
            lblTitle.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblTitle_Text");
            pnlBasicInfo.Text = ResourceCulture.GetString("FrmRealBootMonitor_pnlBasicInfo_Text");
            lblBarCode.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblBarCode_Text");
            lblItemName.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblItemName_Text");
            lblPartNo.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblPartNo_Text");
            chkHeart.Text = ResourceCulture.GetString("FrmRealBootMonitor_chkHeart_Text");
            pnlStep.Text = ResourceCulture.GetString("FrmRealBootMonitor_pnlStep_Text");
            gridStep.Columns["MistakeType"].HeaderText
                = ResourceCulture.GetString("FrmRealBootMonitor_grid_MistakeType_HeaderText");
            gridStep.Columns["Explain"].HeaderText
                = ResourceCulture.GetString("FrmRealBootMonitor_grid_Explain_HeaderText");
            gridStep.Columns["Result"].HeaderText
               = ResourceCulture.GetString("FrmRealBootMonitor_grid_Result_HeaderText");
            gridStep.Columns["CurrentValue"].HeaderText
                = ResourceCulture.GetString("FrmRealBootMonitor_grid_CurrentValue_HeaderText");
            pnlCountInfo.Text = ResourceCulture.GetString("FrmRealBootMonitor_pnlCountInfo_Text");
            lblOK.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblOK_Text");
            lblNOK.Text = ResourceCulture.GetString("FrmRealBootMonitor_lblNOK_Text");
            pnlSystem.Text = ResourceCulture.GetString("FrmRealBootMonitor_pnlSystem_Text");
            pnlpicReult.Text = ResourceCulture.GetString("FrmRealBootMonitor_pnlpicReult_Text");
            btnRest.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnRest_Text");
            btnOpenLigntAction1.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnOpenLigntAction1_Text");
            btnCloseLightAction1.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnCloseLightAction1_Text");
            btnOpenLigntAction2.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnOpenLigntAction2_Text");
            btnCloseLightAction2.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnCloseLightAction2_Text");
            btnPlc.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnPlc_Text");
            btnSelectHistory.Text = ResourceCulture.GetString("FrmRealBootMonitor_btnSelect_Text");

            // workSteps = ReadStepInfo();
            refreshGrid(workSteps);
            //gridStep.DataSource = workSteps;
            //gridStep.Refresh();
        }

        public void refreshGrid(List<WorkStep> list)
        {
            this.Invoke(new Action(() =>
            {
                gridStep.DataSource = list;
                gridStep.Refresh();
                //this.ActiveControl = gridStep;

            }));
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void reSet()
        {

            txtBarCode.ReadOnly = true;

        }

        AutoSizeFormClass asc = new AutoSizeFormClass();
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRealBootMonitor_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            ReadConfig();
            ReadPrintConfig();
            workSteps = ReadStepInfo();
            refreshGrid(workSteps);
            //初始化控件
            //plc连接状态
            btnRealPLCState.ButtonColor = Color.DimGray;

            reSet();
            
            //PLC初始化
            plcconn = ComBasic.SetRealPLC();
            plc = new S7NetPLC(CpuType.S71200, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();
            plc.WriteBoolen("DB2.DBX9.7", true);
            chkPLCState_CheckedChanged(null, null);


            //相机设置
            axTcpRealClient.ServerIp = ConfigurationManager.AppSettings["realIpAddress"];
            axTcpRealClient.ServerPort = Int16.Parse(ConfigurationManager.AppSettings["realPort"]);
            axTcpRealClient.StartConnection();

            //获取PLC刷新时间
            plcRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["plcRefreshDelayTime"]);
            //PLC刷新
            plcStateRefreshThread = new Thread(plcHeartRun);
            plcStateRefreshThread.IsBackground = true;
            plcStateRefreshThread.Start();

            //IO信号刷新
            ioRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["ioRefreshDelayTime"]);
            IOReadThread = new Thread(IoReadFun);
            IOReadThread.IsBackground = true;
            IOReadThread.Start();
            isIoRead = true;

            gasketRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["gasketRefreshDelayTime"]);
            CheGasket = true;
            checkGasketSignReadThread = new Thread(CheckGasketFun);
            checkGasketSignReadThread.IsBackground = true;
            checkGasketSignReadThread.Start();

            //txtBarCode.KeyUp += txtBarCode_KeyUp;
            refreshTime();
            okCount = ngCount = 0;
            this.SetResourceCulture();
            Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10000"));
        }
        List<WorkStep> workSteps = new List<WorkStep>();
        /// <summary>
        /// 读取工步
        /// </summary>
        /// <returns></returns>
        public List<WorkStep> ReadStepInfo()
        {
            List<WorkStep> workSteps = new List<WorkStep>();
            var StepInfo = ExcelHelper.ImportExceltoDt(realConfigFileName, realConfigSheetName, 16, true);
            if (StepInfo.Rows.Count > 0)
            {
                for (int index = 0; index < StepInfo.Rows.Count; index++)
                {
                    WorkStep step = new WorkStep();
                    step.Num = StepInfo.Rows[index][0].ToString();
                    step.MistakeType = StepInfo.Rows[index][1].ToString();
                    step.Explain = StepInfo.Rows[index][0].ToString() + "." + StepInfo.Rows[index][2].ToString();
                    step.SetValue = StepInfo.Rows[index][3].ToString();
                    step.IsValid = StepInfo.Rows[index][4].ToString() == "1" ? true : false;
                    step.Result = "NG";
                    step.CurrentValue = "";
                    if (step.Num == "")
                    {
                        break;
                    }
                    else
                    {
                        workSteps.Add(step);
                    }
                }
            }
            return workSteps.Where(p => p.IsValid == true).ToList();
        }
        #region 公共方法
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
        #endregion

        #region 1.初始化

        #region plc心跳刷新
        //刷新PLC信号
        bool plcrefresh = false;
        private Thread plcStateRefreshThread = null;
        /// <summary>
        /// 监测心跳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPLCState_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeart.Checked)
            {
                plcStateRefreshThread = new Thread(plcHeartRun);
                plcStateRefreshThread.Start();
                plcrefresh = true;
            }
        }
        /// <summary>
        /// PLC刷新
        /// </summary>
        private void plcHeartRun()
        {
            while (true)
            {
                try
                {
                    lblOKCount.Text = okCount.ToString();
                    lblNgCount.Text = ngCount.ToString();
                    if (plcrefresh)
                    {
                        RefreshPLCState();
                    }
                    Thread.Sleep(plcRefreshDelayTime);
                }
                catch
                { }
            }

        }
        /// <summary>
        /// plc心跳
        /// </summary>
        public void RefreshPLCState()
        {
            try
            {
                //txtContent.Text += "PLC状态:" + plc.ConectStatus;
                if (plc.ConectStatus)
                {

                    ShowSignBtton(btnRealPLCState, Color.Lime, "");
                }
                else
                {
                    ShowSignBtton(btnRealPLCState, Color.DimGray, "");
                    plc.connectPLC();
                }
            }
            catch (Exception ex)
            {
                txtrefre(ComBasic.formtMes(ex.Message));
            }
        }
        #endregion

        string ZPLStart = "";
        string PrintContent = "";
        string FontName = "";
        float FontSize;
        string PrinterName = "";
        string ZPLEnd = "";
        public void ReadPrintConfig()
        {
            try
            {
                string configFineName = ConfigurationManager
                                    .AppSettings["ConfigFineName"];
                string sheetName = ConfigurationManager.AppSettings["ConfigSheetName"];
                DataTable config = ExcelHelper.ExcelToDataTable(configFineName, sheetName, true);
                if (config != null)
                {
                    //ZPL头部内容
                    ZPLStart = config.Rows[0]["ZPLStart"].ToString();
                    //打印内容
                    PrintContent = config.Rows[0]["PrintContent"].ToString();
                    //字体名称
                    FontName = config.Rows[0]["FontName"].ToString();
                    //字体大小
                    FontSize = float.Parse(config.Rows[0]["FontSize"].ToString());
                    //ZPL结束内容
                    ZPLEnd = config.Rows[0]["ZPLEnd"].ToString();
                    //打印机名称
                    PrinterName = config.Rows[0]["PrintName"].ToString();
                }
            }
            catch { }
        }
        /// <summary>
        /// 读取EXCEL配置文件
        /// </summary>
        public void ReadConfig()
        {
            var ConfigData = ComBasic.ReadExcelSheet(realConfigFileName, realConfigSheetName, false);
            if (ConfigData != null)
            {
                //项目名称
                itemName = Convert.ToString(ConfigData.GetRow(0).GetCell(1));
                txtRealItemName.Text = itemName;
                //零件名称 
                partNo = Convert.ToString(ConfigData.GetRow(1).GetCell(1));
                txtRealPartNo.Text = partNo;
                //电源控制开关
                PowerOnOffPlcAdrStr = Convert.ToString(ConfigData.GetRow(4).GetCell(3));

                //自动手动
                ManualAutoPlcAdrStr = Convert.ToString(ConfigData.GetRow(5).GetCell(3));

                //急停
                QuickStopPlcAdrStr = Convert.ToString(ConfigData.GetRow(6).GetCell(3));

                //光幕
                ScreenOKPlcAdrStr = Convert.ToString(ConfigData.GetRow(7).GetCell(3));

                //进气气压
                GasOKPlcAdrStr = Convert.ToString(ConfigData.GetRow(8).GetCell(3));

                //电磁阀1打开故障
                OpenLightPlcAdrStr1 = Convert.ToString(ConfigData.GetRow(9).GetCell(3));

                //电磁阀1关闭故障
                CloseLightPlcAdrStr1 = Convert.ToString(ConfigData.GetRow(10).GetCell(3));

                //电磁阀1打开故障
                OpenLightPlcAdrStr2 = Convert.ToString(ConfigData.GetRow(11).GetCell(3));

                //电磁阀1关闭故障
                CloseLightPlcAdrStr2 = Convert.ToString(ConfigData.GetRow(12).GetCell(3));

                //报警复位
                WarnStatePlcAdrStr = Convert.ToString(ConfigData.GetRow(13).GetCell(3));

                //电磁阀打开关闭地址

                openActionStr1 = Convert.ToString(ConfigData.GetRow(36).GetCell(3));
                closeActionStr1 = Convert.ToString(ConfigData.GetRow(37).GetCell(3));

                openActionStr2 = Convert.ToString(ConfigData.GetRow(38).GetCell(3));
                closeActionStr2 = Convert.ToString(ConfigData.GetRow(39).GetCell(3));

                ////传感器信号
                //ForceGasket1Str = Convert.ToString(ConfigData.GetRow(17).GetCell(3));

                //ForceGasket2Str = Convert.ToString(ConfigData.GetRow(18).GetCell(3));

                //ForceGasket3Str = Convert.ToString(ConfigData.GetRow(19).GetCell(3));

                //ForceGasket4Str = Convert.ToString(ConfigData.GetRow(20).GetCell(3));

                //ForceGasket5Str = Convert.ToString(ConfigData.GetRow(21).GetCell(3));

                //ForceGasket6Str = Convert.ToString(ConfigData.GetRow(22).GetCell(3));

                //ForceGasket7Str = Convert.ToString(ConfigData.GetRow(23).GetCell(3));

                //ForceGasket8Str = Convert.ToString(ConfigData.GetRow(24).GetCell(3));

                //ForceGasket9Str = Convert.ToString(ConfigData.GetRow(25).GetCell(3));


                //Cylinder1Str = Convert.ToString(ConfigData.GetRow(26).GetCell(3));

                //Cylinder2Str = Convert.ToString(ConfigData.GetRow(27).GetCell(3));

                //Cylinder3Str = Convert.ToString(ConfigData.GetRow(28).GetCell(3));

                //Cylinder4Str = Convert.ToString(ConfigData.GetRow(29).GetCell(3));

                //Cylinder5Str = Convert.ToString(ConfigData.GetRow(30).GetCell(3));

                //Cylinder6Str = Convert.ToString(ConfigData.GetRow(31).GetCell(3));

                //CanCremeaStr = Convert.ToString(ConfigData.GetRow(35).GetCell(3));

                CanCremeaDoneStr = Convert.ToString(ConfigData.GetRow(32).GetCell(3));


                //isScanFormPart = Convert.ToString(ConfigData.GetRow(45).GetCell(2));
                //foarmPartNo = Convert.ToString(ConfigData.GetRow(45).GetCell(1));
            }
        }

        #endregion

        #region 2.IO刷新
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
            //ShowLabelOfIOState(PowerOnOff, btnPanel_PowerOnOff, PowerOnOff ? "打开" : "关闭");
            //自动手动
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            // ShowLabelOfIOState(ManualAuto, btnAuto, ManualAuto ? "自动" : "手动");
            if (ManualAuto)
            {
                btnOpenLigntAction1.Enabled = false;
                btnCloseLightAction1.Enabled = false;

                btnOpenLigntAction2.Enabled = false;
                btnCloseLightAction2.Enabled = false;
            }
            else
            {
                //if (PwdInput.CanOpreate)
                //{
                btnOpenLigntAction1.Enabled = true;
                btnCloseLightAction1.Enabled = true;

                btnOpenLigntAction2.Enabled = true;
                btnCloseLightAction2.Enabled = true;
                //}
                //else
                //{
                //    PwdInput ifrom = new PwdInput(CurrentCulture);

                //    ifrom.ShowDialog();
                //}
            }
            //急停正常
            QuickStop = plc.readBoolen(QuickStopPlcAdrStr);
            //ShowLabelOfIOState(QuickStop, btnEmergency_OK, QuickStop ? "正常" : "不正常");
            //光幕正常
            ScreenOK = plc.readBoolen(ScreenOKPlcAdrStr);
            // ShowLabelOfIOState(ScreenOK, btnScreen_OK, ScreenOK ? "正常" : "不正常");
            //进气气压正常
            gasOK = plc.readBoolen(GasOKPlcAdrStr);
            // ShowLabelOfIOState(!gasOK, btnGas_OK, gasOK ? "故障" : "正常");
            //电磁阀1打开故障
            OpenLight1 = plc.readBoolen(OpenLightPlcAdrStr1);
            //ShowLabelOfIOState(!OpenLight1, btnOpenLight1, OpenLight1 ? "故障" : "正常");

            //电磁阀1关闭故障
            CloseLight1 = plc.readBoolen(CloseLightPlcAdrStr1);
            // ShowLabelOfIOState(!CloseLight1, btnCloseLight1, CloseLight1 ? "故障" : "正常");

            //电磁阀2打开故障
            OpenLight2 = plc.readBoolen(OpenLightPlcAdrStr2);
            //ShowLabelOfIOState(!OpenLight2, btnOpenLight2, OpenLight2 ? "故障" : "正常");

            //电磁阀2关闭故障
            CloseLight2 = plc.readBoolen(CloseLightPlcAdrStr2);
            //ShowLabelOfIOState(!CloseLight2, btnCloseLight2, CloseLight2 ? "故障" : "正常");

            //报警复位
            WarnState = plc.readBoolen(WarnStatePlcAdrStr);
            //ShowLabelOfIOState(!WarnState, btnAlarm, WarnState ? "报警" : "复位");

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


        #endregion

        #region 3.检测垫片信号
        bool CheGasket = false;
        private Thread checkGasketSignReadThread = null;
        private void CheckGasketFun()
        {
            while (true)
            {
                if (CheGasket)
                {
                    ReadGasKetSign();
                }
                Thread.Sleep(gasketRefreshDelayTime);
            }
        }
        static int currentIndex = 0;
        bool isSet = false;
        string msg = "";

        /// <summary>
        /// 读取信号
        /// </summary>
        public void ReadGasKetSign()
        {
            try
            {
                if (isSet)
                {
                    currentIndex = 0;
                    BarCodeScanState = 0;
                    workSteps = ReadStepInfo();
                    isSet = false;
                }
                string fwAdr = "DB2.DBX9.6";
                bool isFw = plc.readBoolen(fwAdr);
                if (isFw)
                {
                    currentIndex = 0;
                    ResSetUI();
                }
                for (int index = currentIndex; index < workSteps.Count; index++)
                {
                    if ((workSteps[index].MistakeType == "电气防错" || workSteps[index].MistakeType == "Electrical")
                        && workSteps[index].Result == "NG")
                    {
                        bool plcValue = true;// plc.readBoolen(workSteps[index].SetValue);
                        workSteps[index].CurrentValue = plcValue.ToString();
                        workSteps[index].Result = plcValue ? "OK" : "NG";
                         // txtBarCode.Focus();
                        if (plcValue == false)
                        {
                            isSet = true;
                            txtContent.Text = "";
                            txtBarCode.ReadOnly = true;
                            break;
                        }

                    }
                    else if ((workSteps[index].MistakeType == "扫描防错" || workSteps[index].MistakeType == "ScanBarcode")
                        && workSteps[index].Result != "OK")
                    {
                        CheGasket = false;
                       signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "准备拍照,请扫描总成条码!";
                       txtrefre(signMsg);
                        txtBarCode.ReadOnly = false;
                        //txtBarCode.Focus();

                    }
                    else if ((workSteps[index].MistakeType == "条码防错" || workSteps[index].MistakeType == "ScanFoamBarcode")
                        && workSteps[index].Result != "OK")
                    {
                        CheGasket = false;
                       signMsg= "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + workSteps[index].Explain;
                       txtrefre(signMsg);
                        txtBarCode.ReadOnly = false;
                       // txtBarCode.Focus();

                    }
                    else if ((workSteps[index].MistakeType == "拍照防错S" || workSteps[index].MistakeType == "PhotoStart")
                        && workSteps[index].Result != "OK")
                    {
                        //发送相机启动指令
                        SendCameraCommand();
                        workSteps[index].CurrentValue = "OK";
                        workSteps[index].Result = "OK";

                        // currentIndex++;
                    }
                    else if ((workSteps[index].MistakeType == "拍照防错R" || workSteps[index].MistakeType == "PhotoEnd")
                        && workSteps[index].Result == "NG")
                    {
                        //发送相机启动指令
                        workSteps[index].CurrentValue = msg;
                        workSteps[index].Result = msg =="1" ?"OK" :"NG";

                    }
                    else if ((workSteps[index].MistakeType == "条码打印" || workSteps[index].MistakeType == "BarCodePrint")
                        && workSteps[index].Result == "NG")
                    {
                        try
                        {
                            workSteps[index].CurrentValue = "OK";
                            workSteps[index].Result = "OK";

                        }
                        catch (Exception ex)
                        {
                            signMsg= "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ex.Message;
                            txtrefre(signMsg);
                        }
                    }
                    else if ((workSteps[index].MistakeType == "写入PLC" || workSteps[index].MistakeType == "WritePlc")
                        && workSteps[index].Result == "NG")
                    {
                        plc.WriteBoolen(workSteps[index].SetValue, true);
                        Thread.Sleep(1000);
                        plc.WriteBoolen(workSteps[index].SetValue, false);
                        workSteps[index].CurrentValue = "OK";
                        workSteps[index].Result = "OK";

                        ResSetUI();
                        break;
                    }
                    currentIndex = index;
                    if (workSteps[index].Result != "OK")
                    {
                        break;
                    }

                }
                refreshGrid(workSteps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public delegate void RefreshText(string sigMsg);
        public void RefreTextBox(string sigMsg)
        {
            txtContent.AppendText(sigMsg);
            txtContent.Focus();
            txtContent.ScrollToCaret();
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void ResSetUI()
        {
            txtBarCode.Text = "";
            txtContent.Text = "";
            txtBarCode.Focus();
            barCode = "";
            subBarCode = "";
            BarCodeScanState = 0;
            plc.WriteBoolen(CanCremeaDoneStr, true);
            Thread.Sleep(500);
            plc.WriteBoolen(CanCremeaDoneStr, false);
            Speecher.GetInstance().SpeakContent("准备就绪");
            msg = "";
            //
            currentIndex = 0;
            isSet = true;
            workSteps = ReadStepInfo();
            picForceImage.Refresh();
            // lblResult.Text = "...";
            Thread.Sleep(500);
            CheGasket = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ResSetUI();
        }
        #endregion
        //条码扫描状态0 :总成  1，零件条码
        int BarCodeScanState = 0;
        string temp = "";
        #region 4.扫描条码并发送相机启动指令
        /// <summary>
        /// 条码扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (BarCodeScanState)
                {
                    //总成
                    case 0:
                        temp = txtBarCode.Text.Trim().Replace("\r\n", "");
                        if (!string.IsNullOrEmpty(temp) && temp.Length == 23
                            && temp.Contains(partNo))
                        {
                            bool isexist = DataOpreate.isCheck(temp);
                            if (isexist)
                            {
                                signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码:" + barCode + "已检测合格，不允许重复扫描";
                                txtrefre(signMsg);
                                txtBarCode.Text = "";
                            }
                            else
                            {
                                barCode = temp;
                                signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "总成条码扫描成功:" + barCode;
                                txtrefre(signMsg);
                                Speecher.GetInstance().SpeakContent("请扫描泡棉条码");
                                signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "请扫描泡棉条码!";
                                txtrefre(signMsg);
                                //txtBarCode.Focus();
                                txtBarCode.Text = "";
                                workSteps[currentIndex].CurrentValue = barCode;
                                workSteps[currentIndex].Result = "OK";
                                currentIndex++;
                                BarCodeScanState = 1;
                                CheGasket = true;
                            }
                        }
                        else
                        {
                            signMsg= "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码不正确:" + temp;
                            txtrefre(signMsg);
                            txtBarCode.Text = "";
                            
                        }
                        break;
                    case 1:
                        string subTemp = txtBarCode.Text.Trim();
                        if (!string.IsNullOrEmpty(txtBarCode.Text.Trim()) && txtBarCode.Text.Trim().Contains(workSteps[currentIndex].SetValue))
                        {
                            subBarCode = txtBarCode.Text.Trim();
                            txtBarCode.ReadOnly = true;
                            txtBarCode.Text = "";
                            signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "泡棉条码扫描成功:" + subBarCode;
                            txtrefre(signMsg);
                            workSteps[currentIndex].CurrentValue = subBarCode;
                            workSteps[currentIndex].Result = "OK";
                            currentIndex++;
                            BarCodeScanState = 0;
                            CheGasket = true;

                        }
                        else
                        {
                            signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "泡棉条码不正确:" + subTemp;
                            txtrefre(signMsg);
                            Speecher.GetInstance().SpeakContent("泡棉条码不正确!");
                            txtBarCode.Text = "";
                           // txtBarCode.Focus();
                        }
                        break;
                    default:
                        break;
                }

                if (!string.IsNullOrEmpty(barCode) && (!string.IsNullOrEmpty(subBarCode)))
                {
                    txtBarCode.ReadOnly = true;
                    txtBarCode.Text = "";
                    //txtContent.Text += "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码扫描成功:" + barCode;
                    //发送相机启动指令
                    // SendCameraCommand();
                }
            }
        }

        /// <summary>
        /// 发送相机指令
        /// </summary>
        public void SendCameraCommand()
        {
            string sendmsg = ConfigurationManager.AppSettings["StartCamearCommand"];
            axTcpRealClient.StartConnection();
            byte[] buff = new byte[sendmsg.Length / 2];
            int index = 0;
            for (int i = 0; i < sendmsg.Length; i += 2)
            {
                buff[index] = Convert.ToByte(sendmsg.Substring(i, 2), 16);
                ++index;
            }
            axTcpRealClient.SendCommand(buff);
            //CheGasket = false;
            signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "已发送启动指令到相机:" + sendmsg + " ,等待拍照结果！ ";
            txtrefre(signMsg);
            // currentIndex++;
        }
        #endregion

        string saveBar = "";
        string subBar = "";
        #region 4.获取相机反馈结果
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="date"></param>
        private void axTcpRealClient_OnReceviceByte(byte[] date)
        {
            string destUrl = "";
            if (string.IsNullOrEmpty(subBarCode))
            {
                return;
            }
            try
            {
                saveBar = barCode;
                subBar = subBarCode;

                msg = "";
                ////以文本转ASCIIEncoding转码形式显示数据
                msg = Encoding.Default.GetString(date).Replace("\r\n", "");
                signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "接收相机数据:" + msg;
                txtrefre(signMsg);
                if (msg == "1")
                {
                    CheGasket = false;
                    okCount++;
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "拍照成功，结果为OK ";
                    txtrefre(signMsg);
                    //Speecher.GetInstance().SpeakSuccess();
                    currentIndex++;
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码打印开始... ";
                    txtrefre(signMsg);
                    ////条码打印
                    //BarCodePrint print = new BarCodePrint();
                    //print.PrintBarCode(itemName, partNo);
                    Thread thread = new Thread(printRun);
                    thread.IsBackground = true;
                    thread.Start();

                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码打印结束... ";
                    txtrefre(signMsg);
                    lblResult.Text = "OK";
                    lblResult.ForeColor = Color.Green;
                    lblResult.Refresh();
                    CheGasket = true;

                }
                else
                {
                    ngCount++;
                    lblResult.Text = "NG";
                    lblResult.ForeColor = Color.Red;
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "拍照成功，结果为NG ";
                    txtrefre(signMsg);
                    lblResult.Refresh();
                    Speecher.GetInstance().SpeakFailure();

                }


                string tempPath = ConfigurationManager.AppSettings["OriRealPath"];
                string destPath = ConfigurationManager.AppSettings["DestRealPath"];
                destUrl = destPath + "\\" + saveBar + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                Thread.Sleep(500);


                var files = Directory.GetFiles(tempPath, "*.jpg");

                DataOpreate.insertCheckResult(new CheckReultO(saveBar, partNo, itemName, "R", DateTime.Now,
                   msg == "1" ? "OK" : "NG", subBar, destUrl.Replace("\\", "\\\\"), DateTime.Now, ""));
                if (files.Length > 0)
                {
                    //picForceImage.Image = Image.FromFile(defaultPath);
                    FileOperate.FileMove(files[files.Length - 1], destUrl);
                }
                else
                {
                   signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "未检测到拍照结果!";
                   txtrefre(signMsg);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ex.Message;
               txtrefre(signMsg);
            }
            finally
            {

                barCode = "";
                subBarCode = "";
                Thread.Sleep(1000);
                picForceImage.ImageLocation = destUrl;
                picForceImage.Refresh();
                this.ActiveControl = picForceImage;
                Thread.Sleep(500);
               
            }
            // ResSetUI();
        }
        #endregion


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!IsHandleCreated)
            {
                this.Close();
            }
        }
        private void btnSelectHistory_Click(object sender, EventArgs e)
        {
            CheGasket = true;
        }

        #region  与相机通讯
        /// <summary>
        /// 处理推送过来的消息
        /// </summary>
        /// <param name="rec"></param>

        #endregion

        /// <summary>
        /// 电磁阀1打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenLigntAction1_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(openActionStr1, true);
            Thread.Sleep(2000);
            plc.WriteBoolen(openActionStr1, false);
        }

        private void btnCloseLightAction1_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(closeActionStr1, true);
            Thread.Sleep(2000);
            plc.WriteBoolen(closeActionStr1, false);
        }

        /// <summary>
        /// 电磁阀2打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenLigntAction2_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(openActionStr2, true);
            Thread.Sleep(500);
            plc.WriteBoolen(openActionStr2, false);
        }

        private void btnCloseLightAction2_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(closeActionStr2, true);
            Thread.Sleep(500);
            plc.WriteBoolen(closeActionStr2, false);
        }

        private void FrmRealBootMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            plc.WriteBoolen("DB2.DBX9.7", false);
            System.Environment.Exit(0);

        }

        private void btnPlc_Click(object sender, EventArgs e)
        {
            RealSignMonitor form = new RealSignMonitor(PowerOnOffPlcAdrStr, ManualAutoPlcAdrStr, QuickStopPlcAdrStr,
               ScreenOKPlcAdrStr, GasOKPlcAdrStr, OpenLightPlcAdrStr1, CloseLightPlcAdrStr1, OpenLightPlcAdrStr2,
               CloseLightPlcAdrStr2, WarnStatePlcAdrStr, Cylinder1Str, Cylinder2Str, Cylinder3Str, Cylinder4Str, Cylinder5Str
               , Cylinder6Str, CurrentCulture);
            while (form.DialogResult != DialogResult.Cancel)
            {

                form.ShowDialog();
                form.Focus();
            }
            form.Dispose();
           // txtBarCode.Focus();
            this.Show();
        }
        private void printRun()
        {
            BarCodePrint print = new BarCodePrint();
            print.PrintBarCode(itemName, partNo, ZPLStart, PrintContent, FontName, FontSize, ZPLEnd, PrinterName);

        }
        private void gridStep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow dgr = this.gridStep.Rows[e.RowIndex];
            if (dgr.Cells["Result"].Value.ToString() == "OK")
            {
                dgr.DefaultCellStyle.BackColor = Color.Green;
                //gridStep.RowsDefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                if (e.RowIndex == currentIndex)
                {
                    dgr.DefaultCellStyle.SelectionBackColor = Color.Red;
                    dgr.Selected = true;
                }
                else
                {
                    dgr.Selected = false;
                }
            }
        }

        private void picCommpany_Click(object sender, EventArgs e)
        {
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            if (!ManualAuto)
            {

                if (PwdInput.CanOpreate)
                {
                    FrmRealPB pbFrm = new FrmRealPB(CurrentCulture);
                    while (pbFrm.DialogResult != DialogResult.Cancel)
                    {

                        pbFrm.ShowDialog();
                        pbFrm.Focus();
                    }
                    pbFrm.Dispose();
                   // txtBarCode.Focus();
                    this.Show();

                }

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            HisSelect realForm = new HisSelect(CurrentCulture);
            while (realForm.DialogResult != DialogResult.Cancel)
            {
                //this.Hide();
                realForm.ShowDialog();
            }
            realForm.Dispose();
            realForm = null;
            //this.Show();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            if (CurrentCulture == "en-US")
            {
                CurrentCulture = "zh-CN";
                ResourceCulture.SetCurrentCulture("zh-CN");
                ComBasic.ChangeConfig("currentCulture", "zh-CN");

            }
            else
            {
                CurrentCulture = "en-US";
                ResourceCulture.SetCurrentCulture("en-US");
                ComBasic.ChangeConfig("currentCulture", "en-US");
            }
            this.SetResourceCulture();
        }

        private void FrmRealBootMonitor_AutoSizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }



    }
}
