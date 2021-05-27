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

        public async Task save(List<string> temp,string sno)
        {
            string sql = @"INSERT INTO `senior_fp`(`fp_tp_1`, `fp_tp_2`, `fp_tp_3`, 
                                `fp_imgPath_1`, `fp_imgPath_2`, `fp_imgPath_3`, `sno`) 
                    VALUES (@temp1,@temp2,@temp3,@imgpath1,@imgpath2,@imgpath3,@sno)";

            string path1 = $"C:\\fp\\{sno}-1-fp.png";
            string path2 = $"C:\\fp\\{sno}-2-fp.png";
            string path3 = $"C:\\fp\\{sno}-3-fp.png";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@temp1",temp[0])),
                (new MySqlParameter("@temp2",temp[1])),
                (new MySqlParameter("@temp3",temp[2])),
                (new MySqlParameter("@imgpath1",path1)),
                (new MySqlParameter("@imgpath2",path2)),
                (new MySqlParameter("@imgpath3",path3)),
                (new MySqlParameter("@sno",sno))
            };

           await crud.ExecuteAsync(sql, mySqlParameters);
        }

        public async Task<List<FpModels>> getDataTempStr()
        {

            List<FpModels> listFPModels = new List<FpModels>();

            string sql = @"SELECT * FROM senior_fp";


            DbDataReader reader = await crud.RetrieveRecordsAsync(sql, null);

            while(await reader.ReadAsync())
            {
                FpModels fpModels = new FpModels();
                fpModels.id = int.Parse(reader["fp_id"].ToString());
                fpModels.fp1 = reader["fp_tp_1"].ToString();
                fpModels.fp2 = reader["fp_tp_2"].ToString();
                fpModels.fp3 = reader["fp_tp_3"].ToString();

                fpModels.fpPath1 = reader["fp_imgPath_1"].ToString();
                fpModels.fpPath2 = reader["fp_imgPath_2"].ToString();
                fpModels.fpPath3 = reader["fp_imgPath_3"].ToString();

                fpModels.sno = reader["sno"].ToString();
                listFPModels.Add(fpModels);
            }
            crud.CloseConnection();

            return listFPModels;
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
