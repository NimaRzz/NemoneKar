using MainProject.Domain.Model.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Domain.Model.Users
{
    public class UserInRole
    {
        public long Id { get; set; }

        public virtual User User { get; set; } 
        public long UserId { get; set; }

        public virtual Role Role { get; set; }
        public long RoleId { get; set; }

    }
}
