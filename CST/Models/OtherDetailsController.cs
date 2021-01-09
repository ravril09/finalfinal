using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class OtherDetailsController
    {
        crudFile cs = new crudFile();

        public void addOtherDetail(string sno,
                                   string Edu,
                                   string occ,
                                   string ann,
                                   string other,
                                   string dialect,
                                   string pred,
                                   string email)
        {
            string sql = String.Format(@"INSERT INTO `nationalid_other_detail`
                                            (`sno`, `EducationalAttainment`, `Occupation`, `AnnualIncome`, `OtherSkills`, 
                                             `DialectSpoken`, `PrecinctNo`, `EmailAddress`) VALUES
                                                ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                sno,Edu,occ,ann,other,dialect,pred,email);

            cs.ExecuteQuery(sql);
        }
        public void fillOtherDetail(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT sno, EducationalAttainment, Occupation, AnnualIncome, 
                                                OtherSkills, DialectSpoken, PrecinctNo, EmailAddress FROM nationalid_other_detail WHERE other_detail_id");
            cs.FillDataGrid(sql, ref dg);

        }

        public void updateOtherDetail(string EduAt,
                                        string Occ,
                                        string annu,
                                        string otskill,
                                        string DiaSpoken,
                                        string Predict,
                                        string Eaddress,
                                        string sno)
        {
            string sql = String.Format(@"UPDATE `nationalid_other_detail` SET 
                                                        `EducationalAttainment`='{0}',`Occupation`='{1}',`AnnualIncome`='{2}',`OtherSkills`='{3}',
                                                        `DialectSpoken`='{4}',`PrecinctNo`='{5}',`EmailAddress`='{6}' WHERE sno = '{7}'",
                                                        EduAt,Occ,annu,otskill,DiaSpoken,Predict,Eaddress,sno);

            cs.ExecuteQuery(sql);
        }

    }
}
