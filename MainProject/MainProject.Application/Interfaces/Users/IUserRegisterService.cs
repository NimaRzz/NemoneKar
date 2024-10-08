using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Commands.Register;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Users;

namespace MainProject.Application.Interfaces.UserServices
{
    public interface IUserRegisterService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);

    }
}
