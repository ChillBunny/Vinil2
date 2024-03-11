using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinil2.Models;

namespace Vinil2.Servicios
{
    internal interface ILoginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
