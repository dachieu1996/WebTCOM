using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Core.Interfaces;
using TCOM.Data.Entities;

namespace TCOM.Data.IRepositories
{
    public interface IProjectRepository : IRepository<Project, int>
    {
    }
}
