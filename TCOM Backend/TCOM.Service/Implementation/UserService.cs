using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCOM.Core.Interfaces;
using TCOM.Data.EF;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;
using TCOM.Service.Interfaces;
using TCOM.Service.ViewModels;

namespace TCOM.Service.Implementation
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        //private IUserRoleRepository _iUserRoleRepo;
        //private IRoleRepository _iRoleRepo;
        //private IRolePerRepository _iRolePerRepo;
        //private IPermissionRepository _ipermissonRepo;

        public UserService(UserManager<AppUser> userManager, IMapper mapper, AppDbContext dbContext, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
          
        }
        #region GET


        //public async Task<object> GetAllAsync()
        //{
        //    try
        //    {
        //        List<AppUser> data = await _userManager.Users.ToListAsync();
        //        var special = await _ispecialRepo.FindAll(x => x.DeleteFlag != DeleteFlg.Delete).ToListAsync();
        //        var userrole = _iUserRoleRepo.FindAll(x => x.DeleteFlag != DeleteFlg.Delete);
        //        var lstRole = _iRoleRepo.FindAll(x => x.DeleteFlag != DeleteFlg.Delete);
        //        var role = from l in lstRole
        //                   join u in userrole on l.Id equals u.RoleId
        //                   select
        //                   new
        //                   {
        //                       l.Name,
        //                       l.Id,
        //                       u.UserId
        //                   };
        //        var query = from d in data
        //                    select
        //                    new
        //                    {
        //                        d.Id,
        //                        d.UserName,
        //                        d.Email,
        //                        BirthDay = d.BirthDay.ToString("dd'/'MM'/'yyyy"),
        //                        DateCreated = d.DateCreated.ToString("dd'/'MM'/'yyyy"),
        //                        d.FullName,
        //                        d.Level,
        //                        d.NetSalary,
        //                        d.PhoneNumber,
        //                        Special = special.Where(x => x.Id == d.SpecializationId).Select(x => x.Name).FirstOrDefault(),
        //                        Role = role.Where(x => x.UserId.Equals(d.Id)).Select(x => x.Name).FirstOrDefault()
        //                    };
        //        var result = query.ToList();
        //        return result;
        //        //await _userManager.Users.ProjectTo<AppUserViewModel>().ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}

        //public List<Email> GetEmail()
        //{
        //    var data = _userManager.Users.Select(x => new Email { UserId = x.Id, Address = x.Email }).ToList();
        //    return data;
        //}
        //public class Email
        //{
        //    public Guid UserId { get; set; }
        //    public string Address { get; set; }
        //}
        #endregion GET

        public async Task<object> GetById(Guid id)
        {
            try
            {
                List<AppUser> data = await _userManager.Users.ToListAsync();
                var query = from d in data
                            select
                            new
                            {
                                d.Id,
                                d.UserName,
                                d.Email,
                                DateCreated = d.DateCreated.ToShortDateString(),
                                d.FullName,
                                d.PhoneNumber,
                            };
                var result = query.Where(x => x.Id.Equals(id)).FirstOrDefault();
                return result;
                //await _userManager.Users.ProjectTo<AppUserViewModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        #region POST
        public async Task<IdentityResult> AddAsync(AppUserModel userVm)
        {
            var user = new AppUser();
            user.FullName = userVm.FullName;
            user.Email = userVm.Email;
            user.PhoneNumber = userVm.PhoneNumber;
            user.UserName = userVm.UserName;
            user.Avatar = userVm.Avatar;
            user.PasswordHash = userVm.PasswordHash;
            user.DateCreated = DateTime.Now;
            user.DateModified = DateTime.Now;
            var data = await _userManager.CreateAsync(user, userVm.PasswordHash);
            SaveChanges();
            //if (data.Succeeded)
            //{
            //    user.Id = user.Id;
            //    var entity = new UserRole();
            //    entity.UserId = user.Id;
            //    entity.RoleId = userVm.RoleId;
            //    _iUserRoleRepo.Add(entity);
            //    SaveChanges();
            //}
            return data;
        }


        #endregion POST

        private void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
