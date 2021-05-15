using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using CST.Models.Member;
using System.Data.Common;

namespace CST.Models
{
    class FpController
    {
        crudFile crud = new crudFile();

        public async Task save(string temp,string imgpath,string sno)
        {
            string sql = @"INSERT INTO `senior_fp`(`fp_template`, `fp_imgPath`, `sno`) 
                        VALUES (@temp,@imgpath,@sno)";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@temp",temp)),
                (new MySqlParameter("@imgpath",imgpath)),
                (new MySqlParameter("@sno",sno))
            };

           await crud.ExecuteAsync(sql, mySqlParameters);
        }

        public async Task<Dictionary<string,string>> getDataTempStr()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string sql = @"SELECT * FROM senior_fp";


            DbDataReader reader = await crud.RetrieveRecordsAsync(sql, null);

            while(await reader.ReadAsync())
            {
                data.Add(reader["sno"].ToString(), reader["fp_template"].ToString());
            }
            crud.CloseConnection();

            return data;
        }

        public async Task<SeniorBasicDetail> getData(string temp)
        {
          
            SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
            string sql = @"SELECT * FROM senior_basic_detail WHERE sno in (SELECT sno FROM senior_fp WHERE fp_template = @temp)";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@temp",temp))
            };

            DbDataReader reader = await crud.RetrieveRecordsAsync(sql, mySqlParameters);

            while (await reader.ReadAsync())
            {

                seniorBasicDetail.senior_id = int.Parse(reader["senior_id"].ToString());
                seniorBasicDetail.sno = reader["sno"].ToString();
                seniorBasicDetail.firstname = reader["firstname"].ToString();
                seniorBasicDetail.middlename = reader["middlename"].ToString();
                seniorBasicDetail.lastname = reader["lastname"].ToString();
                seniorBasicDetail.civilstatus = reader["CivilStatus"].ToString();
                seniorBasicDetail.age = int.Parse(reader["age"].ToString());
                seniorBasicDetail.gender = reader["gender"].ToString();
                seniorBasicDetail.birthdate = reader["birthdate"].ToString();
                seniorBasicDetail.pob = reader["pob"].ToString();
                seniorBasicDetail.cno = reader["contact_no"].ToString();
                seniorBasicDetail.nat = reader["nationality"].ToString();
                seniorBasicDetail.religion = reader["religion"].ToString();
                seniorBasicDetail.address = reader["address"].ToString();
                seniorBasicDetail.imgPath = reader["imgPath"].ToString();
                seniorBasicDetail.imgPath2 = reader["imgPath2"].ToString();
            }


            crud.CloseConnection();

            return seniorBasicDetail;
        }

    }
}
