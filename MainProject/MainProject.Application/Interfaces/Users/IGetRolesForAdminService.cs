using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Queries.GetRolesForAdmin;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Users
{
    public interface IGetRolesForAdminService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
