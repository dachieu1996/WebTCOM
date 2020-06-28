using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class EngagementRepository : EFRepository<Engagement, int>, IEngagementRepository
    {
        private AppDbContext _appContext;
        public EngagementRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
