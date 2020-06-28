using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class ContactRepository : EFRepository<Contact, int>, IContactRepository
    {
        private AppDbContext _appContext;
        public ContactRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
