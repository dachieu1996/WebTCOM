using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCOM.Core.Enums;
using TCOM.Core.Interfaces;
using TCOM.Data.EF;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;
using TCOM.Service.Interfaces;
using TCOM.Service.ViewModels;

namespace TCOM.Service.Implementation
{
    public  class LibraryService :  ILibraryService
    {
        #region Contructor
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private ILibraryRepository _ilibraryRepository;
        private readonly AppDbContext _dbContext;
        public LibraryService(IUnitOfWork unitOfWork, IMapper mapper, AppDbContext dbContext, ILibraryRepository ilibraryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ilibraryRepository = ilibraryRepository;
            _dbContext = dbContext;
        }
        #endregion Contructor

        public async Task<Library> Add(Library library)
        {
            _ilibraryRepository.Add(library);
            SaveChanges();
            return library;
        }


        private void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }

        public async Task<Library> GetAllByName(string name)
        {
            var result = _ilibraryRepository.FindAll(x => x.DeleteFlag != DeleteFlg.Delete).Where(x => x.Name == name).ToList();

            if (result.Count > 0)
            {
                return result[0];
            }
            return null;

        }
    }
}
