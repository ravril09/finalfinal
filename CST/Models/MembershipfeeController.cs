using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class MembershipfeeController
    {
        crudFile cs = new crudFile();

        public void addMembershipfee(string sno,
                                float payment
                                )
        {
            string sql = String.Format(@"INSERT INTO `membership_fee`(`sno`, `Payment`) VALUES ('{0}',{1})",
                                        sno, payment);

            cs.ExecuteQuery(sql);

        }



    }
}