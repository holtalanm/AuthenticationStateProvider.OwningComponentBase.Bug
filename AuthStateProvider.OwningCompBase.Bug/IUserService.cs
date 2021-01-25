using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthStateProvider.OwningCompBase.Bug
{
    public interface IUserService
    {
        Task<string> GetUserNameAsync();
    }
}
