using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;

namespace EnviroWalk.RepositoryInterface
{
    public interface IQuestion
    {
        IEnumerable<Question> Questions(Category category);
        Question GetQuestion(int ID);
        void AddQuestion(Question question);
        void UpdateQuestion(Question question);
        void DeleteQuestion(Question question);
        void UpdateQuestion(IEnumerable<Question> question);
    }
}
