using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnviroWalk.Model;

namespace EnviroWalk.RepositoryInterface
{
    public interface ICategory
    {
        Category GetCategory(int ID);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(IEnumerable<Category> category);
    }
}
