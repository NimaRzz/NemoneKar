using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Customers.Commands.EditCustomer
{
    public class RequestEditCustomerDto
    {
        public long CustomerId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public long ProvinceId { get; set; }
    }
}
