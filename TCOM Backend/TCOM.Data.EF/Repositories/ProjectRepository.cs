using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ProjectRepository : EFRepository<Project, int>, IProjectRepository
    {
        private AppDbContext _appContext;
        public ProjectRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
