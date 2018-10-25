using Estudo1.ApplicationService.Services.Interfaces;
using Estudo1.Domain.Entities;
using Estudo1.Domain.Repositories;
using Estudo1.Domain.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.ApplicationService.Services
{
    public class UserApplicationService : IUserApplicationService
    {
        private ICreateUser createUser;

        public UserApplicationService(ICreateUser createUser)
        {
            this.createUser = createUser;
        }

        public void CreateUser(User user)
        {
            if (user == null)
                throw new ApplicationException("Nao foi informado o usuario");

            createUser.Create(user);
        }
    }
}
