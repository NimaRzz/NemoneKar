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
using MD.PersianDateTime;
using MainProject.Application.Services.Users.Commands.Register;
using System.Text.RegularExpressions;

namespace MainProject.Application.Services.Users.Commands.AddUser
{
    public class AddUserService : IAddUserService
    {
        private readonly IDataBaseContext _context;

        public AddUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddUserDto request)
        {
        
            if (string.IsNullOrWhiteSpace(request.UserName))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "نام کاربری را وارد کنید"
                };
            }
         
            if (request.roles.Count == 0)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "حداقل یک نقش را وارد کنید"
                };
            }

            if (string.IsNullOrWhiteSpace(request.Email))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "پست الکترونیک را وارد کنید"
                };
            }


            if (string.IsNullOrWhiteSpace(request.Password))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "رمز عبور را وارد کنید"
                };
            }

            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
            var match = Regex.Match(request.Email, emailRegex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = " پست الکترونیک را به درستی وارد کنید"
                };
}
                var passwordHasher = new PasswordHasher();
                var hasehdPassword = passwordHasher.HashPassword(request.Password);

                
                
                User user = new User()
                {
                    Email = request.Email,
                    UserName = request.UserName,
                    IsAdmin = request.IsAdmin,
                    IsActive = request.IsActive,
                    Password = hasehdPassword,
                    IsCustomer = false,
                };
              
                _context.Users.Add(user);
                _context.SaveChanges();

                List<UserInRole> userInRoles = new List<UserInRole>();

                foreach (var item in request.roles)
                {
                    var roles = _context.Roles.Find(item.Id);
                    if(roles != null){ 
                        userInRoles.Add(new UserInRole()
                    {
                        Role = roles,
                        RoleId = roles.Id,
                        User = user,
                        UserId = user.Id
                    });

                    }
                   
                }
                
                user.UserInRoles = userInRoles;
                user.InsertTime = DateTime.Now;

               _context.UserInRoles.AddRange(userInRoles);
               _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "کاربر با موفقیت اضافه شد"
                };

            }
        

        }
    }
    
