using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBattles.Shared;

namespace BlazorBattles.Server.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password, int startUnitId);

        Task<ServiceResponse<string>> Login(string email, string password);
        // the token
        Task<bool> UserExists(string email); //used incase someone tries to create new account with smae email


    }
}
