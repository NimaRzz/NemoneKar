using System;
using System.Collections.Generic;
using System.Linq;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Interfaces.Users;
using MainProject.Application.Services.Users.Commands.AddUser;
using MainProject.Application.Services.Users.Commands.DeleteUser;
using MainProject.Application.Services.Users.Commands.EditUser;
using MainProject.Application.Services.Users.Commands.Register;
using MainProject.Application.Services.Users.Queries.GetUsersForAdmin;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.Customer;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace PishroProject.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IUserFacad _userFacad;

        public UsersController(IUserFacad userFacad)
        {
            _userFacad = userFacad;
        }

        public IActionResult Index(Ordering ordering, string SearchKey, int Page=1, int pageSize=20)
        {
            var users = _userFacad.GetUsersForAdminService.Execute(ordering, SearchKey, Page, pageSize);

            return View(users);
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Roles = new SelectList(_userFacad.GetRolesForAdminService.Execute().Data, "Id", "Name");
            

            return View();
        }

        [HttpPost]
        [Route("/admin/users/Add")]
        public IActionResult Add(AddUserViewModel request)
        {
            var roleIds = new List<long>();
            if (!string.IsNullOrWhiteSpace(request.RoleIds))
            {
                roleIds = JsonConvert.DeserializeObject<List<long>>(request.RoleIds);
            }

            var userAddResult = _userFacad.AddUserService.Execute(new RequestAddUserDto()
            {
                Email = request.Email,
                Password = request.Password,
                UserName = request.UserName,
                IsAdmin = request.IsAdmin,
                IsActive = request.IsActive,
                roles = roleIds.Select(p => new RolesInRegisterUserDto()
                {
                    Id = p
                }).ToList()
            });
            return Json(userAddResult);
        }


        [HttpPost]
        [Route("/admin/users/Edit")]
        public IActionResult Edit(EditUserViewModel request)
        {
           var userEditResult = _userFacad.EditUserService.Execute(new RequestEditUserDto()
            {
                UserId = request.UserId,
                Email = request.Email,
                Password = request.Password,
                UserName = request.UserName,
                IsActive = request.IsActive,
                IsAdmin = request.IsAdmin,
            });

            return Json(userEditResult);
        }

        [HttpPost]
        [Route("/admin/users/Delete")]
        public IActionResult Delete(long UserId)
        {
            var userDeleteResult = _userFacad.DeleteUserService.Execute(UserId);
         

            return Json(userDeleteResult);
        }
    }
}
