using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class ChildrenDetailsController
    {
        crudFile cs = new crudFile();
       
        public void addFamDetails(string sno,
                                  string c1name,
                                  string c1no,
                                  string c1add,
                                  string c2name,
                                  string c2no,
                                  string c2add,
                                  string c3name,
                                  string c3no,
                                  string c3add,
                                  string emename,
                                  string emeadd,
                                  string emerela,
                                  string emeno) 
        {
            string sql = String.Format(@"INSERT INTO `student_family_details`
                                                    (`sno`, `children1_name`, `children1_no`, `children1_address`, `children2_name`,
                                                     `children2_no`, `children2_address`, `children3_name`, `children3_no`, `children3_address`,
                                                     `emergency_name`, `emergency_address`, `emergency_relation`, `emergency_contact`) VALUES 
                                                                       ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                                        sno,c1name, c1no, c1add, c2name, c2no, c2add, c3name, c3no, c3add,
                                        emename, emeadd , emerela , emeno);
            cs.ExecuteQuery(sql);

        }


        public string[] getAllFamDetails(string sno)
        {

            string[] famDetails = new string[12];

            string sql = String.Format(@"SELECT * FROM `student_family_details` WHERE sno = '{0}'", sno);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                famDetails[0] = reader["children1_name"].ToString() == null ? "" : reader["children1_name"].ToString(); ;
                famDetails[1] = reader["children1_no"].ToString() == null ? "" : reader["children1_no"].ToString(); ;
                famDetails[2] = reader["children1_address"].ToString() == null ? "" : reader["children1_address"].ToString(); ; 
               
                famDetails[3] = reader["children2_name"].ToString() == null ? "" : reader["children2_name"].ToString(); ; 
                famDetails[4] = reader["children2_no"].ToString() == null ? "" : reader["children2_no"].ToString(); ;
                famDetails[5] = reader["children2_address"].ToString() == null ? "" : reader["children2_address"].ToString(); ;

                famDetails[6] = reader["children3_name"].ToString() == null ? "" : reader["children3_name"].ToString(); ; 
                famDetails[7] = reader["children3_no"].ToString() == null ? "" : reader["children3_no"].ToString(); ;
                famDetails[8] = reader["children3_address"].ToString() == null ? "" : reader["children3_address"].ToString(); ;
                

                famDetails[9] = reader["emergency_name"].ToString();
                famDetails[10] = reader["emergency_address"].ToString();
                famDetails[11] = reader["emergency_relation"].ToString();
                famDetails[12] = reader["emergency_contact"].ToString();
              
            }

            cs.CloseConnection();
            return famDetails;
        }

        public void updateFamDetails(string sno,string c1na, string c1n, string c1ad, string c2na, string c2n ,
                                    string c2ad, string c3na, string c3n, string c3ad, string en, string ead, string erl, string econ)
        {
            string sql = String.Format(@"UPDATE `student_family_details`
                                                        SET `children1_name`='{0}',`children1_no`='{1}',`children1_address`='{2}',`children2_name`='{3}',
                                                        `children2_no`='{4}',`children2_address`='{5}',`children3_name`='{6}',`children3_no`='{7}',
                                                        `children3_address`='{8}',`emergency_name`='{9}',`emergency_address`='{10}',`emergency_relation`='{11}',
                                                        `emergency_contact`='{12}'
                                                         WHERE sno = '{13}'",
                                        c1na, c1n, c1ad, c2na, c2n, c2ad, c3na, c3n,
                                       c3ad, en, ead, erl, econ, sno);
       
            cs.ExecuteQuery(sql);
        }

        public void filldataGridFam(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT `sno`, `children1_name`, `children1_no`, `children1_address`, `children2_name`, 
                                            `children2_no`, `children2_address`, `children3_name`, `children3_no`, `children3_address`,
                                                `emergency_name`, `emergency_address`, `emergency_relation`, `emergency_contact` FROM
                                                `student_family_details` WHERE student_fam_id");

            cs.FillDataGrid(sql,ref dg);
        }
    }
}
