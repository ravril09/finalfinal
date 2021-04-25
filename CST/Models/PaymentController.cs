using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class PaymentController
    {
        crudFile cs = new crudFile();

        public void addPayment(string sno,
                                int memship,
                                int monthly
                                ) {
            string sql = String.Format(@"INSERT INTO `payments`(`sno`, `membershipfee`, `monthlyfee`) VALUES ('{0}','{1}','{2}')",
                                        sno, memship, monthly);

            cs.ExecuteQuery(sql);

        }

        public void updatePayment(string sno,
                                    int memship,
                                    int monthly)
        {
            string sql = String.Format(@"UPDATE `payments` SET `membershipfee`='{0}',`monthlyfee`='{1}' WHERE sno = '{2}'",
                                        memship , monthly , sno);

            cs.ExecuteQuery(sql);
        }
    }
}
