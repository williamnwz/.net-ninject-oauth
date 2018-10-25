using AutoMapper;
using Estudo1.ApplicationService.Services;
using Estudo1.ApplicationService.Services.Interfaces;
using Estudo1.Contract;
using Estudo1.DataAccess.Repositories;
using Estudo1.Domain.Entities;
using Estudo1.Domain.Repositories;
using Estudo1.Domain.Servies;
using Estudo1.Domain.Servies.Interfaces;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.IoC
{
    public class Container : NinjectModule
    {
        public override void Load()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateUserRequest, User>();
                cfg.CreateMap<User, CreateUserRequest>();
            });
            Bind<IMapper>().ToMethod(ctx => new Mapper(config, type => ctx.Kernel.Get(type)));

            this.Bind<IUserRepository>().To<UserRepository>();
            this.Bind<IUserApplicationService>().To<UserApplicationService>();

            this.Bind<ICreateUser>().To<CreateUser>();

            
        }
    }
}
