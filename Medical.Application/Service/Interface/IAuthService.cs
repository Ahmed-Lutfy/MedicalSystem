using Medical.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.Interface
{
    public interface IAuthService
    {
        Task<bool> Logout(string token);
        Task<UserResponse> RefreshTokenAsync(string token);
        Task<UserResponse> RegisterAsync(UserRegisterRequest request);
        Task<UserResponse> LoginAsync(UserLoginRequest request);


    }
}
