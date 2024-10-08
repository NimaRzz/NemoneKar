using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.UserServices;
using MainProject.Application.Interfaces.Users;

namespace MainProject.Application.Interfaces.FacadPatterns
{
    public interface IUserFacad
    {
         IUserRegisterService UserRegisterService { get; }

         IUserLoginService UserLoginService { get; }
         
         IGetUsersForAdminService GetUsersForAdminService { get; }

         IAddUserService AddUserService { get; }
         
         IEditUserService EditUserService { get; }

         IDeleteUserService DeleteUserService { get; }

         IGetRolesForAdminService GetRolesForAdminService { get; }
    }
}
