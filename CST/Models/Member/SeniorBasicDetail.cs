using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.Member
{
    class SeniorBasicDetail
    {

        public int senior_id { get; set; }
        public string sno { get; set; }
        public string firstname {get;set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string civilstatus { get; set; }
        public string birthdate { get; set; }
        public string pob { get; set; }
        public string cno { get; set; }
        public string eduAt { get; set; }
        public string nat { get; set; }
        public string religion { get; set; }
        public string address { get; set; }
        public string imgPath { get; set; }
        public string imgPath2 { get; set; }
        public int payment { get; set; }

        public string fullName
        {
            get
            {
                return $"{firstname} {middlename} {lastname}";
            }
        }
    }
}
