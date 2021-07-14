using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        //TYPE NAME();

        List<T> List();

        void Insert(T p); //Ekleme
        void Update(T p); //Güncelleme
        void Delete(T p); //Silme

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
