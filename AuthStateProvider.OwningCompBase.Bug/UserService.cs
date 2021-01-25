using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace AuthStateProvider.OwningCompBase.Bug
{
    public class UserService : IUserService
    {
        private readonly AuthenticationStateProvider _AuthStateProvider;

        public UserService(AuthenticationStateProvider authStateProvider)
        {
            _AuthStateProvider = authStateProvider;
        }

        public async Task<String> GetUserNameAsync()
        {
            AuthenticationState authState = await _AuthStateProvider.GetAuthenticationStateAsync();
            return authState.User.Identity.Name ?? string.Empty;
        }
    }
}
