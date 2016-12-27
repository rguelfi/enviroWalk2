using EnviroWalk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;
using EnviroWalk.DataModel;
using System.Data.Entity.Core.Objects;

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
                .OrderByDescending(r => r.ReportID)
                .FirstOrDefault();

                //var report = context.Report
                //.Include(q => q.repQuestions)
                //.Include("repQuestionActions")
                //.Include("repQuestionCusActions")
                //.Where(r => r.UserID == UserID)
                //.OrderByDescending(r => r.ReportID)
                //.FirstOrDefault();
                

                //((ObjectQuery)report).Include("Question");

                return report ;
            }
        }
        public Report GetReport(int ID) { throw new NotImplementedException(); }
        public void AddReport(Report report) { throw new NotImplementedException(); }
        public void DeleteReport(Report report) { throw new NotImplementedException(); }
        public void UpdateReport(Report report) { throw new NotImplementedException(); }
        public void UpdateReports(IEnumerable<Report> reports) { throw new NotImplementedException(); }
    }
}
