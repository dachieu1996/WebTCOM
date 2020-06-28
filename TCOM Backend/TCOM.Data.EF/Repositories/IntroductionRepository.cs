using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class IntroductionRepository : EFRepository<Introduction, int>, IIntroductionRepository
    {
        private AppDbContext _appContext;
        public IntroductionRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
