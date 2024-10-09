using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Users;
using MainProject.Common;
using MainProject.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace MainProject.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class GetUsersForAdminService:IGetUsersForAdminService
    {
        private readonly IDataBaseContext _context;

        public GetUsersForAdminService(IDataBaseContext context)
        {
            _context = context;
        }

         
        public ResultGetUserDto Execute(Ordering ordering, string SearchKey, int Page, int pageSize)
        {


            var roles = _context.Roles.AsQueryable();



            var userQuery = _context.Users
                .Include(p => p.UserInRoles)
                .ThenInclude(p => p.Role)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(SearchKey))
            {
                userQuery = userQuery.Where(p => p.UserName.Contains(SearchKey) || p.Email.Contains(SearchKey)).AsQueryable();
            }

            switch(ordering)
            {
                case Ordering.NotOrder:
                    userQuery = userQuery.OrderBy(p => p.Id).AsQueryable();
                    break;
                
                case Ordering.Id:
                    userQuery = userQuery.OrderBy(p => p.Id).AsQueryable();
                    break;

                case Ordering.Name:
                    userQuery = userQuery.OrderByDescending(p => p.UserName).AsQueryable();
                    break;

                case Ordering.Email:
                    userQuery = userQuery.OrderByDescending(p => p.Email).AsQueryable();
                    break;

                case Ordering.IsActive:
                    userQuery = userQuery.OrderByDescending(p => p.IsActive == true).AsQueryable();
                    break;

                case Ordering.IsAdmin:
                    userQuery = userQuery.OrderByDescending(p => p.IsAdmin == true).AsQueryable();
                    break;
                default:
                    break;
            }
            
            
            int rowsCount = 0;
            var usersList = userQuery
                .ToPaged(Page, pageSize, out rowsCount)
                .Select(p => new GetUsersDto()
            {
                Email = p.Email == null ? "خالی" : p.Email,
                UserName = p.UserName == null ? "خالی" : p.UserName,
                UserId = p.Id,
                IsActive = p.IsActive,
                IsAdmin = p.IsAdmin,
               Password = p.Password,
               Roles = p.UserInRoles.Select(ur => ur.Role.Name).ToList(),
               RoleIds = p.UserInRoles.Select(ur => ur.RoleId)
             
            }).ToList();
            if (usersList.Count == 0 || usersList == null)
            {
                return new ResultGetUserDto()
                {
                    Users = new List<GetUsersDto>(),
                    Rows = rowsCount
                };
            }

            return new ResultGetUserDto()
            {
                Users = usersList,
                Rows = rowsCount
            };
        }
    }
}
