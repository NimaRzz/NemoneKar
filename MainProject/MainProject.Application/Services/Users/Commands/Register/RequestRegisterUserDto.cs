using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Users.Commands.Register
{
    public class RequestRegisterUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string UserName { get; set; }

        public List<RolesInRegisterUserDto> roles { get; set; }

    }
}
