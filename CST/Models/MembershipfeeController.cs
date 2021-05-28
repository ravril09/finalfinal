using CST.Models.Member;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (await reader.ReadAsync())
            {
                lastno = int.Parse(reader["ID"].ToString());
            }

            cs.CloseConnection();

            return lastno;

        }

        public async Task<float> getTotalPayment(string sno)
        {
            float totalPayment = 0;
           // SeniorPayment seniorPayment = new SeniorPayment();

            string sql = @"SELECT SUM(Payment) as 'total' FROM membership_fee WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);
            if (await reader.ReadAsync())
            {
                totalPayment = string.IsNullOrEmpty(reader["total"].ToString()) ? 0 :
                      float.Parse(reader["total"].ToString());
                //seniorPayment.sno = reader["total"].ToString();
             
            }

            cs.CloseConnection();

            return totalPayment;
        }


    }
}