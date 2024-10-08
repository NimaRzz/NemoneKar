using MainProject.Application.Services.Users.Commands.Register;
using System.Collections.Generic;

namespace MainProject.Mvc.Models.ViewModels.AuthenticationViewModel
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set;}
        public string UserName { get; set; }

        public List<RolesInRegisterUserDto> roles { get; set; }
    }
}
