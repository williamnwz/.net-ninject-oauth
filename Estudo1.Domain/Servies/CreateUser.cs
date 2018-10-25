using Estudo1.Domain.Entities;
using Estudo1.Domain.Repositories;
using Estudo1.Domain.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo1.Domain.Exceptions;

namespace Estudo1.Domain.Servies
{
    public class CreateUser : ICreateUser
    {
        private IUserRepository userRepository;

        public CreateUser(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Create(User user)
        {
            var users = userRepository.Find(u => u.Name.ToUpper().Equals(user.Name));

            if (users != null && users.Any())
                throw new DomainException("Já existe o usuario inforado!");

            user.Validate();

            userRepository.Save(user);


        }
    }
}
