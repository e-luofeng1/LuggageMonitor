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
    public partial class FrmRealPB :CCSkinMain
    {
        string CurrentCulture;
        //PLC连接信息
        PLCConn plcconn;
        S7NetPLC plc;
        public FrmRealPB(string CurrentCulture)
        {
            InitializeComponent();
            if (PwdInput.CanOpreate)
            {
                btnF1.Enabled = true;
                btnF2.Enabled = true;
                btnF3.Enabled = true;
                btnF4.Enabled = true;
                btnF5.Enabled = true;
                btnF6.Enabled = true;
                btnF7.Enabled = true;
                btnF8.Enabled = true;
                btnF9.Enabled = true;
            }
            this.CurrentCulture = CurrentCulture;
            plcconn = ComBasic.SetRealPLC();
            plc = new S7NetPLC(CpuType.S71200, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();
        }
        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            this.Text = ResourceCulture.GetString("FrmRealPB_Text");
            this.btnF1.Text = ResourceCulture.GetString("FrmRealPB_btnF1_BlockText");
            this.btnF2.Text = ResourceCulture.GetString("FrmRealPB_btnF2_BlockText");
            this.btnF3.Text = ResourceCulture.GetString("FrmRealPB_btnF4_BlockText");
            this.btnF4.Text = ResourceCulture.GetString("FrmRealPB_btnF4_BlockText");
            this.btnF5.Text = ResourceCulture.GetString("FrmRealPB_btnF5_BlockText");
            this.btnF6.Text = ResourceCulture.GetString("FrmRealPB_btnF6_BlockText");
            this.btnF7.Text = ResourceCulture.GetString("FrmRealPB_btnF7_BlockText");
            this.btnF8.Text = ResourceCulture.GetString("FrmRealPB_btnF8_BlockText");
            this.btnF9.Text = ResourceCulture.GetString("FrmRealPB_btnF9_BlockText");

        }
        private void btnF3_Click(object sender, System.EventArgs e)
        {
            if (btnF3.Text == ResourceCulture.GetString("FrmRealPB_btnF3_BlockText"))
            {
                btnF3.Text = ResourceCulture.GetString("FrmRealPB_btnF3_OpenText");
                plc.WriteBoolen("DB2.DBX8.7", true);
            }
            else
            {
                btnF3.Text = ResourceCulture.GetString("FrmRealPB_btnF3_BlockText");
                plc.WriteBoolen("DB2.DBX8.7", false);
            }
        }

        private void btnF1_Click(object sender, System.EventArgs e)
        {
            if (btnF1.Text == ResourceCulture.GetString("FrmRealPB_btnF1_BlockText"))
            {
                btnF1.Text = ResourceCulture.GetString("FrmRealPB_btnF1_OpenText");
                plc.WriteBoolen("DB2.DBX8.5", true);
            }
            else
            {
                btnF1.Text = ResourceCulture.GetString("FrmRealPB_btnF1_BlockText");
                plc.WriteBoolen("DB2.DBX8.5", false);
            }
        }

        private void btnF2_Click(object sender, System.EventArgs e)
        {
            if (btnF2.Text == ResourceCulture.GetString("FrmRealPB_btnF2_BlockText"))
            {
                btnF2.Text = ResourceCulture.GetString("FrmRealPB_btnF2_OpenText");
                plc.WriteBoolen("DB2.DBX8.6", true);
            }
            else
            {
                btnF2.Text = ResourceCulture.GetString("FrmRealPB_btnF2_BlockText");
                plc.WriteBoolen("DB2.DBX8.6", false);
            }
        }

        private void btnF4_Click(object sender, System.EventArgs e)
        {
            if (btnF4.Text == ResourceCulture.GetString("FrmRealPB_btnF4_BlockText"))
            {
                btnF4.Text = ResourceCulture.GetString("FrmRealPB_btnF4_OpenText");
                plc.WriteBoolen("DB2.DBX9.0", true);
            }
            else
            {
                btnF4.Text = ResourceCulture.GetString("FrmRealPB_btnF4_BlockText");
                plc.WriteBoolen("DB2.DBX9.0", false);
            }
        }

        private void btnF5_Click(object sender, System.EventArgs e)
        {
            if (btnF5.Text == ResourceCulture.GetString("FrmRealPB_btnF5_BlockText"))
            {
                btnF5.Text = ResourceCulture.GetString("FrmRealPB_btnF5_OpenText");
                plc.WriteBoolen("DB2.DBX9.1", true);
            }
            else
            {
                btnF5.Text = ResourceCulture.GetString("FrmRealPB_btnF5_BlockText");
                plc.WriteBoolen("DB2.DBX9.1", false);
            }
        }

        private void btnF6_Click(object sender, System.EventArgs e)
        {
            if (btnF6.Text == ResourceCulture.GetString("FrmRealPB_btnF6_BlockText"))
            {
                btnF6.Text = ResourceCulture.GetString("FrmRealPB_btnF6_OpenText");
                plc.WriteBoolen("DB2.DBX9.2", true);
            }
            else
            {
                btnF6.Text = ResourceCulture.GetString("FrmRealPB_btnF6_BlockText");
                plc.WriteBoolen("DB2.DBX9.2", false);
            }
        }

        private void btnF7_Click(object sender, System.EventArgs e)
        {
            if (btnF7.Text == ResourceCulture.GetString("FrmRealPB_btnF7_BlockText"))
            {
                btnF7.Text = ResourceCulture.GetString("FrmRealPB_btnF7_OpenText");
                plc.WriteBoolen("DB2.DBX9.3", true);
            }
            else
            {
                btnF7.Text = ResourceCulture.GetString("FrmRealPB_btnF7_BlockText");
                plc.WriteBoolen("DB2.DBX9.3", false);
            }
        }

        private void btnF8_Click(object sender, System.EventArgs e)
        {
            if (btnF8.Text == ResourceCulture.GetString("FrmRealPB_btnF8_BlockText"))
            {
                btnF8.Text = ResourceCulture.GetString("FrmRealPB_btnF8_OpenText");
                plc.WriteBoolen("DB2.DBX9.4", true);
            }
            else
            {
                btnF8.Text = ResourceCulture.GetString("FrmRealPB_btnF8_BlockText");
                plc.WriteBoolen("DB2.DBX9.4", false);
            }
        }

        private void btnF9_Click(object sender, System.EventArgs e)
        {
            if (btnF9.Text == ResourceCulture.GetString("FrmRealPB_btnF9_BlockText"))
            {
                btnF9.Text = ResourceCulture.GetString("FrmRealPB_btnF9_OpenText");
                plc.WriteBoolen("DB2.DBX9.5", true);
            }
            else
            {
                btnF9.Text = ResourceCulture.GetString("FrmRealPB_btnF9_BlockText");
                plc.WriteBoolen("DB2.DBX9.5", false);
            }
        }
    }
}
