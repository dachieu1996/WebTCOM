using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCOM.Core.Dtos;
using TCOM.Data.Entities;
using TCOM.Service.Interfaces;
using TCOM.Core.Enums;
using Microsoft.AspNetCore.Hosting;

namespace TCOM.Web.Controllers
{
    public class LibraryController : BaseController
    {
        public class FIleUploadAPI
        {
            public IFormFile files { get; set; }
        }
        #region Constructor
        private ILibraryService _ilibraryService;
        private readonly IHostingEnvironment _environment;
        public LibraryController(ILibraryService ilibraryService, IHostingEnvironment environment)
        {
            _ilibraryService = ilibraryService;
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        #endregion Constructor

        [HttpPost]
        [Route("UploadFile")]
        // [AppAuthorize(PermissionTypes.Any, PermissionRule.update_news)]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile files, bool saveByName = false, string folderName = "")
        {
            var itemFiles = files;
            var rootFolder = Path.Combine("Resources", "Images");
            string fileName = "";
            if (!string.IsNullOrEmpty(folderName))
                folderName = Path.Combine(rootFolder, folderName);
            else
                folderName = rootFolder;
            var pathToSave = Path.Combine(_environment.WebRootPath, folderName);

            if (!Directory.Exists(pathToSave))
                Directory.CreateDirectory(pathToSave);
            if (itemFiles != null || itemFiles.Length > 0)
            {
                if (saveByName == false)
                    fileName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + Path.GetExtension(itemFiles.FileName);
                else
                    fileName = itemFiles.FileName;
                string fullPath = Path.Combine(pathToSave, fileName);
                string dbPath = Path.Combine(folderName, fileName);

                fullPath = fullPath.Replace("\\", "/");

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    itemFiles.CopyTo(stream);
                }
                var imageModel = new Library();
                imageModel.Name = fileName;
                imageModel.StorageLocation = dbPath;
                if (itemFiles.ContentType.Contains("image"))
                {
                    imageModel.Type = Core.Enums.Type.Image;
                }
                if (itemFiles.ContentType.Contains("video"))
                {
                    imageModel.Type = Core.Enums.Type.Video;
                }
                imageModel.Extension = Path.GetExtension(fileName);

                var result = await _ilibraryService.Add(imageModel);

                return new OkObjectResult(new GenericResult(true, result));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}