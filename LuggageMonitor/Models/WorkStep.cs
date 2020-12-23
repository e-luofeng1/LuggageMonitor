using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuggageMonitor
{
    public class WorkStep
    {
        private string num;

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        private string mistakeType;

        public string MistakeType
        {
            get { return mistakeType; }
            set { mistakeType = value; }
        }
        private string explain;

        public string Explain
        {
            get { return explain; }
            set { explain = value; }
        }
        private string setValue;

        public string SetValue
        {
            get { return setValue; }
            set { setValue = value; }
        }
        private bool isValid;

        public bool IsValid
        {
            get { return isValid; }
            set { isValid = value; }
        }

        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        private string currentValue;

        public string CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

    }
}
