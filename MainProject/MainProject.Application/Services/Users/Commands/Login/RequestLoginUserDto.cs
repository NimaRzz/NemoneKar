using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Users.Commands.Login
{
    public class RequestLoginUserDto
    {
        public string Email { get; set; }
       
        public string Password { get; set; }

    }
}
