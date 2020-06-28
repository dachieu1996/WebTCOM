using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Service.Implementation;
using TCOM.Service.ViewModels;

namespace TCOM.Service.Interfaces
{
    public interface  IHomeService
    {
        List<Home> Add(List<HomeCreateViewModel> Vm);
        List<Home> GetAll();
        HomeViewModel GetById(int id);
        HomeViewModel GetByLanguageId(int languageId);
        Home Update(HomeViewModel Vm);
        void Delete(int id);
    }
}
