using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Users;
using MainProject.Common.Dto;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Users.Commands.DeleteUser
{
    public class DeleteUserService:IDeleteUserService
    {
        private readonly IDataBaseContext _context;

        public DeleteUserService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultDto Execute(long UserId)
        {

           
                var user = _context.Users.Find(UserId);
                if (user == null)
                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "کاربر یافت نشد"
                    };
                }
            
            user.IsRemoved = true;

            user.RemoveTime = DateTime.Now;

            _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "کاربر با موفقیت حذف شد"

                };
          

         
    }

    }

}