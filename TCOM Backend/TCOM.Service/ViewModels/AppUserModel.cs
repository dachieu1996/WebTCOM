using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Core.Enums;

namespace TCOM.Service.ViewModels
{
    public class AppUserViewModel
    {
        public Guid? Id { set; get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public Guid RoleId { get; set; }
    }

    public class AppUserModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDay { set; get; }
        public string Avatar { get; set; }
        public string PasswordHash { get; set; }
        public Guid RoleId { get; set; }
    }
}
