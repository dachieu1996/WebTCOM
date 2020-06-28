using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ProjectTypeRepository : EFRepository<ProjectType, int>, IProjectTypeRepository
    {
        private AppDbContext _appContext;
        public ProjectTypeRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
