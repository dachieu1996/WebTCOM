using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCOM.Data.Entities;

namespace TCOM.Service.Interfaces
{
    public interface ILibraryService
    {
        Task<Library> Add(Library library);
        Task<Library> GetAllByName(string name);
    }
}
