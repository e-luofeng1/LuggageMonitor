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
using System.Configuration;

namespace LuggageMonitor
{
    
    public partial class PwdInput : CCSkinMain
    {
        string CurrentCulture = "";
        public static  bool CanOpreate = false;
        public PwdInput(string CurrentCulture)
        {
            InitializeComponent();
            txtInpteSign.Text = "...";
            txtPwd.Text = "";
            txtPwd.Focus();
            this.CurrentCulture = CurrentCulture;
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            SetResourceCulture();
        }
        public void SetResourceCulture()
        {
            this.Text = ResourceCulture.GetString("PwdInput_lblPlesaseInptPwd_Text");
            this.lblPlesaseInptPwd.Text = ResourceCulture.GetString("PwdInput_lblPlesaseInptPwd_Text");
            this.btnOK.Text = ResourceCulture.GetString("PwdInput__btnOK_Text");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string inptPwd = txtPwd.Text.Trim();
            string setPwd = ConfigurationManager.AppSettings["pwd"];
            if (inptPwd.Equals(setPwd))
            {
                CanOpreate = true;
                this.Close();
            }
            else
            {
                txtInpteSign.Text = ResourceCulture.GetString("PwdInput_txtInpteSign_Text");
                txtPwd.Focus();
            }
        }
    }
}
