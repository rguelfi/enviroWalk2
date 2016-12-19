using EnviroWalk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Repository.Interface
{
    public interface IRepQuestionAction
    {
        IEnumerable<RepQuestionActionModel> RepQuestionActions(ReportModel report);
        RepQuestionActionModel GetQuestionAction(int ID);
        void AddRepQuestionAction(RepQuestionActionModel repQuestionAction);
        void UpdateRepQuestionAction(RepQuestionActionModel repQuestionAction);
        void DeleteRepQuestionAction(RepQuestionActionModel repQuestionAction);
        void UpdateRepQuestionAction(IEnumerable<RepQuestionActionModel> repQuestionActions);
    }
}
