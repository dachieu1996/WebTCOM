﻿using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permisson, int>, IPermissionRepository
    {
        private AppDbContext _appContext;
        public PermissionRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
