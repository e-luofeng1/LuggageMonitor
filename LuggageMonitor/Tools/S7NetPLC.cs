using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S7.Net;

namespace LuggageMonitor
{
    public class S7NetPLC
    {
        public Plc plc;
        private bool conectStatus = false;//链接状态
        //链接状态属性
        public bool ConectStatus
        {
            get//读的属性
            {
                return conectStatus;//返回值
            }
            set//写的属性
            {
                conectStatus = value;//重新赋值
            }
        }
        //实例一个PLC
        public S7NetPLC(CpuType cpu, string IP, short rock, short solt)
        {
            plc = new Plc(cpu, IP, rock, solt);
        }
        /// <summary>
        /// 通过Ping链接PLC
        /// </summary>
        public void connectPLC()
        {

            try
            {
                if (plc.IsAvailable == true)
                {
                    if (conectStatus == false)
                    {
                        plc.Open();

                        if (plc.IsConnected == true)
                        {
                            conectStatus = true;//已链接

                        }
                    }
                }
                else
                {
                    //if (plc.IsConnected == true)
                    //{
                    if (plc != null)
                    {
                        plc.Close();
                    }
                    if (plc.IsConnected == false)
                    {
                        conectStatus = false;//通讯断开
                    }
                    //}
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 通过读取心跳链接PLC
        /// </summary>
        public void HeartConnectPLC(string readString)
        {
            bool HeartState = ConnState(readString);
            try
            {
                if (HeartState == false)
                {
                    if (conectStatus == true)
                    {
                        plc.Close();
                    }
                    conectStatus = false;
                    if (plc.IsAvailable == true)
                    {
                        plc.Open();
                        if (plc.IsConnected == true)
                        {
                            conectStatus = true;//已链接
                        }
                    }

                }
                else
                {
                    conectStatus = true;
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// 读取PLC某个Boolen变量判断PLC通讯状态
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public bool ConnState(string readString)
        {
            bool bolState = false;
            try
            {
                bool result = Convert.ToBoolean(plc.Read(readString));
                if (plc.LastErrorCode == 0)
                {
                    bolState = true;
                }
                else
                {
                    bolState = false;
                }
            }
            catch
            {
                bolState = false;
            }
            return bolState;
        }

        /// <summary>
        /// 读取多个变量
        /// </summary>
        /// <param name="numBytes"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <returns></returns>
        public List<byte> ReadMultipleBytes(int numBytes, int db, int startByteAdr)
        {
            List<byte> resultBytes = new List<byte>();
            int index = startByteAdr;
            while (numBytes > 0)
            {
                var maxToRead = (int)Math.Min(numBytes, 200);
                byte[] bytes = plc.ReadBytes(DataType.DataBlock, db, index, (int)maxToRead);
                if (bytes == null)
                    return new List<byte>();
                resultBytes.AddRange(bytes);
                numBytes -= maxToRead;
                index += maxToRead;
            }
            return resultBytes;
        }

        /// <summary>
        /// 读取多个字节
        /// </summary>
        /// <param name="numBytes"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <returns></returns>
        public byte[] ReadBytes(int numBytes, int db, int startByteAdr)
        {
            byte[] bytes = plc.ReadBytes(DataType.DataBlock, db, startByteAdr, numBytes);
            return bytes;
        }

        /// <summary>
        /// 读取字符串,繁琐版，可以不用
        /// </summary>
        /// <param name="numBytes"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <returns></returns>
        public string ReadStringBad(int numBytes, int db, int startByteAdr)
        {
            string outString = "";
            if (conectStatus == true)
            {
                try
                {
                    byte[] bytes = new byte[numBytes];
                    bytes = ReadBytes(numBytes, db, startByteAdr);
                    for (int i = 0; i <= numBytes - 1; i++)
                    {
                        byte S1 = (byte)bytes[i];
                        char S2 = (char)S1;
                        outString = outString + S2;
                    }

                }
                catch
                {
                    outString = "";
                }
            }
            return outString;
        }

        /// <summary>
        /// 读取字符串精简版
        /// </summary>
        /// <param name="numBytes"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <returns></returns>
        public string ReadStringGood(DataType DataBlock, int db, int startByteAdr, int varCount)
        {
            string outString = "";
            if (conectStatus == true)
            {
                try
                {
                    outString = plc.Read(DataBlock, db, startByteAdr, VarType.String, varCount).ToString();

                }
                catch
                {
                    outString = "";
                }
            }
            return outString;
        }
        /// <summary>
        /// 读取16位无符号整数
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public ushort readUshort(string readString)
        {
            ushort result = 0;
            if (conectStatus == true)
            {
                try
                {
                    result = (ushort)plc.Read("readString");

                }
                catch
                {
                    result = 0;
                }
            }
            return result;

        }

        /// <summary>
        /// 读取16位有符号整数
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public short readInt(string readString)
        {
            short result = 0;
            if (conectStatus == true)
            {
                try
                {
                    result = ((ushort)plc.Read(readString)).ConvertToShort();
                }
                catch
                {
                    result = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// 读取双整数
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public int readDInt(string readString)
        {
            int result = 0;
            if (conectStatus == true)
            {
                try
                {
                    result = ((uint)plc.Read(readString)).ConvertToInt();
                }
                catch
                {
                    result = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// 读取实数
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public double readReal(string readString)
        {
            double result = 0;
            if (conectStatus == true)
            {
                try
                {
                    result = ((uint)plc.Read(readString)).ConvertToDouble();

                }
                catch
                {
                    result = 0;
                }
            }
            return result;
        }
        /// <summary>
        /// 读取Boolen型变量
        /// </summary>
        /// <param name="readString"></param>读取字符串地址
        /// <returns></returns>
        public bool readBoolen(string readString)
        {
            bool result = false;
            if (conectStatus == true)
            {
                try
                {
                    var s = plc.Read(readString);
                    result = Convert.ToBoolean(plc.Read(readString));
                }
                catch
                {
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// 读取Struct结构数据
        /// </summary>
        /// <param name="readString"></param>
        public void readStruct(Type structType, int db, int startAddr)
        {
            if (conectStatus == true)
            {
                try
                {
                    plc.ReadStruct(structType, db, startAddr);
                }
                catch
                {

                }
            }

        }
        /// <summary>
        /// 写入字符串函数
        /// </summary>
        /// <param name="DataBlock"></param>//数据块类型
        /// <param name="db"></param>//DB块号码
        /// <param name="startByteAdr"></param>//起始地址
        /// <param name="stringWrite"></param>//写入字符串
        /// <param name="stringLength"></param>//字符总长度，只针对1200以上PLC，200不需要设置0
        /// <returns></returns>
        public bool WriteString(CpuType cpu, DataType DataBlock, int db, int startByteAdr, string stringWrite, byte stringLength = 0)
        {
            bool result = false;
            int Lentgh = stringWrite.Length;
            ErrorCode errcode;
            byte[] vaule = new byte[Lentgh + 2];
            byte[] array = System.Text.Encoding.ASCII.GetBytes(stringWrite);
            if (conectStatus == true)
            {
                if (cpu == CpuType.S71200 || cpu == CpuType.S71500 || cpu == CpuType.S7300 || cpu == CpuType.S7400)
                {
                    vaule[0] = stringLength;
                    vaule[1] = (byte)Lentgh;
                    for (int i = 0; i <= Lentgh - 1; i++)
                    {
                        vaule[i + 2] = (byte)array[i];
                    }
                }
                else if (cpu == CpuType.S7200)
                {
                    vaule[0] = (byte)Lentgh;
                    for (int i = 0; i <= Lentgh - 1; i++)
                    {
                        vaule[i + 1] = (byte)array[i];
                    }

                }

                try
                {
                    errcode = plc.WriteBytes(DataBlock, db, startByteAdr, vaule);
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;

        }
        /// <summary>
        /// 写入Boolen型函数
        /// </summary>
        /// <param name="writeString"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteBoolen(string writeString, bool value)
        {
            bool result = false;
            ErrorCode errcode;
            int bolInt = 0;
            if (value == true)
            {
                bolInt = 1;
            }
            else
            {
                bolInt = 0;
            }
            if (conectStatus == true)
            {
                try
                {
                    errcode = plc.Write(writeString, bolInt);
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        /// <summary>
        /// 写无符号16位整数
        /// </summary>
        /// <param name="writeString"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteWord(string writeString, ushort value)
        {
            bool result = false;
            ErrorCode errcode;
            if (conectStatus == true)
            {
                try
                {
                    errcode = plc.Write(writeString, value);
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        /// <summary>
        /// 写有符号16位整数
        /// </summary>
        /// <param name="writeString"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteShort(string writeString, short value)
        {
            bool result = false;
            ErrorCode errcode;
            if (conectStatus == true)
            {
                try
                {
                    errcode = plc.Write(writeString, value);
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        /// <summary>
        /// 写有符号32位整数
        /// </summary>
        /// <param name="writeString"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteInt(string writeString, int value)
        {
            bool result = false;
            ErrorCode errcode;
            if (conectStatus == true)
            {
                try
                {
                    errcode = plc.Write(writeString, value);
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        /// <summary>
        /// 写实数函数
        /// </summary>
        /// <param name="writeString"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteReal(string writeString, double value)
        {
            bool result = false;
            ErrorCode errcode;
            if (conectStatus == true)
            {
                try
                {
                    errcode = plc.Write(writeString, value.ConvertToUInt());
                    if (errcode == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                }
            }
            return result;
        }
    }

}
