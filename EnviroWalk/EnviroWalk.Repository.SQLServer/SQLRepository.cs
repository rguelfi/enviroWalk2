using EnviroWalk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;
using EnviroWalk.DataModel;
using System.Data.Entity.Core.Objects;
using Newtonsoft.Json;
using System.Data.Entity;

namespace EnviroWalk.Repository.SQLServer
{
    public partial class SQLRepository : IReport
    {
        public Report GetLastReport(int UserID)
        {
            using (var context = new ContextEnviro())
            {
                var report = context.Report
                .Include("repQuestions")
                .Include("repQuestionActions")
                .Include("repQuestionCusActions")
                .Where(r => r.UserID == UserID)
                .OrderByDescending(r => r.ReportDateTime)
                .FirstOrDefault();

                return report;
            }
        }

        public Report SaveReport(Report report)
        {
            using (var context = new ContextEnviro())
            {
                foreach (var rqca in report.repQuestionCusActions)
                {
                    rqca.RepQuestionCusActionDate = DateTime.Now; //retirar essa linha de codigo depois de testar
                    context.Entry(rqca.Question).State = EntityState.Added;
                }

                foreach (var rq in report.repQuestions)
                    context.Entry(rq.Question).State = EntityState.Unchanged;

                foreach (var rqa in report.repQuestionActions)
                {
                    rqa.RepQuestionActionDate = DateTime.Now; //retirar essa linha de codigo depois de testar
                    context.Entry(rqa.QuestionAction).State = EntityState.Unchanged;
                    //context.Entry(rqa.QuestionAction.Question).State = EntityState.Unchanged;
                }   

                report.ReportFarmName = report.ReportFarmName + " (MOD)";
                report.ReportDateTime = DateTime.Now;

                context.Report.Add(report);
                context.SaveChanges();

                var reportDoBanco = context.Report
                .Include("repQuestions")
                .Include("repQuestionActions")
                .Include("repQuestionCusActions")
                .Where(r => r.UserID == report.UserID)
                .OrderByDescending(r => r.ReportDateTime)
                .FirstOrDefault();

                return reportDoBanco;
            }
        }

        public Report EmailReport(int UserID, string safeEmail)
        {
            using (var context = new ContextEnviro())
            {
                var report = context.Report
                .Include("repQuestions")
                .Include("repQuestionCusActions")
                .Include("repQuestionActions")
                .Include("repQuestions.Question")
                .Include("repQuestions.Question.Category")
                .Include("repQuestionActions.QuestionAction")
                .Where(r => r.UserID == UserID)
                .OrderByDescending(r => r.ReportDateTime)
                .FirstOrDefault(); 

                return report;
            }
        }

        public Report GetReport(int ID) { throw new NotImplementedException(); }
        public void AddReport(Report report) { throw new NotImplementedException(); }
        public void DeleteReport(Report report) { throw new NotImplementedException(); }
        public void UpdateReport(Report report) { throw new NotImplementedException(); }
        public void UpdateReports(IEnumerable<Report> reports) { throw new NotImplementedException(); }
    }
}
