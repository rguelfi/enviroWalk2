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
        IEnumerable<CustomAction> RepQuestionCusActions(Report report);
        IEnumerable<CustomAction> RepQuestionCusActions(Question question);
        CustomAction GetRepQuestionCusAction(int ID);
        void AddRepQuestionCusAction(CustomAction repQuestionCusAction);
        void UpdateRepQuestionCusAction(CustomAction repQuestionCusAction);
        void DeleteRepQuestionCusAction(CustomAction repQuestionCusAction);
        void UpdateRepQuestionCusAction(IEnumerable<CustomAction> repQuestionCusActions);
    }
}
