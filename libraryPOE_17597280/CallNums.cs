using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryPOE_17597280
{
    public class CallNums
    {
        private string CN;
        private string Description;

        public CallNums(string cN, string description)
        {
            CN1 = cN;
            Description1 = description;
        }

        public string CN1 { get => CN; set => CN = value; }
        public string Description1 { get => Description; set => Description = value; }
    }
}
