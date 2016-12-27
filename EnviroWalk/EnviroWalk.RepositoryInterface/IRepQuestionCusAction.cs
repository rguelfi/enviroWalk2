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
        IEnumerable<RepQuestionCusAction> RepQuestionCusActions(Report report);
        IEnumerable<RepQuestionCusAction> RepQuestionCusActions(Question question);
        RepQuestionCusAction GetRepQuestionCusAction(int ID);
        void AddRepQuestionCusAction(RepQuestionCusAction repQuestionCusAction);
        void UpdateRepQuestionCusAction(RepQuestionCusAction repQuestionCusAction);
        void DeleteRepQuestionCusAction(RepQuestionCusAction repQuestionCusAction);
        void UpdateRepQuestionCusAction(IEnumerable<RepQuestionCusAction> repQuestionCusActions);
    }
}
