using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Customers;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Cues;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerService:IDeleteCustomerService
    {
        private readonly IDataBaseContext _context;

        public DeleteCustomerService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long UserId)
        {
            var customer = _context.Customers.Find(UserId);
            var user = _context.Users.Find(UserId);

            if (customer == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "مشتری پیدا نشد"
                };
            }


            customer.IsRemoved = true;
            user.IsCustomer = false;
            
            customer.RemoveTime = DateTime.Now;
            
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "مشتری با موفقیت حذف شد"
            };

        }
    }
}
