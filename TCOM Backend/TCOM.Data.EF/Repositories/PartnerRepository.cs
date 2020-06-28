using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class PartnerRepository : EFRepository<Partner, int>, IPartnerRepository
    {
        private AppDbContext _appContext;
        public PartnerRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
