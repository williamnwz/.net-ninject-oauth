using Estudo1.Domain.Entities;
using Estudo1.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Tests.User.Repositories
{
    public class UserRepositoryMock : IUserRepository
    {

        private List<Domain.Entities.User> users = new List<Domain.Entities.User>()
        {
            new Domain.Entities.User("William Vinco","williamnwz@gmail.com","abc123"),
            new Domain.Entities.User("Alberto Fagundes","teste@gmail.com","abc123"),
        };

        public IEnumerable<Domain.Entities.User> Find(Func<Domain.Entities.User, bool> func)
        {
            return users.Where(func).ToList();
        }

        public void Remove(Domain.Entities.User entity)
        {
            
        }

        public void Save(Domain.Entities.User entity)
        {
            
        }
    }
}
