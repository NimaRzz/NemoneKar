using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Users;
using MainProject.Common;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Users;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Users.Commands.EditUser
{
    public class EditUserService:IEditUserService
    {
        private readonly IDataBaseContext _context;

        public EditUserService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultDto Execute(RequestEditUserDto request)
        {

          
                var user = _context.Users.Find(request.UserId);

                if (user == null)
                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "کاربر یافت نشد"
                    };
                }

            if (string.IsNullOrWhiteSpace(request.UserName))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "نام کاربری را وارد کنید"
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

                if (!string.IsNullOrWhiteSpace(request.Password))
                {
if (request.Password.Length<8)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "رمز عبور باید بیشتر از 8 کاراکتر باشد"
                };
            }
                }
            



            if (!string.IsNullOrWhiteSpace(request.Password))
            {


                var passwordHasher = new PasswordHasher();
                if (passwordHasher.VerifyPassword(request.Password, user.Password))
                {
                    user.Password = request.Password;
                }
                else
                {
                    var hashedPassword = passwordHasher.HashPassword(request.Password);
                    user.Password = hashedPassword;
                }

            }

            user.IsActive = request.IsActive;
                    user.IsAdmin = request.IsAdmin;
                    user.Email = request.Email;
                    user.UserName = request.UserName;

                    user.UpdateTime = DateTime.Now;

                _context.SaveChanges();
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "کاربر با موفقیت ویرایش شد"
                };

            }
        

        }
    }

