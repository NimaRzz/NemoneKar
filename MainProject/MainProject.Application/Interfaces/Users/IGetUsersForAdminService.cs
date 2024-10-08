using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Users.Queries.GetUsersForAdmin;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Users
{
    public interface IGetUsersForAdminService
    {
        ResultGetUserDto Execute(Ordering ordering, string SearchKey, int Page, int pageSize);
    }

    public enum Ordering
    {
        Id= 0,

        Name = 1,

        Email = 2,

        IsActive = 3,

        IsAdmin = 4,

        AccessLevel = 5,

        NotOrder = 6,

        



    }
    
}
