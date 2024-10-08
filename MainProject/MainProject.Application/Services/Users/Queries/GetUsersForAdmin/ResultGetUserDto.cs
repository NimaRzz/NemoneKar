using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class ResultGetUserDto
    {
        public List<GetUsersDto> Users { get; set; }

        public int Rows { get; set; }
    }
}
