using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Commands.Login;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Users
{
    public interface IUserLoginService
    {
        ResultDto<ResultLoginUserDto> Execute(RequestLoginUserDto request);
    }
}
