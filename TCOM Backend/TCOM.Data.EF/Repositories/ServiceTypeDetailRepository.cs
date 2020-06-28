using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ServiceTypeDetailRepository : EFRepository<ServiceTypeDetail, int>, IServiceTypeDetailRepository
    {
        private AppDbContext _appContext;
        public ServiceTypeDetailRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
