using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class HomeRepository : EFRepository<Home, int>, IHomeRepository
    {
        private AppDbContext _appContext;
        public HomeRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
