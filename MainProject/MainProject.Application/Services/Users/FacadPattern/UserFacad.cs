using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Interfaces.Users;
using MainProject.Application.Interfaces.UserServices;
using MainProject.Application.Services.Users.Commands.AddUser;
using MainProject.Application.Services.Users.Commands.DeleteUser;
using MainProject.Application.Services.Users.Commands.EditUser;
using MainProject.Application.Services.Users.Commands.Login;
using MainProject.Application.Services.Users.Commands.Register;
using MainProject.Application.Services.Users.FacadPattern;
using MainProject.Application.Services.Users.Queries.GetRolesForAdmin;
using MainProject.Application.Services.Users.Queries.GetUsersForAdmin;


namespace MainProject.Application.Services.Customers.FacadPattern
{
    public class UserFacad: IUserFacad
    {
        private readonly IDataBaseContext _context;
        public UserFacad(IDataBaseContext context)
        {
            _context = context;
        }





        private IUserRegisterService _userRegisterService;

        public IUserRegisterService UserRegisterService
        {
            get
            {
                return _userRegisterService = _userRegisterService ?? new UserRegisterService(_context);
            }
        }



        private IUserLoginService _userLoginService;

        public IUserLoginService UserLoginService
        {
            get
            {
                return _userLoginService = _userLoginService ?? new UserLoginService(_context);
            }
        }
        
        private IGetUsersForAdminService _getUsersForAdminService;

        public IGetUsersForAdminService GetUsersForAdminService
        {
            get
            {
                return _getUsersForAdminService = _getUsersForAdminService ?? new GetUsersForAdminService(_context);
            }
        }

        private IAddUserService _addUserService;

        public IAddUserService AddUserService
        {
            get
            {
                return _addUserService = _addUserService ?? new AddUserService(_context);
            }
        }

        private IEditUserService _editUserService;

        public IEditUserService EditUserService
        {
            get
            {
                return _editUserService = _editUserService ?? new EditUserService(_context);
            }
        }


        private IDeleteUserService _deleteUserService;

        public IDeleteUserService DeleteUserService
        {
            get
            {
                return _deleteUserService = _deleteUserService ?? new DeleteUserService(_context);
            }
        }

        private IGetRolesForAdminService _getRolesForAdminService;

        public IGetRolesForAdminService GetRolesForAdminService
        {
            get
            {
                return _getRolesForAdminService = _getRolesForAdminService ?? new GetRolesForAdminService(_context);
            }
        }

    }
}
