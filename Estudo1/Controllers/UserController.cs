using AutoMapper;
using Estudo1.ApplicationService.Services.Interfaces;
using Estudo1.Contract;
using Estudo1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Estudo1.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private IUserApplicationService userApplicationService;
        private IMapper mapper;

        public UserController(IUserApplicationService userApplicationService,
            IMapper mapper) : base()
        {
            this.mapper = mapper;
            this.userApplicationService = userApplicationService;
        }

        [Route("create")]
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public string Create(CreateUserRequest request)
        {
            this.userApplicationService.CreateUser(mapper.Map<User>(request));
            return "OK";
        }

        [Route("user")]
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public string GetUser()
        {
            return "Teste";
        }
    }
}