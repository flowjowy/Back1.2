using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public interface IUserService
    {
        public List <User> users { get; }
    }
}
