using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class SerRepository : EFRepository<ServiceHome, int>, ISerRepository
    {
        private AppDbContext _appContext;
        public SerRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
