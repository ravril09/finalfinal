using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class RequestMedicalController
    {
        crudFile cs = new crudFile();

        public void addRequestMedical(string sno,
                                      string fn,
                                      string cn,
                                      string add,
                                      string rm
                                      )
        {
            string sql = String.Format(@"INSERT INTO `requestmedical`
                                                (`sno`,`Firstname`, `ContactNo`, `Address`, `Remark`) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                                sno,fn,cn,add,rm);
            cs.ExecuteQuery(sql);
        }
        public void updateRequestMedical(string fn,
                                         string cn,
                                         string add,
                                         string rm,
                                         string sno
                                         )
        {
            string sql = String.Format(@"UPDATE `requestmedical` SET 
                                                    `Firstname`='{0}',`ContactNo`='{1}',`Address`='{2}',`Remark`='{3}' WHERE `sno`='{4}'",
                                                    fn,cn,add,rm,sno);
            cs.ExecuteQuery(sql);
        }

        public void fillRequetMedical(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT id,sno,Firstname,ContactNo,Address,Remark FROM requestmedical WHERE id");

            cs.FillDataGrid(sql, ref dg);
        }

        public void deleteRequestmedical(int id)
        {
            string sql = String.Format(@"DELETE FROM requestmedical WHERE id = {0}", id);

            cs.ExecuteQuery(sql);
        }

    }
}
