﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class UserListViewModel
    {
        public UserListViewModel()
        {
            appRoleLists = new List<AppRoleListViewModel>();
            Roles = new List<string>();
        }

        public string AppUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Nationality { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] AvatarImage { get; set; }
        public string role { get; set; }
        public string School { get; set; }
        public string HighSchool { get; set; }
        public string specialization { get; set; }

        public string Degree { get; set; }
        public List<string> Roles { get; set; }
        public List<AppRoleListViewModel> appRoleLists { get; set; }

    }
}
