using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models.Member;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class IDDetailsController
    {
        crudFile cs = new crudFile();
       public IDDetailsController()
        {

        }


        public async Task<SeniorIdDetails> getModel(string sno)
        {
            SeniorIdDetails seniorIdDetails = new SeniorIdDetails();
            string sql = @"SELECT * FROM senior_id_details WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);


            while(await reader.ReadAsync())
            {

                seniorIdDetails.senior_id = int.Parse(reader["senior_id"].ToString());
                seniorIdDetails.sno = reader["sno"].ToString();
                seniorIdDetails.osca = reader["OSCA"].ToString();
                seniorIdDetails.tin = reader["TIN"].ToString();
                seniorIdDetails.ph = reader["PHILHEALTH"].ToString();
                seniorIdDetails.gsis = reader["GSIS"].ToString();
                seniorIdDetails.sss = reader["SSS"].ToString();



            }
            cs.CloseConnection();
            return seniorIdDetails;

        }

        public void addIDDetails(string sno,
                                 string osca,
                                 string tin,
                                 string philhealth,
                                 string gsis,
                                 string sss
                                 )
        {
            string sql = String.Format(@"INSERT INTO `senior_id_details`(`sno`, `OSCA`, `TIN`, `PHILHEALTH`, `GSIS`, `SSS`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                        sno, osca, tin, philhealth, gsis, sss);

            cs.ExecuteQuery(sql);

        }

        public void updateHisDetails(string sno,
                                    string osca,
                                    string tin,
                                    string phil,
                                    string gsis,
                                    string sss                                   
                                    )
        {
            string sql = String.Format(@"UPDATE `senior_id_details` 
                                                        SET `OSCA`='{0}',`TIN`='{1}',`PHILHEALTH`='{2}',`GSIS`='{3}',`SSS`='{4}' WHERE sno = '{5}'",
                                                            osca, tin, phil, gsis, sss
                                                            ,sno);

            cs.ExecuteQuery(sql);
        }

        public void fillDataHist(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT 
                                           `senior_id`,`sno`, `OSCA`, `TIN`, `PHILHEALTH`, `GSIS`, `SSS` FROM `senior_id_details` WHERE senior_id");

            cs.FillDataGrid(sql, ref dg);
        }


        public string[] getIDDetails(string sno)
        {
            string[] IDDetail = new string[7];

            string sql = String.Format(@"SELECT * FROM `senior_id_details` WHERE sno = '{0}'", sno);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                IDDetail[0] = reader["OSCA"].ToString();
                IDDetail[1] = reader["TIN"].ToString();
                IDDetail[2] = reader["PHILHEALTH"].ToString();
                IDDetail[3] = reader["GSIS"].ToString();
                IDDetail[4] = reader["SSS"].ToString();
                
            }

            cs.CloseConnection();
            return IDDetail;
        }
        public void deleteIdDetails(int id)
        {
            string sql = String.Format(@"DELETE FROM senior_id_details WHERE senior_id = {0}", id);

            cs.ExecuteQuery(sql);
        }
    }
}
