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
        IEnumerable<RepQuestion> RepQuestions(Report report);
        IEnumerable<RepQuestion> RepQuestions(Question question);
        RepQuestion GetRepQuestion(int ID);
        void AddRepQuestion(RepQuestion repQuestion);
        void UpdateRepQuestion(RepQuestion repQuestion);
        void DeleteRepQuestion(RepQuestion repQuestion);
        void UpdateRepQuestion(IEnumerable<RepQuestion> repQuestion);
    }
}


