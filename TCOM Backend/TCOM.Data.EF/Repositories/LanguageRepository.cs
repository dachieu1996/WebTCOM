using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class LanguageRepository : EFRepository<Language, int>, ILanguageRepository
    {
        private AppDbContext _appContext;
        public LanguageRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
