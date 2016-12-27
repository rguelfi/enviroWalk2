using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;

namespace EnviroWalk.RepositoryInterface
{
    public interface IQuestionAction
    {
        IEnumerable<QuestionAction> QuestionActions(Question question);
        Question GetQuestionAction(int ID);
        void AddQuestionAction(QuestionAction questionAction);
        void UpdateQuestionAction(QuestionAction questionAction);
        void DeleteQuestionAction(QuestionAction questionAction);
        void UpdateQuestionAction(IEnumerable<QuestionAction> questionAction);
    }
}
