using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Customers;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Customers;
using MainProject.Domain.Model.Users;
using Microsoft.EntityFrameworkCore;

namespace MainProject.Application.Services.Customers.Commands.AddCustomer
{
    public class AddCustomerService : IAddCustomerService
    {
        private readonly IDataBaseContext _context;

        public AddCustomerService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddCustomerDto request)
        {



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

            var user = _context.Users.Find(request.UserId);
            var province = _context.Provinces.Find(request.ProvinceId);
            var city = _context.Cities.Find(request.CityId);
            var customers = _context.Customers.Include(p => p.User).FirstOrDefault(p => p.UserId == request.UserId);

            if (customers != null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "این کاربر مشتری است"
                };
            }

            Customer Customer = new Customer()
            {
                Address = request.Address,
                City = city,
                Province = province,
                Phone = request.Phone,
                User = user
            };
            if (user == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "کاربر را وارد کنید"
                };
            }

            user.IsCustomer = true;
            Customer.InsertTime = DateTime.Now;

            _context.Customers.Add(Customer);
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "مشتری با موفقیت افزوده شد"
            };

        }
        private bool IsValidPhone(string phone)
        {
            string pattern = @"^0[0-9]{10}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}