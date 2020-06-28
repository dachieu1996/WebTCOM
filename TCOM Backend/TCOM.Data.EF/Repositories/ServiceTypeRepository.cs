using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ServiceTypeRepository : EFRepository<ServiceType, int>, IServiceTypeRepository
    {
        private AppDbContext _appContext;
        public ServiceTypeRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
