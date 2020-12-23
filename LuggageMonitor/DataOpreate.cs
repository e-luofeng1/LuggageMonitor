using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace LuggageMonitor
{
    public class DataOpreate
    {
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool insertCheckResult(CheckReultO result)
        {
            try
            {
                string cmdText = string.Format(
                        "insert into b_checkresult" +
                         "(BarCode,PartNo,ItemName,PartType,CheckTime,CheckReult,FoamBarCode,PicAdr,CreateTime,CreateMachine)"
                         + "values"
                         + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                         result.BarCode, result.PartNo, result.ItemName, result.PartType, result.CheckTime
                         , result.CheckReult, result.FoamBarCode, result.PicAdr, result.CreateTime, result.CreateMachine);
                int recordCount = MySqlDBHelper.ExecuteNonQuery(cmdText, MySqlDBHelper.connectionStringMYSQL);
                if (recordCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 查询检测结果
        /// </summary>
        /// <returns></returns>
        public DataTable getCheckReult(string barCode, string partNo, string ItemName, string startTime, string endTime, string checkResult)
        {
            try
            {
                string cmdText = "select * from b_checkresult where 1=1 ";
                cmdText += string.IsNullOrEmpty(barCode) ? " " : " and BarCode like '%" + barCode + "%' ";
                cmdText += string.IsNullOrEmpty(partNo) ? " " : " and PartNo like '%" + partNo + "%' ";
                cmdText += string.IsNullOrEmpty(ItemName) ? " " : " and ItemName like '%" + ItemName + "%' ";
                cmdText += string.IsNullOrEmpty(startTime) ? " " : " and CheckTime >= '" + startTime + "' ";
                cmdText += string.IsNullOrEmpty(endTime) ? " " : " and CheckTime <= '" + endTime + "' ";
                cmdText += string.IsNullOrEmpty(checkResult) ? " " : " and CheckReult like '%" + checkResult + "%' ";
                return MySqlDBHelper.ExecuteDataTable(cmdText, MySqlDBHelper.connectionStringMYSQL, null);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 检查条码是否扫描
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public static bool isCheck(string barCode)
        {
            string cmdText = "select * from b_checkresult where BarCode = '" + barCode + "' and CheckReult = 'OK'";
            return MySqlDBHelper.Exists(cmdText, MySqlDBHelper.connectionStringMYSQL);
        }
    }
}
