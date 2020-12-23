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

namespace LuggageMonitor
{
    public partial class HisSelect : CCSkinMain
    {
        string CurrentCulture;
        /// <summary>
        /// 初始化
        /// </summary>
        public void initCbox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("value");
            DataRow dr = dt.NewRow();
            dr[0] = "OK";
            dr[1] = "OK";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "NG";
            dr1[1] = "NG";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "";
            dr2[1] = "";
            dt.Rows.Add(dr2);
            this.cboReult.DataSource = dt;
            this.cboReult.DisplayMember = "name";
            this.cboReult.ValueMember = "value";

            txtStartTime.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");

        }
        public HisSelect(string CurrentCulture)
        {
            InitializeComponent();
            initCbox();
            this.CurrentCulture = CurrentCulture;
        }

        public void SetResourceCulture()
        {
            ResourceCulture.SetCurrentCulture(CurrentCulture);
            this.Text = ResourceCulture.GetString("HisSelect_Text");
            this.pnlCondition.Text = ResourceCulture.GetString("HisSelect_pnlCondition_Text");
            this.lblBarCode.Text = ResourceCulture.GetString("HisSelect_lblBarCode_Text");
            this.lblPartNo.Text = ResourceCulture.GetString("HisSelect_lblPartNo_Text");
            this.lblItemName.Text = ResourceCulture.GetString("HisSelect_lblItemName_Text");
            this.lblCheckTimeS.Text = ResourceCulture.GetString("HisSelect_lblCheckTimeS_Text");
            this.lblCheckTimeTo.Text = ResourceCulture.GetString("HisSelect_lblCheckTimeTo_Text");
            this.lblResult.Text = ResourceCulture.GetString("HisSelect_lblResult_Text");
            this.btnSelect.Text = ResourceCulture.GetString("HisSelect_btnSelect_Text");
            this.btnReset.Text = ResourceCulture.GetString("HisSelect_btnReset_Text");
            this.pnlSelectResult.Text = ResourceCulture.GetString("HisSelect_pnlSelectResult_Text");

            gridData.Columns["BarCode"].HeaderText
                 = ResourceCulture.GetString("HisSelect_grid_BarCode_HeaderText");
            gridData.Columns["PartNo"].HeaderText
                  = ResourceCulture.GetString("HisSelect_grid_PartNo_HeaderText");
            gridData.Columns["ItemName"].HeaderText
                   = ResourceCulture.GetString("HisSelect_grid_ItemName_HeaderText");
            gridData.Columns["PartType"].HeaderText
                 = ResourceCulture.GetString("HisSelect_grid_PartType_HeaderText");
            gridData.Columns["CheckTime"].HeaderText
                 = ResourceCulture.GetString("HisSelect_grid_CheckTime_HeaderText");
            gridData.Columns["CheckReult"].HeaderText
                  = ResourceCulture.GetString("HisSelect_grid_CheckReult_HeaderText");
            gridData.Columns["FoamBarCode"].HeaderText
                = ResourceCulture.GetString("HisSelect_grid_FoamBarCode_HeaderText");
            gridData.Columns["PicAdr"].HeaderText
                = ResourceCulture.GetString("HisSelect_grid_PicAdr_HeaderText");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string barCode = txtBarCode.Text.Trim();
            string partNo = txtPartNo.Text.Trim();
            string itemName = txtItemName.Text.Trim();
            string startTime = txtStartTime.Text;
            string endTime = txtEndTime.Text;
            string checkReult = cboReult.SelectedValue == null ? "": cboReult.SelectedValue.ToString();

            DataOpreate opreate = new DataOpreate();
            gridData.DataSource = opreate.getCheckReult(barCode, partNo, itemName, startTime, endTime, checkReult);
            gridData.AutoGenerateColumns = false;
            gridData.Refresh();
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBarCode.Text = "";
            txtPartNo.Text = "";
            txtItemName.Text = "";
            this.cboReult.SelectedIndex = -1;
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }


    }
}
