using System;
using System.Collections.Generic;
using System.Text;

namespace TCOM.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>

        int SaveChanges();
    }
}
