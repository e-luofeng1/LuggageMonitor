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
using S7.Net;
namespace LuggageMonitor.TestPLC
{
   
    public partial class SIEMENS :CCSkinMain
    {
        S7NetPLC s71200;
        public SIEMENS()
        {
           
            InitializeComponent();
        }
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIP.Text.Trim();
                short rack = Convert.ToInt16(txtRack.Text.Trim());
                short slot = Convert.ToInt16(txtSlot.Text.Trim());
                 s71200 = new S7NetPLC(CpuType.S71200, ip, rack, slot);
                //s71200 = new Plc(CpuType.S71200, ip, rack, slot);
                s71200.connectPLC();
                if (s71200.ConectStatus)
                {
                    txtOut.Text = "PLC已连接!";
                    btnConnect.Enabled = false;
                    btnUnConnect.Enabled = true;
                    btnRead.Enabled = true;
                    btnWrite.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                txtOut.Text = ex.Message;
            }
        }
        /// <summary>
        /// 断开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //s71200.();
                //if (!s71200.IsConnected)
                //{
                //    txtOut.Text = "PLC已断开!";
                //    btnConnect.Enabled = true;
                //    btnUnConnect.Enabled = false;
                //    btnRead.Enabled = false;
                //    btnWrite.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                txtOut.Text = ex.Message;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int Data_Type_Value = 0;
            if (cboDataType.Text == "Bool") Data_Type_Value = 1;
            else if (cboDataType.Text == "Int") Data_Type_Value = 2;
            else if (cboDataType.Text == "DInt") Data_Type_Value = 3;
            else if (cboDataType.Text == "Real") Data_Type_Value = 4;
            else Data_Type_Value = 0;

            switch (Data_Type_Value)
            {
                case 1:
                    Current_Value.Text = s71200.readBoolen(DB_Number.Text).ToString();
                    break;
                case 2:
                   // Current_Value.Text = Convert.ToString(s71200.Read(S7.Net.DataType.DataBlock,
                    //Convert.ToInt16(DB_Number.Text), Convert.ToInt16(Start_Address.Text), VarType.Int, 1, 0));
                    break;
                case 3:
                   // Current_Value.Text = Convert.ToString(s71200.Read(S7.Net.DataType.DataBlock,
                    //Convert.ToInt16(DB_Number.Text), Convert.ToInt16(Start_Address.Text), VarType.DInt, 1, 0));
                    break;
                case 4:
                   // Current_Value.Text = Convert.ToString(s71200.Read(S7.Net.DataType.DataBlock,
                   // Convert.ToInt16(DB_Number.Text), Convert.ToInt16(Start_Address.Text), VarType.Real, 1, 0));
                    break;
                default: break;
            }
        }
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            int Data_Type_Value = 0;
            if (cboDataType.Text == "Bool") Data_Type_Value = 1;
            else if (cboDataType.Text == "Int") Data_Type_Value = 2;
            else if (cboDataType.Text == "DInt") Data_Type_Value = 3;
            else if (cboDataType.Text == "Real") Data_Type_Value = 4;
            else Data_Type_Value = 0;


            switch (Data_Type_Value)
            {

                case 1:
                    //s71200.WriteBit(S7.Net.DataType.DataBlock, Convert.ToInt16(DB_Number.Text),
                   //Convert.ToInt16(Start_Address.Text), 0, Convert.ToBoolean(Write_Value.Text));
                    break;
                case 2:
                    //s71200.Write(S7.Net.DataType.DataBlock, Convert.ToInt16(DB_Number.Text),
                    //Convert.ToInt16(Start_Address.Text), Convert.ToInt16(Write_Value.Text));
                    break;
                case 3:
                    //s71200.Write(S7.Net.DataType.DataBlock, Convert.ToInt16(DB_Number.Text),
                    //Convert.ToInt16(S7.Net.DataType.DataBlock), Convert.ToInt32(Write_Value.Text));
                    break;
                case 4:
                    //s71200.Write(S7.Net.DataType.DataBlock, Convert.ToInt16(DB_Number.Text),
                    //Convert.ToInt16(Start_Address.Text), Convert.ToDouble(Write_Value.Text));
                    break;
                default: break;
            }
        }

        private void SIEMENS_Load(object sender, EventArgs e)
        {
          
            cboDataType.Items.Add("Bool");
            cboDataType.Items.Add("Int");
            cboDataType.Items.Add("DInt");
            cboDataType.Items.Add("Real");
            cboDataType.Text = "Real";

            btnUnConnect.Enabled = false;
            btnRead.Enabled = false;
            btnWrite.Enabled = false;
        }
    }
}
