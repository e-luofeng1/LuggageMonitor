using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketHelper;

namespace LuggageMonitor
{
    public partial class SendMesToCamear : Form
    {
        public SendMesToCamear()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            axTcpClient1.ServerIp = TxtIp.Text;
            axTcpClient1.ServerPort = int.Parse(TxtPort.Text);
            axTcpClient1.StartConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axTcpClient1.StopConnection();
        }
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="date"></param>
        private void axTcpClient1_OnReceviceByte(byte[] date)
        {
            try
            {
                string msg = "";
                if (checkBox1.Checked)
                {
                    //以十六进制格式显示数据
                    msg = IntegerOrString.HexByteArrayToString(date);
                }
                else
                {
                    ////以文本转ASCIIEncoding转码形式显示数据
                    msg = Encoding.Default.GetString(date);
                }
                if (MsgInfomationList.Items.Count > 50)
                    MsgInfomationList.Items.Clear();
                //自定义处理接收Socket数据
                MsgInfomationList.Items.Add(msg);
                MsgInfomationList.Show();
            }
            catch
            {

            }
        }
        /// <summary>
        /// 接收状态数据
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="state">状态码</param>
        private void StateInfoCallBack(string msg, SocketState state)
        {
            try
            {
                if (StateInfoList.Items.Count > 50)
                    StateInfoList.Items.Clear();
                //自定义处理状态数据
                StateInfoList.Items.Add(msg);

            }
            catch
            {

            }
        }

        /// <summary>
        /// 接收错误数据
        /// </summary>
        /// <param name="msg"></param>
        private void ErrorMsgCallBack(string msg)
        {
            try
            {
                if (ErrorMsgList.Items.Count > 50)
                    ErrorMsgList.Items.Clear();
                //自定义处理错误数据
                ErrorMsgList.Items.Add(msg);
            }
            catch
            {
            }
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string sendmsg = TxtSendMsg.Text;
                byte[] sendByte;
                if (checkBox2.Checked)
                {
                    //以十六进制字符串发送
                    sendByte = IntegerOrString.StringToHexByteArray(sendmsg);
                }
                else
                {
                    //以ASCIIEncoding转码形式发送
                    sendByte = Encoding.Default.GetBytes(sendmsg);
                }
                axTcpClient1.SendCommand(sendByte);
            }
            catch
            {
            }
        }
    }
}
