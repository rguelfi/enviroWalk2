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
        IEnumerable<RepQuestionAction> RepQuestionActions(Report report);
        IEnumerable<RepQuestionAction> RepQuestionActions(QuestionAction questionAction);
        RepQuestionAction GetRepQuestionAction(int ID);
        void AddRepQuestionAction(RepQuestionAction repQuestionAction);
        void UpdateRepQuestionAction(RepQuestionAction repQuestionAction);
        void DeleteRepQuestionAction(RepQuestionAction repQuestionAction);
        void UpdateRepQuestionAction(IEnumerable<RepQuestionAction> repQuestionActions);
    }
}
