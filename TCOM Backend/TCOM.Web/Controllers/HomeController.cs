using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCOM.Core.Dtos;
using TCOM.Service.Interfaces;
using TCOM.Service.ViewModels;

namespace TCOM.Web.Controllers
{
    public class HomeController : BaseController
    {
        #region Constructor
        private IHomeService _ihomeService;

        public HomeController(IHomeService homeService)
        {
            _ihomeService = homeService;
        }
        #endregion Constructor

        #region GET
        [HttpGet]
        [Route("GetAll")]
        //[AppAuthorize(PermissionTypes.Any, PermissionRule.view_contact)]
        public IActionResult GetAll()
        {
            try
            {
                var data = _ihomeService.GetAll();
                return new OkObjectResult(new GenericResult(true, data));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }

        [HttpGet]
        [Route("GetById")]
        //[AppAuthorize(PermissionTypes.Any, PermissionRule.view_contact)]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _ihomeService.GetById(id);
                return new OkObjectResult(new GenericResult(true, data));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }


        [HttpGet]
        [Route("GetByLanguageId")]
        //[AppAuthorize(PermissionTypes.Any, PermissionRule.view_contact)]
        public IActionResult GetByLanguage(int languageId)
        {
            try
            {
                var data = _ihomeService.GetByLanguageId(languageId);
                return new OkObjectResult(new GenericResult(true, data));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
        }
        #endregion GET

        #region POST
        [HttpPost]
        [Route("Add")]
       // [AppAuthorize(PermissionTypes.Any, PermissionRule.update_news)]
        public IActionResult Add([FromBody] List<HomeCreateViewModel> Vm)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(new GenericResult(false, allErrors));
            }
            else
            {
                try
                {
                    _ihomeService.Add(Vm);

                    return new OkObjectResult(new GenericResult(true, "Add success!!!"));
                }
                catch (Exception ex)
                {
                    return new OkObjectResult(new GenericResult(false, ex.Message));
                }
            }
        }

        
        #endregion POST

        #region PUT
        [HttpPut]
        [Route("Update")]
        // [AppAuthorize(PermissionTypes.Any, PermissionRule.update_news)]
        public IActionResult Update([FromBody] HomeViewModel Vm)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(new GenericResult(false, allErrors));
            }
            else
            {
                try
                {
                    _ihomeService.Update(Vm);

                    return new OkObjectResult(new GenericResult(true, "Update success!!!"));
                }
                catch (Exception ex)
                {
                    return new OkObjectResult(new GenericResult(false, ex.Message));
                }
            }
        }
        #endregion PUT

        #region DELETE
        [HttpDelete]
        [Route("Delete")]
        // [AppAuthorize(PermissionTypes.Any, PermissionRule.update_news)]
        public IActionResult Delete(int id)
        {
            try
            {
                _ihomeService.Delete(id);

                return new OkObjectResult(new GenericResult(true, "Delete success!!!"));
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new GenericResult(false, ex.Message));
            }
            
        }
        #endregion DELETE
    }
}