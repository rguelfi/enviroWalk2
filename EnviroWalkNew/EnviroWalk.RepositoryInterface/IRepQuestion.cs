using EnviroWalk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Repository.Interface
{
    public interface IRepQuestion
    {
        IEnumerable<AnswerQuestion> RepQuestions(Report report);
        IEnumerable<AnswerQuestion> RepQuestions(Question question);
        AnswerQuestion GetRepQuestion(int ID);
        void AddRepQuestion(AnswerQuestion repQuestion);
        void UpdateRepQuestion(AnswerQuestion repQuestion);
        void DeleteRepQuestion(AnswerQuestion repQuestion);
        void UpdateRepQuestion(IEnumerable<AnswerQuestion> repQuestion);
    }
}


