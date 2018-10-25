using Estudo1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.ApplicationService.Services.Interfaces
{
    public interface IUserApplicationService
    {
        void CreateUser(User user);
    }
}
