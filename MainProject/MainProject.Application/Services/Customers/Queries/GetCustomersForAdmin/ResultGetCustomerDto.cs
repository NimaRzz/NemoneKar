using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin
{
    public class ResultGetCustomerDto
    {
        public List<GetCustomersDto> Customers { get; set; }

        public int Rows { get; set; }
    }
}
