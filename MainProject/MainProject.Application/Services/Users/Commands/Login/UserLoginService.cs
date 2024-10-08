using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Common;
using MainProject.Application.Interfaces.Users;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Users;
using Microsoft.EntityFrameworkCore;

namespace MainProject.Application.Services.Users.Commands.Login
{
    public class UserLoginService:IUserLoginService
    {
        private readonly IDataBaseContext _context;

        public UserLoginService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultLoginUserDto> Execute(RequestLoginUserDto request)
        {

            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = new ResultLoginUserDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "پست الکترونیک و رمز عبور را وارد نمایید"
                };
            }






            var user = _context.Users
                .Include(p => p.UserInRoles)
                .ThenInclude(p => p.Role)
                .Where(p => p.Email.Equals(request.Email) && p.IsActive == true)
                .FirstOrDefault();

            if (user == null)
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = new ResultLoginUserDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "کاربری یافت نشد"
                };
            }
            
            var passwordHasher = new PasswordHasher();
            bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, request.Password);
            if (resultVerifyPassword==false)
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data =new ResultLoginUserDto()
                    {
                    },
                        IsSuccess = false,
                    Message = "رمز ورود اشتباه است"
                };
            }


            List<string> roles = new List<string>();
            foreach (var item in user.UserInRoles)
            {
                roles.Add(item.Role.Name);
            }

            return new ResultDto<ResultLoginUserDto>()
            {
                Data =new ResultLoginUserDto()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Roles = roles
                },
                IsSuccess = true,
                Message = "ورود با موفقیت انجام شد"
            };
        }
   
}
}
