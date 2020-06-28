using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ServiceSubDetailRepository : EFRepository<ServiceSubDetail, int>, IServiceSubDetailRepository
    {
        private AppDbContext _appContext;
        public ServiceSubDetailRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
