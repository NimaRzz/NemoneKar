using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Commands.AddUser;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Users
{
    public interface IAddUserService
    {
        ResultDto Execute(RequestAddUserDto request);
    }
}
