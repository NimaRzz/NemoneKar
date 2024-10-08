using MainProject.Application.Services.Users.Commands.Register;
using System.Collections.Generic;

namespace MainProject.Mvc.Areas.Admin.Models.ViewModels.User
{
    public class EditUserViewModel
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public List<RolesInRegisterUserDto> roles { get; set; }
    }
}
