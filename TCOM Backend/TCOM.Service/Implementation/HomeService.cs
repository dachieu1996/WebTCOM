using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCOM.Core.Enums;
using TCOM.Core.Interfaces;
using TCOM.Data.EF;
using TCOM.Data.Entities;
using TCOM.Data.IRepositories;
using TCOM.Service.Interfaces;
using TCOM.Service.ViewModels;

namespace TCOM.Service.Implementation
{
    public class HomeService : IHomeService
    {
        #region Contructor
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IHomeRepository _ihomeRepo;
        private readonly AppDbContext _dbContext;

        public HomeService(IUnitOfWork unitOfWork, IMapper mapper, AppDbContext dbContext, IHomeRepository homeRepo)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ihomeRepo = homeRepo;
            _dbContext = dbContext;
        }
        #endregion Contructor

        #region GET

        public List<Home> GetAll()
        {
            var lstHome = _ihomeRepo.FindAll(x => x.DeleteFlag != DeleteFlg.Delete).ToList();
            return lstHome;
        }

        public HomeViewModel GetByLanguageId(int languageId)
        {
            var data = _ihomeRepo.FindAll(x => x.DeleteFlag != DeleteFlg.Delete && x.LanguageId == languageId).FirstOrDefault();
            return _mapper.Map<Home, HomeViewModel>(data);
        }
        public HomeViewModel GetById(int id)
        {
            var data = _ihomeRepo.FindById(id);
            return _mapper.Map<Home, HomeViewModel>(data);

        }
        #endregion GET

        #region POST
        public List<Home> Add(List<HomeCreateViewModel> Vm)
        {
            var entity = _mapper.Map<List<Home>>(Vm);
            _ihomeRepo.Add(entity);
            SaveChanges();

            #region Update Images
            var vmFirst = Vm.FirstOrDefault();
            var listHome = _ihomeRepo.FindAll();
            var firstHome = listHome.FirstOrDefault();

            foreach (var data in listHome)
            {
                if (!string.IsNullOrEmpty(vmFirst.FirstImgUrl))
                {
                    data.FirstImgUrl = vmFirst.FirstImgUrl;
                }
                else
                {
                    if (firstHome != null)
                        data.FirstImgUrl = firstHome.FirstImgUrl;
                }

                if (!string.IsNullOrEmpty(vmFirst.SencondImgUrl))
                {
                    data.SencondImgUrl = vmFirst.SencondImgUrl;
                }
                else
                {
                    if (firstHome != null)
                        data.SencondImgUrl = firstHome.SencondImgUrl;
                }
                _ihomeRepo.Update(data);
            }
            SaveChanges();
            #endregion

            return entity;
        }
        #endregion POST

        #region PUT
        public Home Update(HomeViewModel Vm)
        {
            var data = _mapper.Map<Home>(Vm);

            #region Update Images
            var listHome = _ihomeRepo.FindAll(x => x.Id != Vm.Id).ToList();
            foreach (var item in listHome)
            {
                if (!string.IsNullOrEmpty(data.FirstImgUrl))
                    item.FirstImgUrl = data.FirstImgUrl;
                if (!string.IsNullOrEmpty(data.SencondImgUrl))
                    item.SencondImgUrl = data.SencondImgUrl;
                _ihomeRepo.Update(item);
            }
            #endregion

            _ihomeRepo.Update(data);
            SaveChanges();
            return data;
        }
        #endregion PUT

        #region DELETE
        public void Delete(int id)
        {
            _ihomeRepo.Remove(id);
            SaveChanges();
        }
        #endregion DELETE

        private void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }


    }
}
