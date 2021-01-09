using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class PersonalDetailsController
    {
        crudFile cs = new crudFile();

        public void addPersonalDetail(string sno,
                                      string surname,
                                      string firstname,
                                      string middlename,
                                      string birthday,
                                      string pob,
                                      int age,
                                      string sex,
                                      string civil,
                                      string nation,
                                      string religion,
                                      string address, 
                                      string contact
                                      )
        {
            string sql = String.Format(@"INSERT INTO `nationalid_basic_detail`
                                                    (`sno`, `Surname`, `Firstname`, `Middlename`, `DataofBirth`,
                                                    `Birthplace`, `Age`, `Sex`, `CivilStatus`,`Nationality`,`Religion`, `Address`, `ContactNo`)
                                                    VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                                                    sno,surname,firstname,middlename,birthday,pob,age,sex,civil,nation,religion,address,contact);

            cs.ExecuteQuery(sql);
        }

        public void fillDataPersonalDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT sno,Surname,Firstname,Middlename,DataofBirth,Birthplace,
                                            Age,Sex,CivilStatus,Nationality,Religion,Address,ContactNo FROM nationalid_basic_detail WHERE idno");

            cs.FillDataGrid(sql, ref dg);
        }

        public void updatePersonalInfo(string sur, string fn, string mn, string dob, string birt,
                                    int age, string sex, string cis, string nat, string
                                    rel, string add, string cn, string sno)
        {
            string sql = String.Format(@"UPDATE `nationalid_basic_detail` SET 
                                                `Surname`='{0}',`Firstname`='{1}',`Middlename`='{2}',
                                                `DataofBirth`='{3}',`Birthplace`='{4}',`Age`='{5}',`Sex`='{6}',
                                                `CivilStatus`='{7}',`Nationality`='{8}',`Religion`='{9}',`Address`='{10}',`ContactNo`='{11}' WHERE sno = '{12}'",
                                        sur, fn, mn, dob, birt, age, sex, cis, nat, rel, add,cn, sno);
            cs.ExecuteQuery(sql);
        }
    }
}
