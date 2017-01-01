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
        Report GetLastReport(int UserID);
        Report GetReport(int ID);
        void AddReport(Report report);
        void UpdateReport(Report report);
        void DeleteReport(Report report);
        void UpdateReports(IEnumerable<Report> reports);
        Report SaveReport(Report report);
        Report EmailReport(int UserID, string safeEmail);
    }
}
