using Estudo1.Domain.Entities;
using Estudo1.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> Find(Func<User, bool> func)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Save(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
