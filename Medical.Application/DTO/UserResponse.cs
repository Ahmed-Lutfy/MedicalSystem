using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Medical.Application.DTO
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }


        public string? AccessToken { get; set; }
        
        public DateTime ExpireToken { get; set; }
        public string? RefreshToken { get; set; }
      
        public DateTime? RefreshTokenExpiryTime { get; set; }

        
        public DateTime RevokeOn { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
