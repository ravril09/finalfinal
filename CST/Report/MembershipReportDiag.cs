using CST.Models;
using CST.Models.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Report
{
    public partial class MembershipReportDiag : Form
    {
        //controller
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        IDDetailsController idDetailsController = new IDDetailsController();
        FamilyDetailController familyDetailController = new FamilyDetailController();
        //models
        SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
        SeniorIdDetails seniorIdDetails = new SeniorIdDetails();
        SeniorChildrenDetails seniorChildrenDetails = new SeniorChildrenDetails();
        private string sno = "";
        public MembershipReportDiag(string sno)
        {
            InitializeComponent();
            this.sno = sno;
        }

        private async void MembershipReportDiag_Load(object sender, EventArgs e)
        {
            try_rpt try_Rpt = new try_rpt();

            Task<SeniorBasicDetail> task1 = Task.Run(() => basicDetailsController.getModel(sno));
            Task<SeniorIdDetails> task2 = Task.Run(() => idDetailsController.getModel(sno));
            Task<SeniorChildrenDetails> task3 = Task.Run(() => familyDetailController.getModel(sno));


            List<Task> tasks = new List<Task>() { task1,task2,task3};

            await Task.WhenAll(tasks);
            seniorBasicDetail = task1.Result;
            seniorIdDetails = task2.Result;
            seniorChildrenDetails = task3.Result;


            //string path = await basicDetailsController.getImgPath(sno);

            //Basic Param

            try_Rpt.SetParameterValue("imgPathParam", seniorBasicDetail.imgPath);
            try_Rpt.SetParameterValue("signPathParam", seniorBasicDetail.imgPath2);
            try_Rpt.SetParameterValue("fnNameParam", seniorBasicDetail.firstname);
            try_Rpt.SetParameterValue("lnParam", seniorBasicDetail.lastname);
            try_Rpt.SetParameterValue("mnParam", seniorBasicDetail.middlename);
            try_Rpt.SetParameterValue("dobParam", seniorBasicDetail.birthdate);
            try_Rpt.SetParameterValue("pob", seniorBasicDetail.pob);
            try_Rpt.SetParameterValue("sex", seniorBasicDetail.gender);
            try_Rpt.SetParameterValue("cvstatus", seniorBasicDetail.civilstatus);
            try_Rpt.SetParameterValue("rel", seniorBasicDetail.religion);
            try_Rpt.SetParameterValue("Add", seniorBasicDetail.address);
            try_Rpt.SetParameterValue("Cel", seniorBasicDetail.cno);


            //ID Param
            try_Rpt.SetParameterValue("oscaParam", seniorIdDetails.osca);
            try_Rpt.SetParameterValue("tinParam", seniorIdDetails.tin);
            try_Rpt.SetParameterValue("Phil", seniorIdDetails.ph);
            try_Rpt.SetParameterValue("Gsis", seniorIdDetails.gsis);
            try_Rpt.SetParameterValue("SSS", seniorIdDetails.sss);

            //Children Param
            try_Rpt.SetParameterValue("Chil1", seniorChildrenDetails.childName1);
            try_Rpt.SetParameterValue("ChilAdd1", seniorChildrenDetails.childAdd1);
            try_Rpt.SetParameterValue("ChildName2", seniorChildrenDetails.childName2);
            try_Rpt.SetParameterValue("ChildAdd2", seniorChildrenDetails.childAdd2);
            try_Rpt.SetParameterValue("ChildName3", seniorChildrenDetails.childName3);
            try_Rpt.SetParameterValue("ChildAdd3", seniorChildrenDetails.childAdd3);
            try_Rpt.SetParameterValue("emName", seniorChildrenDetails.emeName);
            try_Rpt.SetParameterValue("emAdd", seniorChildrenDetails.emeAdd);
            try_Rpt.SetParameterValue("emCN", seniorChildrenDetails.emeCon);
           
            crystalReportViewer1.ReportSource = try_Rpt;
        }
    }
}
