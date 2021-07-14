﻿using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Writer> List()
        {
            return _object.ToList();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            c.SaveChanges();
        }
    }
}
