using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class RequestEyeglassController
    {
        crudFile cs = new crudFile();

        public async Task<DataSet> getRequestEyeglasses()
        {
            DataSet ds = await cs.GetDataSetAsync(@"SELECT * FROM requesteyeglasss",
                null);

            return ds;
        }

        public void addRequestEyeglass(string sno,
                                       string fn,
                                       string cn,
                                       string add,
                                       string age,
                                       string eye,
                                       string rm
                                       )
        {
            string sql = String.Format(@"INSERT INTO `requesteyeglasss`
                                                (`sno`, `Fullname`, `ContactNo`, `Address`, `Age`, `EyeGrade`, `Remarks`) 
                                                    VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                    sno,fn,cn,add,age,eye,rm
                                                    );
            cs.ExecuteQuery(sql);
        }
        public void updateRequestEyeglass(string fn,
                                           string cn,
                                           string add,
                                           string age,
                                           string eye,
                                           string rm,
                                           string sno
                                           )
        {
            string sql = String.Format(@"UPDATE `requesteyeglasss` SET `Fullname`='{0}',`ContactNo`='{1}',`Address`='{2}',`Age`='{3}',`EyeGrade`='{4}',`Remarks`='{5}'
                                                    WHERE sno = '{6}'",
                                                    fn,cn,add,age,eye,rm,sno
                                                    );
            cs.ExecuteQuery(sql);
        }
        public void fillRequestEyeglass(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT id,sno, Fullname, ContactNo, Address, Age, EyeGrade, Remarks FROM requesteyeglasss WHERE id");

            cs.FillDataGrid(sql, ref dg);
        }

        public void deleteRequestEyeglasses(int id)
        {
            string sql = String.Format(@"DELETE FROM requesteyeglasss WHERE id = {0}",id);

            cs.ExecuteQuery(sql);
        }

        public void searchGid(string condition, string searchKeys, ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT id, sno, Fullname, ContactNo, Address, Age,
                                                EyeGrade, Remarks FROM requesteyeglasss
                                                WHERE {0} LIKE '%{1}%'", condition, searchKeys);

            cs.FillDataGrid(sql, ref dg);
        }
    }
}
