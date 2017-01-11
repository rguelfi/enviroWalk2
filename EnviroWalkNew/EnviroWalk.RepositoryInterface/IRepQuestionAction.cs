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
        IEnumerable<Model.AnswerAction> RepQuestionActions(Report report);
        IEnumerable<Model.AnswerAction> RepQuestionActions(QuestionAction questionAction);
        Action GetRepQuestionAction(int ID);
        void AddRepQuestionAction(Model.AnswerAction repQuestionAction);
        void UpdateRepQuestionAction(Model.AnswerAction repQuestionAction);
        void DeleteRepQuestionAction(Model.AnswerAction repQuestionAction);
        void UpdateRepQuestionAction(IEnumerable<Model.AnswerAction> repQuestionActions);
    }
}
