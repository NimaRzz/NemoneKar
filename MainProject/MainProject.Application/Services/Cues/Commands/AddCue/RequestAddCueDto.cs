using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Users;

namespace MainProject.Application.Services.Cues.Commands.AddCue
{
    public class RequestAddCueDto
    {
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public long CustomerId { get; set; }

    }
}
