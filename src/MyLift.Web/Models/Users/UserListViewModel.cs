﻿using System.Collections.Generic;
using MyLift.Roles.Dto;
using MyLift.Users.Dto;

namespace MyLift.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}