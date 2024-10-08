using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Users;

namespace MainProject.Application.Services.Users.Commands.Login
{
    public class ResultLoginUserDto
    {
        public long UserId { get; set; }
        public string UserName { get; set; }

        public List<string> Roles { get; set; }
    }
}
