using Estudo1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Domain.Repositories
{
    public interface IRepository<E> where E : Entity
    {
        //IEnumerable<E> Find(Expression<Func<E, bool>> expression);

        void Save(E entity);

        void Remove(E entity);

        IEnumerable<E> Find(Func<Domain.Entities.User, bool> func);
        

    }
}
