using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ProjectTypeDetailRepository : EFRepository<ProjectTypeDetail, int>, IProjectTypeDetailRepository
    {
        private AppDbContext _appContext;
        public ProjectTypeDetailRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
