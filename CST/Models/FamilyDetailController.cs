using CST.Models.Member;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class FamilyDetailController
    {
        crudFile cs = new crudFile();

        public void addFamilyDetails(string sno,
                                     string f1name,
                                     string f1rel,
                                     string f1age,
                                     string f1occ,
                                     string f1income,
                                     string f2name,
                                     string f2rel,
                                     string f2age,
                                     string f2occ,
                                     string f2income,
                                     string f3name,
                                     string f3rel,
                                     string f3age,
                                     string f3occ,
                                     string f3income,
                                     string f4name,
                                     string f4rel,
                                     string f4age,
                                     string f4occ,
                                     string f4income,
                                     string f5name,
                                     string f5rel,
                                     string f5age,
                                     string f5occ,
                                     string f5income
                                    )
        {
            string sql = String.Format(@"INSERT INTO `nationalid_family_detail`
                                                (`sno`, `f1fullname`, `f1relationship`, `f1age`, `f1occupation`, `income`, `f2fullname`,
                                                `f2relationship`, `f2age`, `f2occupation`, `f2income`, `f3fullname`, `f3relationship`, 
                                                `f3age`,`f3occupation`, `f3income`, `f4fullname`, `f4relationship`, `f4age`,
                                                `f4occupation`, `f4income`, `f5fullname`, `f5relationship`, `f5age`,`f5occupation`, `f5income`) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',
                                                '{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}',
                                                '{20}','{21}','{22}','{23}','{24}','{25}')",
                                                sno, f1name, f1rel, f1age, f1occ, f1income, f2name, f2rel, f2age,f2occ, f2income,
                                                f3name, f3rel, f3age, f3occ, f3income, f4name, f4rel, f4age, f4occ, f4income,
                                                f5name, f5rel, f5age, f5occ, f5income
                                                );
            cs.ExecuteQuery(sql);

        }
        public void fillFamilyDetails(ref DataGridView dg) 
        {
            string sql = String.Format(@"SELECT sno, f1fullname, f1relationship, f1age, f1occupation, income, 
                                            f2fullname, f2relationship, f2age, f2occupation, f2income, f3fullname, f3relationship, f3age,
                                            f3occupation, f3income, f4fullname, f4relationship, f4age, f4occupation, f4income, f5fullname,
                                            f5relationship, f5age, f5occupation, f5income FROM nationalid_family_detail WHERE family_detail_id ");
            cs.FillDataGrid(sql, ref dg);
        }

        public void updateFamilyDetail(string f1fn,
                                        string f1rs,
                                        string f1age,
                                        string f1occ,
                                        string inc,
                                        string f2fn,
                                        string f2rs,
                                        string f2age,
                                        string f2occ,
                                        string f2inc,
                                        string f3fn,
                                        string f3rs,
                                        string f3age,
                                        string f3occ,
                                        string f3inc,
                                        string f4fn,
                                        string f4rs,
                                        string f4age,
                                        string f4occ,
                                        string f4inc,
                                        string f5fn,
                                        string f5rs,
                                        string f5age,
                                        string f5occ,
                                        string f5inc,
                                        string sno
                                        )
        {
            string sql = String.Format(@"UPDATE `nationalid_family_detail` SET 
                                                    `f1fullname`='{0}',`f1relationship`='{1}',`f1age`='{2}',`f1occupation`='{3}',`income`='{4}',
                                                    `f2fullname`='{5}',`f2relationship`='{6}',`f2age`='{7}',`f2occupation`='{8}',`f2income`='{9}',
                                                    `f3fullname`='{10}',`f3relationship`='{11}',`f3age`='{12}',`f3occupation`='{13}',`f3income`='{14}',
                                                    `f4fullname`='{15}',`f4relationship`='{16}',`f4age`='{17}',`f4occupation`='{18}',`f4income`='{19}',
                                                    `f5fullname`='{20}',`f5relationship`='{21}',`f5age`='{22}',`f5occupation`='{23}',`f5income`='{24}' WHERE sno = '{25}'",
                                                    f1fn,f1rs,f1age,f1occ,inc,f2fn,f2rs,f2age,f2occ,f2inc, f3fn, f3rs, f3age, f3occ, f3inc, f4fn, f4rs, f4age, f4occ, f4inc,
                                                    f5fn, f5rs, f5age, f5occ, f5inc, sno);
            cs.ExecuteQuery(sql);
        }

        public async Task<SeniorChildrenDetails> getModel(string sno)
        {
            SeniorChildrenDetails seniorChildren = new SeniorChildrenDetails();

            string sql = @"SELECT * FROM `senior_children_details` WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };

            

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);
            if(await reader.ReadAsync())
            {
                seniorChildren.senior_children_id = int.Parse(reader["senior_children_id"].ToString());
                seniorChildren.sno = reader["sno"].ToString();
                seniorChildren.childName1 = reader["children1_name"].ToString();
                seniorChildren.childNO1 = reader["children1_no"].ToString();
                seniorChildren.childAdd1 = reader["children1_address"].ToString();
                seniorChildren.childName2 = reader["children2_name"].ToString();
                seniorChildren.childNO2 = reader["children2_no"].ToString();
                seniorChildren.childAdd2 = reader["children2_address"].ToString();
                seniorChildren.childName3 = reader["children3_name"].ToString();
                seniorChildren.childNO3 = reader["children3_no"].ToString();
                seniorChildren.childAdd3 = reader["children3_address"].ToString();
                seniorChildren.emeName = reader["emergency_name"].ToString();
                seniorChildren.emeAdd = reader["emergency_address"].ToString();
                seniorChildren.emeRel = reader["emergency_relation"].ToString();
                seniorChildren.emeCon = reader["emergency_contact"].ToString();
            }

            cs.CloseConnection();

            return seniorChildren;
        }
    }
}
