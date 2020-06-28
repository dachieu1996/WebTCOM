using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class RolePerRepository : EFRepository<RolePermisson, int>, IRolePerRepository
    {
        private AppDbContext _appContext;
        public RolePerRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
