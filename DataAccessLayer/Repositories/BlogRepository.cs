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
    public class BlogRepository : IBlogDal
    {
        Context context = new Context();

        public void Delete(Blog t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            return context.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public List<Blog> ListAllBlog()
        {
            return context.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            context.Update(t);
            context.SaveChanges();
        }

    }
}
