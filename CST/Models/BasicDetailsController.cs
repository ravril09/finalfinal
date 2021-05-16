using CST.Models.Member;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class BasicDetailsController
    {
        crudFile cs = new crudFile();
     

        public async Task<DataSet> getDs()
        {
            DataSet ds = await cs.GetDataSetAsync(@"SELECT senior_basic_detail.senior_id, CONCAT(lastname,',',firstname) AS 'Name' ,
                                                    address,birthdate,gender,age, senior_id_details.membershipfee,senior_id_details.monthlyfee 
                                                    FROM `senior_basic_detail` INNER JOIN senior_id_details ON senior_id_details.sno = senior_basic_detail.sno",
                null);

            return ds;
        }

        public void addStudDetails(string sno,
                        string firstname,
                        string lastname,
                        string middlename,
                        string gender,
                        int age,
                        string civil,
                        string birthday,
                        string pob,
                        string contact,
                        string nation,
                        string religion,
                        string EduAt,
                        string address)
        {

            string sql = String.Format(@"INSERT INTO senior_basic_detail(`sno`, `firstname`, `lastname`, `middlename`,
                                                                    `gender`, `age`, `CivilStatus`, `birthdate`, `pob`, `contact_no`, 
                                                                    `nationality`, `religion`, `Education_Attainment`, `address`) 
                                                                    VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                                        sno,firstname, lastname, middlename, gender, age, civil, birthday, pob, contact,
                                        nation, religion, EduAt, address);

            cs.ExecuteQuery(sql);
        }

        public int getRecentStudentId()
        {
            string sql = String.Format(@"SELECT AUTO_INCREMENT as Last_id FROM information_schema.TABLES WHERE TABLE_NAME = 'senior_basic_detail'");
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int last_id = 0;
            if (reader.Read())
            {
                last_id = int.Parse(reader["Last_id"].ToString());
            }
            cs.CloseConnection();
            return last_id;
        }

        public void updateStudDetails(string fn,string ln,string mn,string gen,int age,
                                    string civil,string bd,string pob, string cn,string 
                                    nat,string rel,string EducAt, string add, string sno)
        {
            string sql = String.Format(@"UPDATE `senior_basic_detail` SET `firstname`='{0}',`lastname`='{1}',`middlename`='{2}',`gender`='{3}',
                                                            `age`='{4}',`CivilStatus`='{5}',`birthdate`='{6}',`pob`='{7}',`contact_no`='{8}',
                                                            `nationality`='{9}',`religion`='{10}',`Education_Attainment`='{11}' ,`address`='{12}' WHERE sno = '{13}'",
                                        fn,ln,mn,gen,age,civil,bd,pob,cn,nat,rel,EducAt,add,sno);
            cs.ExecuteQuery(sql);
        }


        public async Task<SeniorBasicDetail> getModel(string sno)
        {
            SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
            string sql = @"SELECT * FROM senior_basic_detail WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);

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
                seniorBasicDetail.eduAt = reader["Education_Attainment"].ToString();
                seniorBasicDetail.pob = reader["pob"].ToString();
                seniorBasicDetail.cno = reader["contact_no"].ToString();
                seniorBasicDetail.nat = reader["nationality"].ToString();
                seniorBasicDetail.religion = reader["religion"].ToString();
                seniorBasicDetail.address = reader["address"].ToString();
                seniorBasicDetail.imgPath = reader["imgPath"].ToString();
                seniorBasicDetail.imgPath2 = reader["imgPath2"].ToString();
            }


            cs.CloseConnection();

            return seniorBasicDetail;
        }


        public async Task updateImgPath(string path,string sno)
        {
            string sql = @"UPDATE senior_basic_detail SET imgPath = @img WHERE sno  = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@img",path)),
                (new MySqlParameter("@sno",sno))
            };

            await cs.ExecuteAsync(sql, mySqlParameters);
        }


        public async Task updateImgPath2(string path, string sno)
        {
            string sql = @"UPDATE senior_basic_detail SET imgPath2 = @img WHERE sno  = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@img",path)),
                (new MySqlParameter("@sno",sno))
            };

            await cs.ExecuteAsync(sql, mySqlParameters);
        }

        public async Task<string> getImgPath(string sno)
        {
            string imgPath = "";
            string sql = @"SELECT * FROM senior_basic_detail WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);

            if(await reader.ReadAsync())
            {
                imgPath = reader["imgPath"].ToString();
            }


            cs.CloseConnection();


            return imgPath;
        }

       
        public void fillDataGridDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT sno,firstname,lastname,middlename,gender,age,CivilStatus,birthdate,pob,contact_no,nationality,religion,Education_Attainment,address
                                        FROM senior_basic_detail WHERE senior_id");

            cs.FillDataGrid(sql, ref dg);
        }

         public string[] searchAllDetails(string sno)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT * FROM senior_basic_detail WHERE sno = '{0}' ", sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                details[0] = reader["firstname"].ToString();
                details[1] = reader["lastname"].ToString();
                details[2] = reader["middlename"].ToString();
                details[3] = reader["gender"].ToString();
                details[4] = reader["age"].ToString();
                details[5] = reader["CivilStatus"].ToString();
                details[7] = reader["pob"].ToString();
                details[8] = reader["contact_no"].ToString();
                details[9] = reader["nationality"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
                // details[12] = reader["grade_level"].ToString();
            }

            cs.CloseConnection();
            return details;
        }
    
    }
}
