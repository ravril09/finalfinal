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
                                string paymentDate,
                                int payment
                                )
        {
            string sql = String.Format(@"INSERT INTO `membership_fee`(`sno`, `payment_date`, `Payment`) VALUES ('{0}','{1}','{2}')",
                                        sno, paymentDate, payment);

            cs.ExecuteQuery(sql);

        }
    }
}