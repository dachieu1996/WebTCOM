using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class LibraryRepository : EFRepository<Library, int>, ILibraryRepository
    {
        private AppDbContext _appContext;
        public LibraryRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
