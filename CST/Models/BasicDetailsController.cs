using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class BasicDetailsController
    {
        crudFile cs = new crudFile();
     

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
                        string address)
        {

            string sql = String.Format(@"INSERT INTO student_detail(`sno`, `firstname`, `lastname`, `middlename`,
                                                                    `gender`, `age`, `CivilStatus`, `birthdate`, `pob`, `contact_no`, 
                                                                    `nationality`, `religion`, `address`) 
                                                                    VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                                        sno,firstname, lastname, middlename, gender, age, civil, birthday, pob, contact,
                                        nation, religion, address);

            cs.ExecuteQuery(sql);
        }

        public int getRecentStudentId()
        {
            string sql = String.Format(@"SELECT AUTO_INCREMENT as Last_id FROM information_schema.TABLES WHERE TABLE_NAME = 'student_detail'");
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
                                    nat,string rel,string add, string sno)
        {
            string sql = String.Format(@"UPDATE `student_detail` SET `firstname`='{0}',`lastname`='{1}',`middlename`='{2}',`gender`='{3}',
                                                            `age`='{4}',`CivilStatus`='{5}',`birthdate`='{6}',`pob`='{7}',`contact_no`='{8}',
                                                            `nationality`='{9}',`religion`='{10}',`address`='{11}' WHERE sno = '{12}'",
                                        fn,ln,mn,gen,age,civil,bd,pob,cn,nat,rel,add,sno);
            cs.ExecuteQuery(sql);
        }


       
        public void fillDataGridDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT sno,firstname,lastname,middlename,gender,age,CivilStatus,birthdate,pob,contact_no,nationality,religion,address 
                                        FROM student_detail WHERE student_id");

            cs.FillDataGrid(sql, ref dg);
        }

         public string[] searchAllDetails(string sno)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT * FROM student_detail WHERE sno = '{0}' ", sno);
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
