using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Queries.GetRolesForAdmin;

namespace MainProject.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class GetUsersDto
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}
