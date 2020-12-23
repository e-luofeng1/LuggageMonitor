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
using System;

namespace LuggageMonitor
{
    public partial class FrmForcePB :CCSkinMain
    {
        //PLC连接信息
        PLCConn plcconn;
        S7NetPLC plc;
        string CurrentCulture;
        public FrmForcePB(string CurrentCulture)
        {
            InitializeComponent();
            this.CurrentCulture = CurrentCulture;
            if (PwdInput.CanOpreate)
            {
                btnF1C.Enabled = true;
                btnF2.Enabled = true;
                btnF3.Enabled = true;
                btnF4.Enabled = true;
            }
            plcconn = ComBasic.SetForePLC();
            plc = new S7NetPLC(CpuType.S71200, plcconn.Ip, plcconn.Rack, plcconn.Slot);
            plc.connectPLC();
        }
        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            this.Text = ResourceCulture.GetString("FrmForcePB_Text");
            this.btnF1C.Text = ResourceCulture.GetString("FrmForcePB_btnF1_BlockText");
            this.btnF2.Text = ResourceCulture.GetString("FrmForcePB_btnF2_BlockText");
            this.btnF3.Text = ResourceCulture.GetString("FrmForcePB_btnF4_BlockText");
            this.btnF4.Text = ResourceCulture.GetString("FrmForcePB_btnF4_BlockText");
        }
        private void btnF1C_Click(object sender, System.EventArgs e)
        {
            if (btnF1C.Text == ResourceCulture.GetString("FrmForcePB_btnF1_BlockText"))
            {
                btnF1C.Text = ResourceCulture.GetString("FrmForcePB_btnF1_OpenText");
                plc.WriteBoolen("DB2.DBX7.5", true);
            }
            else
            {
                btnF1C.Text = ResourceCulture.GetString("FrmForcePB_btnF1_BlockText");
                plc.WriteBoolen("DB2.DBX7.5", false);
            }
        }

        private void btnF2_Click(object sender, System.EventArgs e)
        {
            if (btnF2.Text == ResourceCulture.GetString("FrmForcePB_btnF2_BlockText"))
            {
                btnF2.Text = ResourceCulture.GetString("FrmForcePB_btnF2_OpenText");
                plc.WriteBoolen("DB2.DBX7.6", true);
            }
            else
            {
                btnF2.Text = ResourceCulture.GetString("FrmForcePB_btnF2_BlockText");
                plc.WriteBoolen("DB2.DBX7.6", false);
            }
        }

        private void btnF3_Click(object sender, System.EventArgs e)
        {
            if (btnF3.Text == ResourceCulture.GetString("FrmForcePB_btnF3_BlockText"))
            {
                btnF3.Text = ResourceCulture.GetString("FrmForcePB_btnF3_OpenText");
                plc.WriteBoolen("DB2.DBX7.7", true);
            }
            else
            {
                btnF3.Text = ResourceCulture.GetString("FrmForcePB_btnF3_BlockText");
                plc.WriteBoolen("DB2.DBX7.7", false);
            }
        }

        private void btnF4_Click(object sender, System.EventArgs e)
        {
            if (btnF4.Text == ResourceCulture.GetString("FrmForcePB_btnF4_BlockText"))
            {
                btnF4.Text = ResourceCulture.GetString("FrmForcePB_btnF4_OpenText");
                plc.WriteBoolen("DB2.DBX8.0", true);
            }
            else
            {
                btnF4.Text = ResourceCulture.GetString("FrmForcePB_btnF4_BlockText");
                plc.WriteBoolen("DB2.DBX8.0", false);
            }
        }

        private void FrmForcePB_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        
    }
}
