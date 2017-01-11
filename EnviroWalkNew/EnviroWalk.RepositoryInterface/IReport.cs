using EnviroWalk.Model;
using EnviroWalk.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Repository.Interface
{
    public interface IReport
    {
        ReportView GetLastReport(int UserID);
        ReportExportView GetReportExport(int UserID);
        Report GetReport(int ID);
        void AddReport(ReportView report);
        void UpdateReport(Report report);
        void DeleteReport(Report report);
        void UpdateReports(IEnumerable<Report> reports);
        Report SaveReport(Report report);
        Report EmailReport(int UserID, string safeEmail);
    }
}
