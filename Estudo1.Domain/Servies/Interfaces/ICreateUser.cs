using Estudo1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Domain.Servies.Interfaces
{
    public interface ICreateUser
    {
        void Create(User user);
    }
}
