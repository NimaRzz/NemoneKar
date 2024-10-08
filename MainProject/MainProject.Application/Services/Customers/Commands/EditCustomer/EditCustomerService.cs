using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Customers;
using MainProject.Common.Dto;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Customers.Commands.EditCustomer
{
    public class EditCustomerService:IEditCustomerService
    {
        private readonly IDataBaseContext _context;

        public EditCustomerService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditCustomerDto request)
        {
            var customer = _context.Customers.Find(request.CustomerId);
            var city = _context.Cities.Find(request.CityId);
            var province = _context.Provinces.Find(request.ProvinceId);
           
            if (customer == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "مشتری پیدا نشد"
                };
            }

            if (string.IsNullOrWhiteSpace(request.Phone))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "تلفن را وارد کنید"
                };
            }

            if (!IsValidPhone(request.Phone))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شماره موبایل را به درستی وارد کنید"
                };
            }

            if (string.IsNullOrWhiteSpace(request.Address))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "آدرس را وارد کنید"
                };
            }

            if (request.CityId == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شهر را وارد کنید"
                };
            }

            if (request.ProvinceId == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "استان را وارد کنید"
                };
            }

            if (string.IsNullOrWhiteSpace(request.Phone))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "تلفن را وارد کنید"
                };
            }

            customer.Address = request.Address;
            customer.City = city;
            customer.Province = province;
            customer.Phone = request.Phone;
            customer.Id = request.CustomerId;

            customer.UpdateTime = DateTime.Now;
           
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "مشتری با موفقیت ویرایش شد"
            };
        }

        private bool IsValidPhone(string phone)
        {
            string pattern = @"^0[0-9]{10}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
