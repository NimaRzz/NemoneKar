using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Customers
{
    public interface IGetCustomersForAdminService
    {
        ResultGetCustomerDto Execute(int Page);
    }
}
