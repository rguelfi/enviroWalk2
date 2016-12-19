using EnviroWalk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;
using EnviroWalk.DataModel;

namespace EnviroWalk.Repository.SQLServer
{
    public partial class SQLRepository : IReport
    {
        public void AddReport(ReportModel report)
        {
            throw new NotImplementedException();
        }

        public void DeleteReport(ReportModel report)
        {
            throw new NotImplementedException();
        }

        public ReportModel GetReport(int ID)
        {
            throw new NotImplementedException();
        }

        public ReportModel GetLastReport(int UserID)
        {
            using (var context = new ContextEnviro())
            {
                var report = context.Reports
                .Include("repQuestions")
                .Include("repQuestionActions")
                .Include("repQuestionCusActions")
                .Where(r => r.UserID == UserID)
                .OrderByDescending(r => r.ID)
                .FirstOrDefault();

                return report;

            }
        }

        public void UpdateReport(ReportModel report)
        {
            throw new NotImplementedException();
        }

        public void UpdateReports(IEnumerable<ReportModel> reports)
        {
            throw new NotImplementedException();
        }
    }
}
