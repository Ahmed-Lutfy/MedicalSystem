using Medical.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Interface
{
   public interface IAuthRepository
    {
        Task<bool> updateUserRefreshToken(UserResponse user);
        Task<UserResponse> checkToken(string token);
        Task<UserResponse> RegisterAsync(UserRegisterRequest requestDto);
        Task<UserResponse> LoginAsync(UserLoginRequest requestDto);
        Task<bool> updateUserToken(UserAccessToken dto);

    }
}
