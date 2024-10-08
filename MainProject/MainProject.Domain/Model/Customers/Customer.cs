using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Commons;
using MainProject.Domain.Model.Users;

namespace MainProject.Domain.Model.Customers
{
    public class Customer:BaseModel
    {
        public virtual User User { get; set; }

        public virtual long UserId { get; set; }

        public string Phone { get; set; }
       
        public string Address { get; set; }

        public virtual Province Province { get; set; }
        public virtual long ProvinceId { get; set; }

        public virtual City City { get; set; }
        public virtual long CityId { get; set; }
	}
}
