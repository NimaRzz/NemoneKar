using MainProject.Application.Services.Users.Commands.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Users.Commands.AddUser
{
    public class RequestAddUserDto
    {
        public string UserName { get; set; }
      
        public string? Password { get; set; }
      
        public string Email { get; set; }
      
        public bool IsAdmin { get; set; }
      
        public bool IsActive { get; set; }
      

        public List<RolesInRegisterUserDto> roles { get; set; }

    }
}
