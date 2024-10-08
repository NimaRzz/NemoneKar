using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Customers;

namespace MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin
{
    public class GetCustomersDto
    {
        

        public long CustomerId { get; set; }
        
        public string UserName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public City City { get; set; }

        public Province Province { get; set; }

       
    }
}
