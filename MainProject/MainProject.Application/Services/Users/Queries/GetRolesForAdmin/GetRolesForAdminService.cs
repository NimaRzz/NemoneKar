using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Users;
using MainProject.Common.Dto;

namespace MainProject.Application.Services.Users.Queries.GetRolesForAdmin
{
    public class GetRolesForAdminService:IGetRolesForAdminService
    {
        private readonly IDataBaseContext _context;

        public GetRolesForAdminService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<RolesDto>> Execute()
        {
            var roles = _context.Roles.ToList().Select(p => new RolesDto()
            {
             Id = p.Id,
             Name = p.Name
            }).ToList();



            return new ResultDto<List<RolesDto>>()
            {
                Data = roles,
                IsSuccess = true,
                Message = ""
            };
        }
    }
}
