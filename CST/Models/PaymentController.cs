using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models.Member;
using CST.Volunteer;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class PaymentController
    {
        crudFile cs = new crudFile();

        
        public void addPayment(string sno,
                                float memship,
                                float monthly
                                )
        {
            string sql = String.Format(@"INSERT INTO `payments`(`sno`, `membershipfee`, `monthlyfee`) VALUES ('{0}',{1},{2})",
                                        sno, memship, monthly);

            cs.ExecuteQuery(sql);

        }


        public async Task<float> getPayment(string sno)
        {
            float monthlyFee = 0;
            string sql = @"SELECT * FROM `payments` WHERE sno = @sno";


            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>() { (new MySqlParameter("@sno", sno)) };

            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);


            if (await reader.ReadAsync())
            {
                monthlyFee = string.IsNullOrEmpty(reader["monthlyfee"].ToString()) ? 0 :
                    float.Parse(reader["monthlyfee"].ToString());
            }


            cs.CloseConnection();

            return monthlyFee;

        }

        public void updatePayment(string sno,
                                    int memship,
                                    int monthly)
        {
            string sql = String.Format(@"UPDATE `payments` SET `membershipfee`='{0}',`monthlyfee`='{1}' WHERE sno = '{2}'",
                                        memship, monthly, sno);

            cs.ExecuteQuery(sql);
        }

        internal Task<DataSet> fillDataGridDetails(object dg)
        {
            throw new NotImplementedException();
        }

        public void fillDataGridDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT membership_fee.sno,
                    CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name',
                            membership_fee.payment_date,Payment FROM `membership_fee`
                            INNER JOIN senior_basic_detail ON senior_basic_detail.sno = membership_fee.sno");

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataWithSumpayment(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT DISTINCT(o.sno),
                        CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name',
                        (SELECT SUM(Payment) FROM membership_fee AS m WHERE m.sno = o.sno) as 'totalpayment' FROM `membership_fee` AS o
                        INNER JOIN senior_basic_detail ON o.sno = senior_basic_detail.sno");

            cs.FillDataGrid(sql, ref dg);
        }



        public void fillDataNotPaidInMonth(int month, int year, ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT DISTINCT(senior_basic_detail.sno),CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name' 
						FROM membership_fee
                        RIGHT JOIN senior_basic_detail ON membership_fee.sno = senior_basic_detail.sno
                        WHERE senior_basic_detail.sno NOT IN (SELECT sno FROM membership_fee WHERE MONTH(payment_date) = {0} 
                        AND YEAR(payment_date) = {1}) ", month, year);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataPaidInMonth(int month, int year, ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT DISTINCT(membership_fee.sno),CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name',
                        membership_fee.payment_date,Payment FROM `membership_fee`
                        INNER JOIN senior_basic_detail ON membership_fee.sno = senior_basic_detail.sno
                         WHERE  MONTH(payment_date) = {0}
                        AND YEAR(payment_date) = {1} ", month, year);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataPaidInYear(int year, ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT DISTINCT(membership_fee.sno),CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name',
                        membership_fee.payment_date,Payment FROM `membership_fee`
                        INNER JOIN senior_basic_detail ON membership_fee.sno = senior_basic_detail.sno
                         WHERE YEAR(payment_date) = {0}", year);

            cs.FillDataGrid(sql, ref dg);
        }


        public async Task<DataSet> getPaymentSum()
        {
            DataSet ds = await cs.GetDataSetAsync(@"SELECT DISTINCT(o.sno),
                        CONCAT(senior_basic_detail.firstname,' ',senior_basic_detail.lastname) as 'Member_Name',
                        (SELECT SUM(Payment) FROM membership_fee AS m WHERE m.sno = o.sno) as 'totalpayment' FROM `membership_fee` AS o
                        INNER JOIN senior_basic_detail ON o.sno = senior_basic_detail.sno", null);

            return ds;
        }


        public async Task<MembershipFeeModel> getModel(string sno)
        {
            MembershipFeeModel membershipFeeModel = new MembershipFeeModel();           

            string sql = @"SELECT ID, sno, membershipfee, SUM(Payment) FROM payments WHERE sno = @sno";

            List<MySqlParameter> mySqlParameters = new List<MySqlParameter>()
            {
                (new MySqlParameter("@sno",sno))
            };
            
            DbDataReader reader = await cs.RetrieveRecordsAsync(sql, mySqlParameters);

            while (await reader.ReadAsync())
            {

                //membershipFeeModel.id = int.Parse(reader["ID"].ToString());
                membershipFeeModel.sno = reader["sno"].ToString();
                membershipFeeModel.Payment = int.Parse(reader["membershipfee"].ToString());
                membershipFeeModel.TotalCont = int.Parse(reader["Payment"].ToString());

            }

            cs.CloseConnection();

            return membershipFeeModel;

        }

    }
}