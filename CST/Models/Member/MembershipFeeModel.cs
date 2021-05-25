using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.Member
{
    class MembershipFeeModel
    {

        public int id { get; set; }
        public string sno { get; set; }
        public int Payment { get; set; }
        public string name { get; set; }
        public int TotalCont { get; set; }
    }
}
