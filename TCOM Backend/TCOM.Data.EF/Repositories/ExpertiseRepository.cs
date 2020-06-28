using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ExpertiseRepository : EFRepository<Expertise, int>, IExpertiseRepository
    {
        private AppDbContext _appContext;
        public ExpertiseRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
