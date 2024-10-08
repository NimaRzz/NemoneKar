using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Customers;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Services.Customers.Commands.AddCustomer;
using MainProject.Application.Services.Customers.Commands.DeleteCustomer;
using MainProject.Application.Services.Customers.Commands.EditCustomer;
using MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin;



namespace MainProject.Application.Services.Users.FacadPattern
{
    public class CustomerFacad : ICustomerFacad
    {
        private readonly IDataBaseContext _context;

        public CustomerFacad(IDataBaseContext context)
        {
            _context = context;
        }

        private IGetCustomersForAdminService _getCustomersForAdminService;

        public IGetCustomersForAdminService GetCustomersForAdminService
        {
            get
            {
                return _getCustomersForAdminService =
                    _getCustomersForAdminService ?? new GetCustomersForAdminService(_context);
            }
        }

        private IDeleteCustomerService _deleteCustomerService;

        public IDeleteCustomerService DeleteCustomerService
        {
            get
            {
                return _deleteCustomerService = _deleteCustomerService ?? new DeleteCustomerService(_context);
            }
        }

        private IEditCustomerService _editCustomerService;

        public IEditCustomerService EditCustomerService
        {
            get
            {
                return _editCustomerService = _editCustomerService ?? new EditCustomerService(_context);
            }
        }

        private IAddCustomerService _addCustomerService;

        public IAddCustomerService AddCustomerService
        {
            get
            {
                return _addCustomerService = _addCustomerService ?? new AddCustomerService(_context);
            }
        }

      

    }
}