using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCOM.Service.ViewModels;

namespace TCOM.Service.Interfaces
{
    public interface IUserService
    {
        Task<object> GetById(Guid id);
        Task<IdentityResult> AddAsync(AppUserModel userVm);
    }
}
