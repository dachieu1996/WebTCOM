using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ProgrammingLanguageRepository : EFRepository<ProgrammingLanguage, int>, IProgrammingLanguageRepository
    {
        private AppDbContext _appContext;
        public ProgrammingLanguageRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
