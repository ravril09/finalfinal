using System;
using System.Collections.Generic;
using System.Data.Common;
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


        public async Task<int> getLatestNo()
        {
            int lastno = 0;
            string sql = @"SELECT * FROM `membership_fee` ORDER BY `membership_fee`.`ID` DESC LIMIT 1";

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, null);

            if( await reader.ReadAsync())
            {
                lastno = int.Parse(reader["ID"].ToString());
            }

            cs.CloseConnection();

            return lastno;

        }


    }
}