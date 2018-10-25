using Estudo1.Domain.Exceptions;
using Estudo1.Domain.Servies;
using Estudo1.Domain.Servies.Interfaces;
using Estudo1.Tests.User.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Tests.User
{
    [TestClass]
    public class UserTest
    {

        private ICreateUser createUser;

        [TestInitialize]
        public void Init()
        {
            createUser = new CreateUser(new UserRepositoryMock());
        }


        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void CreateUserWithoutName()
        {
            Domain.Entities.User user = new Domain.Entities.User("", "teste@teste.com", "abc123");
            createUser.Create(user);
        }


        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void CreateUserWithoutEmail()
        {
            Domain.Entities.User user = new Domain.Entities.User("William 2", "", "abc123");
            createUser.Create(user);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void CreateUserWithoutPassword()
        {
            Domain.Entities.User user = new Domain.Entities.User("William 2", "teste@teste.com", "");
            createUser.Create(user);
        }
    }
}
