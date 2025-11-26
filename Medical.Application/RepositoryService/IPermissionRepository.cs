using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Interface
{
    public interface IPermissionRepository
    {
        Task<IList<Claim>> getUserClaims(string id);

    }
}
