﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();
            return context.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            using var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
