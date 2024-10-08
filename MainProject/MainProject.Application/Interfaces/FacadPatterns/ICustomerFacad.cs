using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Customers;

namespace MainProject.Application.Interfaces.FacadPatterns
{
    public interface ICustomerFacad
    {
        IGetCustomersForAdminService GetCustomersForAdminService { get; }

        IDeleteCustomerService DeleteCustomerService { get; }

        IEditCustomerService EditCustomerService { get; }
       
        IAddCustomerService AddCustomerService { get; }
    }
}
