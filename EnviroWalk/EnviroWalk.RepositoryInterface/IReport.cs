using EnviroWalk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Repository.Interface
{
    public interface IReport
    {
        ReportModel GetLastReport(int UserID);
        ReportModel GetReport(int ID);
        void AddReport(ReportModel report);
        void UpdateReport(ReportModel report);
        void DeleteReport(ReportModel report);
        void UpdateReports(IEnumerable<ReportModel> reports);
    }
}
