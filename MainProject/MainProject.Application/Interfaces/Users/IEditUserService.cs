using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Commands.EditUser;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Users
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEditUserDto request);
    }
}
