using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Commons;

namespace MainProject.Domain.Model.Users
{
    public class Role:BaseModel
    {

        public string Name { get; set; }

        public virtual ICollection<UserInRole> UserInRoles { get; set; }
    }
}
