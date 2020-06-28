using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Core.Interfaces;

namespace TCOM.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
