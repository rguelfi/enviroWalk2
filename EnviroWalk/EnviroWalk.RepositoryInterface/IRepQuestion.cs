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
        IEnumerable<RepQuestionModel> RepQuestions(ReportModel report);
        RepQuestionModel GetQuestion(int ID);
        void AddRepQuestion(RepQuestionModel repQuestion);
        void UpdateRepQuestion(RepQuestionModel repQuestion);
        void DeleteRepQuestion(RepQuestionModel repQuestion);
        void UpdateRepQuestion(IEnumerable<RepQuestionModel> repQuestion);
    }
}


