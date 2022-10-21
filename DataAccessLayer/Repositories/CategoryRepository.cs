using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();

        public void Delete(Category t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            return context.Categories.ToList(); 
        }

        public void Insert(Category t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(Category t)
        {
            context.Remove(t);
            context.SaveChanges();
        }
    }
}
