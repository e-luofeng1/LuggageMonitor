using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuggageMonitor
{

    public class CheckReultO
    {
        public CheckReultO() { }

        public CheckReultO(string barCode, string partNo, string itemName, string partType,
            DateTime checkTime, string checkReult, string foamBarCode, string picAdr, DateTime createTime, string createMachine) 
        {
            this.barCode = barCode;
            this.partNo = partNo;
            this.itemName = itemName;
            this.partType = partType;
            this.checkTime = checkTime;
            this.checkReult = checkReult;
            this.foamBarCode = foamBarCode;
            this.picAdr = picAdr;
            this.createTime = createTime;
            this.createMachine = createMachine;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string barCode;

        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }
        private string partNo;

        public string PartNo
        {
            get { return partNo; }
            set { partNo = value; }
        }
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string partType;

        public string PartType
        {
            get { return partType; }
            set { partType = value; }
        }
        private DateTime checkTime;

        public DateTime CheckTime
        {
            get { return checkTime; }
            set { checkTime = value; }
        }
        private string checkReult;

        public string CheckReult
        {
            get { return checkReult; }
            set { checkReult = value; }
        }
        private string foamBarCode;

        public string FoamBarCode
        {
            get { return foamBarCode; }
            set { foamBarCode = value; }
        }
        private string picAdr;

        public string PicAdr
        {
            get { return picAdr; }
            set { picAdr = value; }
        }
        private DateTime createTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string createMachine;

        public string CreateMachine
        {
            get { return createMachine; }
            set { createMachine = value; }
        }
    }
}
