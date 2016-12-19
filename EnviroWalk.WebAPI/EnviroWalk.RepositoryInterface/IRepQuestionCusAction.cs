using EnviroWalk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Repository.Interface
{
    public interface IRepQuestionCusAction
    {
        IEnumerable<RepQuestionCusActionModel> RepQuestionCusActions(ReportModel report);
        RepQuestionCusActionModel GetQuestionCusAction(int ID);
        void AddRepQuestionCusAction(RepQuestionCusActionModel repQuestionCusAction);
        void UpdateRepQuestionCusAction(RepQuestionCusActionModel repQuestionCusAction);
        void DeleteRepQuestionCusAction(RepQuestionCusActionModel repQuestionCusAction);
        void UpdateRepQuestionCusAction(IEnumerable<RepQuestionCusActionModel> repQuestionCusActions);
    }
}
