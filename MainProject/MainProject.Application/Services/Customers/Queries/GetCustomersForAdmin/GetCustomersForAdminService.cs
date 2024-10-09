using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Customers;
using MainProject.Application.Services.Users.Queries.GetUsersForAdmin;
using MainProject.Common;
using Microsoft.EntityFrameworkCore;

namespace MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin
{
    public class GetCustomersForAdminService:IGetCustomersForAdminService
    {
        private readonly IDataBaseContext _context;

        public GetCustomersForAdminService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCustomerDto Execute(int Page)
        {
            var customers = _context.Customers.AsQueryable();




            int rowsCount = 0;
            var customersList = customers.Include(p => p.User).Include(p => p.City).Include(p => p.Province).ToPaged(Page, 20, out rowsCount).Select(p => new GetCustomersDto()
            {
                CustomerId = p.Id,
                Phone = p.Phone,
                UserName = p.User.UserName,
                Address = p.Address,
                City = p.City,
                Province = p.Province,
            }).ToList();

            if (customersList.Count == 0 || customersList == null)
            {
                return new ResultGetCustomerDto()
                {
                    Customers = new List<GetCustomersDto>(),
                    Rows = 0
                };
            }

            return new ResultGetCustomerDto()
            {
                Customers = customersList,
                Rows = rowsCount
            };
        }
    }
}
