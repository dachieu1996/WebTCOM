using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;

namespace TCOM.Data.EF.Repositories
{
    public class GalleryRepository : EFRepository<Gallery, int>, IGalleryRepository
    {
        private AppDbContext _appContext;
        public GalleryRepository(AppDbContext context) : base(context)
        {
            _appContext = context;
        }
    }
}
