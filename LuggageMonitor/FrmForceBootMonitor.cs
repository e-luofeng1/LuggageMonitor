using System;
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

namespace LuggageMonitor
{
    public partial class FrmForceBootMonitor : CCSkinMain
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


        //垫片信号
        bool ForceGasket1, ForceGasket2, ForceGasket3, ForceGasket4, Cylinder1, Cylinder2;
        ////传感器屏蔽
        //bool isValidGasket1, isValidGasket2, isValidGasket3, isValidGasket4;

        //是否可以拍照
        bool isCanCremea;
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

        //垫片信号
        string ForceGasket1Str, ForceGasket2Str, ForceGasket3Str, ForceGasket4Str, Cylinder1Str, Cylinder2Str, CanCremeaStr, CanCremeaDoneStr;
        //电磁阀打开关闭
        string openActionStr, closeActionStr;

        string itemName = "";
        string partNo = "";
        string barCode = "";
        public static string CurrentCulture = ConfigurationManager.AppSettings["currentCulture"];
        //配置文件名称
        string foreConfigFileName = CurrentCulture == "zh-CN" ?
            ConfigurationManager.AppSettings["ConfigFineName"] : ConfigurationManager.AppSettings["ConfigFineNameUS"];
        //配置文件Sheet
        string foreConfigSheetName = ConfigurationManager.AppSettings["ConfigForceSheetName"];
        /// <summary>
        /// PLC状态刷新时间
        /// </summary>
        int plcRefreshDelayTime = 1000;
        int ioRefreshDelayTime = 1000;
        int gasketRefreshDelayTime = 1000;

        AutoSizeFormClass asc = new AutoSizeFormClass();
        RefreshText txtrefre;
        string signMsg = "";
        public FrmForceBootMonitor()
        {
            
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            txtrefre = new RefreshText(RefreTextBox);
            refreshTime();
        }


        public void refreshTime()
        {
            new System.Threading.Thread(() =>
            {
                while (true)
                {
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
            foreConfigFileName = CurrentCulture == "zh-CN" ?
            ConfigurationManager.AppSettings["ConfigFineName"] : ConfigurationManager.AppSettings["ConfigFineNameUS"];


            this.Text = ResourceCulture.GetString("FrmForceBootMonitor_Text");
            // this.Font = ComBasic.GetFont(CurrentCulture, 9);
            lblTitle.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblTitle_Text");
            // lblTitle.Font = ComBasic.GetFont(CurrentCulture, 16.2f);
            pnlBasicInfo.Text = ResourceCulture.GetString("FrmForceBootMonitor_pnlBasicInfo_Text");
            // pnlBasicInfo.Font = ComBasic.GetFont(CurrentCulture, 9);

            lblBarCode.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblBarCode_Text");
            // lblBarCode.Font = ComBasic.GetFont(CurrentCulture, 9);

            lblItemName.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblItemName_Text");
            //lblItemName.Font = ComBasic.GetFont(CurrentCulture, 9);

            lblPartNo.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblPartNo_Text");
            // lblPartNo.Font = ComBasic.GetFont(CurrentCulture, 9);

            chkHeart.Text = ResourceCulture.GetString("FrmForceBootMonitor_chkHeart_Text");
            //chkHeart.Font = ComBasic.GetFont(CurrentCulture, 9);

            pnlStep.Text = ResourceCulture.GetString("FrmForceBootMonitor_pnlStep_Text");
            // pnlStep.Font = ComBasic.GetFont(CurrentCulture, 9);

            gridStep.Columns["MistakeType"].HeaderText
                = ResourceCulture.GetString("FrmForceBootMonitor_grid_MistakeType_HeaderText");
            gridStep.Columns["Explain"].HeaderText
                = ResourceCulture.GetString("FrmForceBootMonitor_grid_Explain_HeaderText");
            gridStep.Columns["Result"].HeaderText
               = ResourceCulture.GetString("FrmForceBootMonitor_grid_Result_HeaderText");
            gridStep.Columns["CurrentValue"].HeaderText
                = ResourceCulture.GetString("FrmForceBootMonitor_grid_CurrentValue_HeaderText");
            // gridStep.Font = ComBasic.GetFont(CurrentCulture, 9);
            // gridStep.DefaultCellStyle.Font = ComBasic.GetFont(CurrentCulture, 9);

            pnlCountInfo.Text = ResourceCulture.GetString("FrmForceBootMonitor_pnlCountInfo_Text");
            // pnlCountInfo.Font = ComBasic.GetFont(CurrentCulture, 9);

            lblOK.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblOK_Text");
            // lblOK.Font = ComBasic.GetFont(CurrentCulture, 9);

            lblNOK.Text = ResourceCulture.GetString("FrmForceBootMonitor_lblNOK_Text");
            //lblNOK.Font = ComBasic.GetFont(CurrentCulture, 9);

            pnlSystem.Text = ResourceCulture.GetString("FrmForceBootMonitor_pnlSystem_Text");
            //pnlSystem.Font = ComBasic.GetFont(CurrentCulture, 9);
            pnlpicReult.Text = ResourceCulture.GetString("FrmForceBootMonitor_pnlpicReult_Text");
            // pnlpicReult.Font = ComBasic.GetFont(CurrentCulture, 22.2f);

            btnRest.Text = ResourceCulture.GetString("FrmForceBootMonitor_btnRest_Text");
            //btnRest.Font = ComBasic.GetFont(CurrentCulture, 9);
            btnOpenLigntAction.Text = ResourceCulture.GetString("FrmForceBootMonitor_btnOpenLigntAction_Text");
            btnOpenLigntAction.Font = ComBasic.GetFont(CurrentCulture, 9);
            btnCloseLightAction.Text = ResourceCulture.GetString("FrmForceBootMonitor_btnCloseLightAction_Text");
            //btnCloseLightAction.Font = ComBasic.GetFont(CurrentCulture, 9);
            btnPlc.Text = ResourceCulture.GetString("FrmForceBootMonitor_btnPlc_Text");
            //btnPlc.Font = ComBasic.GetFont(CurrentCulture, 9);
            btnSelectHistory.Text = ResourceCulture.GetString("FrmForceBootMonitor_btnSelect_Text");

        }


        public void refreshGrid(List<WorkStep> list)
        {
            this.Invoke(new Action(() =>
            {
                gridStep.DataSource = list;
                gridStep.Refresh();

            }));
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void reSet()
        {
            txtBarCode.Text = "";
            txtBarCode.Focus();

        }
        int okCount, ngCount = 0;
        static List<WorkStep> workSteps = new List<WorkStep>();
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmForceBootMonitor_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            ReadConfig();
            ReadPrintConfig();
            this.SetResourceCulture();
            workSteps = ReadStepInfo();
            refreshGrid(workSteps);
            //初始化控件
            //plc连接状态
            btnForcePLCState.ButtonColor = Color.DimGray;

            reSet();

            //PLC初始化
            plcconn = ComBasic.SetForePLC();
            plc = new S7NetPLC(CpuType.S71500, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();
            chkPLCState_CheckedChanged(null, null);
           
             return;
            //相机设置
            axTcpForceClient.ServerIp = ConfigurationManager.AppSettings["foreIpAddress"];
            axTcpForceClient.ServerPort = Int16.Parse(ConfigurationManager.AppSettings["forePort"]);
            axTcpForceClient.StartConnection();

            //获取PLC刷新时间
            plcRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["plcRefreshDelayTime"]);
            //PLC刷新
            plcStateRefreshThread = new Thread(plcHeartRun);
            plcStateRefreshThread.Start();

            ioRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["ioRefreshDelayTime"]);
            IOReadThread = new Thread(IoReadFun);
            IOReadThread.Start();

            gasketRefreshDelayTime = int.Parse(ConfigurationManager.AppSettings["gasketRefreshDelayTime"]);
            CheGasket = true;
            checkGasketSignReadThread = new Thread(CheckGasketFun);
            checkGasketSignReadThread.Start();
            isIoRead = true;
            // txtBarCode.KeyUp += txtBarCode_KeyUp;
            okCount = ngCount = 0;
            string startStr = "DB2.DBX8.2";
            plc.WriteBoolen(startStr, true);


            Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10000"));
        }
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
                string configFineName = foreConfigFileName;
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

                catch { }
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

                    ShowSignBtton(btnForcePLCState, Color.Lime, "");
                }
                else
                {
                    ShowSignBtton(btnForcePLCState, Color.DimGray, "");
                    plc.connectPLC();
                }
            }
            catch (Exception ex)
            {
                txtrefre(ComBasic.formtMes(ex.Message));
            }
        }
        #endregion

        /// <summary>
        /// 读取工步
        /// </summary>
        /// <returns></returns>
        public List<WorkStep> ReadStepInfo()
        {
            List<WorkStep> workSteps = new List<WorkStep>();
            var StepInfo = ExcelHelper.ImportExceltoDt(foreConfigFileName, foreConfigSheetName, 14, true);
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

        /// <summary>
        /// 读取EXCEL配置文件
        /// </summary>
        public void ReadConfig()
        {
            var foreConfigData = ComBasic.ReadExcelSheet(foreConfigFileName, foreConfigSheetName, false);
            if (foreConfigData != null)
            {
                //项目名称
                itemName = Convert.ToString(foreConfigData.GetRow(0).GetCell(1));
                txtForceItemName.Text = itemName;
                //零件名称 
                partNo = Convert.ToString(foreConfigData.GetRow(1).GetCell(1));
                txtForcePartNo.Text = partNo;
                //电源控制开关
                PowerOnOffPlcAdrStr = Convert.ToString(foreConfigData.GetRow(4).GetCell(3));

                //自动手动
                ManualAutoPlcAdrStr = Convert.ToString(foreConfigData.GetRow(5).GetCell(3));

                //急停
                QuickStopPlcAdrStr = Convert.ToString(foreConfigData.GetRow(6).GetCell(3));

                //光幕
                ScreenOKPlcAdrStr = Convert.ToString(foreConfigData.GetRow(7).GetCell(3));

                //进气气压
                GasOKPlcAdrStr = Convert.ToString(foreConfigData.GetRow(8).GetCell(3));

                //电磁阀打开故障
                OpenLightPlcAdrStr = Convert.ToString(foreConfigData.GetRow(9).GetCell(3));

                //电磁阀关闭故障
                CloseLightPlcAdrStr = Convert.ToString(foreConfigData.GetRow(10).GetCell(3));

                //报警复位
                WarnStatePlcAdrStr = Convert.ToString(foreConfigData.GetRow(11).GetCell(3));

                //电磁阀打开关闭地址

                openActionStr = Convert.ToString(foreConfigData.GetRow(29).GetCell(3));
                closeActionStr = Convert.ToString(foreConfigData.GetRow(30).GetCell(3));

                CanCremeaDoneStr = Convert.ToString(foreConfigData.GetRow(25).GetCell(3));


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
        int firstOpen = 0;
        /// <summary>
        /// 读取信号
        /// </summary>
        public void ReadIOSign()
        {
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            if (ManualAuto)
            {
                btnOpenLigntAction.Enabled = false;
                btnCloseLightAction.Enabled = false;
            }
            else
            {
                btnOpenLigntAction.Enabled = true;
                btnCloseLightAction.Enabled = true;
            }


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
        private void printRun()
        {
            BarCodePrint print = new BarCodePrint();
            print.PrintBarCode(itemName, partNo, ZPLStart, PrintContent, FontName, FontSize, ZPLEnd, PrinterName);

        }
        int currentIndex = 0;
        bool isSet = false;
        /// <summary>
        /// 读取信号
        /// </summary>
        public void ReadGasKetSign()
        {
            try
            {
                string restPlcAdr = "DB2.DBX8.1";
                bool plcfwValue = plc.readBoolen(restPlcAdr);
                if (plcfwValue)
                {
                    currentIndex = 0;
                    ResSetUI();
                }
                if (isSet)
                {
                    currentIndex = 0;
                    workSteps = ReadStepInfo();
                    isSet = false;
                }

                for (int index = currentIndex; index < workSteps.Count; index++)
                {

                    if ((workSteps[index].MistakeType == "电气防错" || workSteps[index].MistakeType == "Electrical")
                        && workSteps[index].Result == "NG")
                    {
                        bool plcValue = true;// plc.readBoolen(workSteps[index].SetValue);
                        workSteps[index].CurrentValue = plcValue.ToString();
                        workSteps[index].Result = plcValue ? "OK" : "NG";
                        if (plcValue == false)
                        {
                            isSet = true;
                            txtContent.Text = "";
                            txtBarCode.ReadOnly = true;
                            break;
                        }

                    }
                    else if ((workSteps[index].MistakeType == "扫描防错" || workSteps[index].MistakeType == "ScanBarcode")
                         && workSteps[index].Result == "NG")
                    {
                        signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10001");
                        txtrefre(signMsg);
                        txtBarCode.ReadOnly = false;
                        CheGasket = false;

                    }
                    else if ((workSteps[index].MistakeType == "拍照防错S" || workSteps[index].MistakeType == "PhotoStart")
                        && workSteps[index].Result == "NG")
                    {
                        //发送相机启动指令
                        SendCameraCommand();
                        workSteps[index].Result = "OK";
                        workSteps[index].CurrentValue = "";
                    }
                    else if ((workSteps[index].MistakeType == "拍照防错R" || workSteps[index].MistakeType == "PhotoEnd")
                        && workSteps[index].Result == "NG")
                    {
                        //发送相机启动指令
                        workSteps[index].CurrentValue = msg;
                        workSteps[index].Result = msg == "1" ? "OK" : "NG";

                    }
                    else if ((workSteps[index].MistakeType == "条码打印" || workSteps[index].MistakeType == "BarCodePrint")
                        && workSteps[index].Result == "NG")
                    {
                        try
                        {
                            if (msg == "1")
                            {
                               signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10003");
                               txtrefre(signMsg);
                                Thread thread = new Thread(printRun);
                                thread.Start();

                                signMsg= "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10004");
                                txtrefre(signMsg);
                                //发送相机启动指令
                                workSteps[index].CurrentValue = "OK";
                                workSteps[index].Result = "OK";
                            }
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
            catch (Exception)
            {

            }


        }
        /// <summary>
        /// 重置
        /// </summary>
        private void ResSetUI()
        {
            txtBarCode.Text = "";
            txtContent.Text = "";

            barCode = "";
            plc.WriteBoolen(CanCremeaDoneStr, true);
            Thread.Sleep(1000);
            plc.WriteBoolen(CanCremeaDoneStr, false);
            Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10000"));
            signMsg = "";
            CheGasket = false;
            isSet = true;
            workSteps = ReadStepInfo();
            currentIndex = 0;
            picForceImage.Refresh();
            CheGasket = true;

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ResSetUI();
        }
        #endregion
        
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

                string temp = txtBarCode.Text.Trim().Replace("\r\n", "");
                if (!string.IsNullOrEmpty(temp) && temp.Length == 23 && temp.Contains(partNo))
                {
                    bool isexist = DataOpreate.isCheck(temp);
                    if (isexist)
                    {
                        signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + barCode + ResourceCulture.GetString("10006");
                        txtrefre(signMsg);
                        Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10005"));
                    }
                    else
                    {
                        barCode = temp;
                        txtBarCode.ReadOnly = true;
                        signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10007") + barCode;
                        txtrefre(signMsg);
                        workSteps[currentIndex].CurrentValue = barCode;
                        workSteps[currentIndex].Result = "OK";
                       
                        currentIndex++;
                        CheGasket = true;
                    }

                }
                else
                {
                    Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10005"));
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "条码不正确:" + temp;
                    txtrefre(signMsg);
                }
                txtBarCode.Text = "";
            }
        }

        /// <summary>
        /// 发送相机指令
        /// </summary>
        public void SendCameraCommand()
        {
            try
            {
                string sendmsg = ConfigurationManager.AppSettings["StartCamearCommand"];
                axTcpForceClient.StartConnection();
                byte[] buff = new byte[sendmsg.Length / 2];
                int index = 0;
                for (int i = 0; i < sendmsg.Length; i += 2)
                {
                    buff[index] = Convert.ToByte(sendmsg.Substring(i, 2), 16);
                    ++index;
                }
                axTcpForceClient.SendCommand(buff);
              
                signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10002") + sendmsg;
                txtrefre(signMsg);
            }
            catch (Exception ex)
            {
                txtrefre(ex.Message);
            }
        }
        #endregion

        string msg = "";
        string saveBar = "";
        #region 4.获取相机反馈结果
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="date"></param>
        private void axTcpForceClient_OnReceviceByte(byte[] date)
        {
            string destUrl = "";
            if (string.IsNullOrEmpty(barCode))
            {
                return;
            }
            else
            {
                saveBar = barCode;
            }
            try
            {
                ////以文本转ASCIIEncoding转码形式显示数据
                msg = Encoding.Default.GetString(date).Replace("\r\n", "");
                if (msg == "1")
                {
                    okCount++;
                    currentIndex++;
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10009");
                    txtrefre(signMsg);
                    lblResult.Text = "OK";
                    lblResult.ForeColor = Color.Green;
                    Speecher.GetInstance().SpeakContent(ResourceCulture.GetString("10008"));
                }
                else
                {
                    ngCount++;
                    lblResult.Text = "NG";
                    lblResult.ForeColor = Color.Red;
                    signMsg ="\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10010");
                    txtrefre(signMsg);
                    Speecher.GetInstance().SpeakFailure();

                }
                string tempPath = ConfigurationManager.AppSettings["OriForcePath"];
                string destPath = ConfigurationManager.AppSettings["DestForcePath"];
                destUrl = destPath + "\\" + saveBar + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                DataOpreate.insertCheckResult(new CheckReultO(saveBar, partNo, itemName, "F", DateTime.Now,
                    msg == "1" ? "OK" : "NG", "", destUrl.Replace("\\", "\\\\"), DateTime.Now, ""));
                //txtContent.Text += "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "接收相机数据:" + msg;

                //string defaultPath = ConfigurationManager.AppSettings["defaultPicPath"];
                var files = Directory.GetFiles(tempPath, "*.jpg");
                Thread.Sleep(500);

                if (files.Length > 0)
                {
                    FileOperate.FileMove(files[files.Length - 1], destUrl);
                    picForceImage.ImageLocation = destUrl;
                    picForceImage.Refresh();
                }
                else
                {
                    signMsg = "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ResourceCulture.GetString("10010");
                    txtrefre(signMsg);
                }

                // ResSetUI();
            }
            catch (Exception ex)
            {
                signMsg= "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ex.Message;
                txtrefre(signMsg);
            }
            finally
            {
                barCode = "";
                saveBar = "";
                Thread.Sleep(500);
                picForceImage.ImageLocation = destUrl;
                picForceImage.Refresh();

            }
        }
        #endregion

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmForceBootMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            string startStr = "DB2.DBX8.2";
            plc.WriteBoolen(startStr, false);
            System.Environment.Exit(0);

        }
        public delegate void RefreshText(string signMsg);
        public void RefreTextBox(string signMsg)
        {
            txtContent.AppendText(signMsg);
            txtContent.Focus();
            txtContent.ScrollToCaret();
        }
        private void btnSelectHistory_Click(object sender, EventArgs e)
        {
            HisSelect realForm = new HisSelect(CurrentCulture);
            while (realForm.DialogResult != DialogResult.Cancel)
            {
                //this.Hide();
                realForm.ShowDialog();
            }
            realForm.Dispose();
            realForm = null;
        }

        #region  与相机通讯
        /// <summary>
        /// 处理推送过来的消息
        /// </summary>
        /// <param name="rec"></param>

        /// <summary>
        /// 解析域名
        /// </summary>
        private string DomainName(string strDomain)
        {
            IPHostEntry host = Dns.GetHostByName(strDomain);
            IPAddress ip = host.AddressList[0];
            return ip.ToString();
        }


        #endregion



        private void btnOpenLightAction_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(openActionStr, true);
            Thread.Sleep(500);
            plc.WriteBoolen(openActionStr, false);
        }

        private void btnCloseLightAction_Click(object sender, EventArgs e)
        {
            plc.WriteBoolen(closeActionStr, true);
            Thread.Sleep(500);
            plc.WriteBoolen(closeActionStr, false);
        }
        /// <summary>
        /// PLC监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlc_Click(object sender, EventArgs e)
        {
            ForceSignMonitor signForm = new ForceSignMonitor(PowerOnOffPlcAdrStr, ManualAutoPlcAdrStr, QuickStopPlcAdrStr
           , ScreenOKPlcAdrStr, GasOKPlcAdrStr, OpenLightPlcAdrStr, CloseLightPlcAdrStr, WarnStatePlcAdrStr, CurrentCulture);

            while (signForm.DialogResult != DialogResult.Cancel)
            {

                signForm.ShowDialog();
                // signForm.Focus();
            }
            signForm.Dispose();
            txtBarCode.Focus();
            this.Show();
        }

        private void gridStep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
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
            catch
            {
                //gridStep.Invalidate();// InvalidateRow();
            }
        }

        private void picCommany_Click(object sender, EventArgs e)
        {
            ManualAuto = plc.readBoolen(ManualAutoPlcAdrStr);
            if (!ManualAuto)
            {

                if (PwdInput.CanOpreate)
                {
                    FrmForcePB pbFrm = new FrmForcePB(CurrentCulture);
                    while (pbFrm.DialogResult != DialogResult.Cancel)
                    {

                        pbFrm.ShowDialog();
                        pbFrm.Focus();
                    }
                    pbFrm.Dispose();
                    txtBarCode.Focus();
                    this.Show();

                }
                else
                {
                    PwdInput frm = new PwdInput(CurrentCulture);
                    while (frm.DialogResult != DialogResult.Cancel)
                    {

                        frm.ShowDialog();
                        frm.Focus();
                    }
                    frm.Dispose();
                    txtBarCode.Focus();
                    this.Show();
                }
            }
        }

        //private void btnSelect_Click(object sender, EventArgs e)
        //{
        //    HisSelect realForm = new HisSelect(CurrentCulture);
        //    while (realForm.DialogResult != DialogResult.Cancel)
        //    {
        //        this.Hide();
        //        realForm.ShowDialog();
        //    }
        //    realForm.Dispose();
        //    realForm = null;
        //    this.Show();
        //}
        /// <summary>
        /// 切换语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myClick_DoubleClick(object sender, EventArgs e)
        {

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
            isSet = true;
            workSteps = ReadStepInfo();
            refreshGrid(workSteps);

            //gridStep.Refresh();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            HisSelect realForm = new HisSelect(CurrentCulture);
            while (realForm.DialogResult != DialogResult.Cancel)
            {
                this.Hide();
                realForm.ShowDialog();
            }
            realForm.Dispose();
            this.Show();
            txtBarCode.Focus();
        }

        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

      



    }
}
