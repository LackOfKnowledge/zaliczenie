﻿using BlazorApp3.Data;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp3.Services
{
    public class AdminService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AdminService(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
    }
}
